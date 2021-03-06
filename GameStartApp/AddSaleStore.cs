using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GamestartLogicContext;

namespace GameStartApp
{
    public partial class AddSaleStore : Form
    {

        private bool _first;

        public AddSaleStore()
        {
            InitializeComponent();
        }

        private void AddSaleStore_Load(object Sender, EventArgs e)
        {
           using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                CBSaleStoreCodClient.Items.AddRange(ctx.Clientes.Select(q => q.CodFiscale).ToArray());
                CBSaleStoreCodEmp.Items.AddRange(ctx.Dipendentes.Select(q => q.CodFiscale).ToArray());
                CBSaleStoreProdId.Items.AddRange(ctx.Prodottos.Select(q =>  q.IdProdotto.ToString()).ToArray());
                CBSaleStorePromotion.Items.AddRange(ctx.Promoziones.Select(q => q.IdPromozione.ToString()).ToArray());
                CBSaleStorePromotion.Visible = false;
                _first = true;
                GVSaleStoreProduct.Rows.Clear();
            }
        }

        private void BtnSaleStoreAddProd_Click(object sender, EventArgs e)
        {
            int index = 0;
            bool present = false;
            if (!_first)
            {
                for (; index < GVSaleStoreProduct.Rows.Count; index++)
                {
                    if ((long)GVSaleStoreProduct.Rows[index].Cells["Id"].Value ==
                        long.Parse((String)CBSaleStoreProdId.SelectedItem))
                    {
                        present = true;
                        break;
                    }
                }
            }
            var quantity = Int32.TryParse(TxtSaleStoreProdN.Text, out int q) ? q : -1;
            if (quantity > 0)
            {
                if (present)
                {
                    int tot = (int)GVSaleStoreProduct.Rows[index].Cells["Quantity"].Value;
                    GVSaleStoreProduct.Rows[index].Cells["Quantity"].Value = tot + Int32.Parse(TxtSaleStoreProdN.Text);
                }
                else
                {
                    index = GVSaleStoreProduct.Rows.Add();
                    GVSaleStoreProduct.Rows[index].Cells["Id"].Value = long.Parse((String)CBSaleStoreProdId.SelectedItem);
                    GVSaleStoreProduct.Rows[index].Cells["Quantity"].Value = Int32.Parse(TxtSaleStoreProdN.Text);
                    _first = false;
                }
            }
        }

        private void CBSaleStoreCodClient_Change(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                if(ctx.Abbonamentos.Where(c => c.CodFiscale == (String) CBSaleStoreCodClient.SelectedItem).Any())
                {
                    CBSaleStorePromotion.Visible = true;
                } else
                {
                    CBSaleStorePromotion.Visible = false;
                }
            }
        }

        private void BtnSaleStoreCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSaleStoreOk_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                var acquisto = new AcquistoInNegozio
                {
                    DataVendita = DateSaleStore.Value,
                    Cliente = ctx.Clientes.Where(c => c.CodFiscale == (String)CBSaleStoreCodClient.SelectedItem)
                    .FirstOrDefault(),
                    Dipendente = ctx.Dipendentes.Where(d => d.CodFiscale == (String)CBSaleStoreCodEmp.SelectedItem)
                    .FirstOrDefault(),
                    IdVendita = ctx.AcquistoInNegozios.OrderByDescending(a => a.IdVendita).Select(a => a.IdVendita)
                    .FirstOrDefault() + 1
                };
                if (CBSaleStorePromotion.Visible && CBSaleStorePromotion.SelectedItem != null)
                {
                    var promozione = ctx.Promoziones.Where(p => p.IdPromozione == (int)CBSaleStorePromotion.SelectedItem)
                        .FirstOrDefault();
                    acquisto.Promozione = promozione;
                    var abbonamento = ctx.Abbonamentos.Where(a => a.CodFiscale == acquisto.CodFiscaleCliente).Single();
                    var offerta = new Offerta
                    {
                        Abbonamento = abbonamento,
                        Promozione = promozione,
                        IdOfferta = ctx.Offertas.Select(o => o.IdOfferta).OrderByDescending(o => o).FirstOrDefault() + 1
                    };
                } else
                {
                    acquisto.Promozione = null;
                }
                ctx.AcquistoInNegozios.InsertOnSubmit(acquisto);
                for (int index = 0; index < GVSaleStoreProduct.Rows.Count; index ++)
                {
                    var dettagli = new Dettaglivendita
                    {
                        AcquistoInNegozio = acquisto,
                        AcquistoOnline = null,
                        Prodotto = ctx.Prodottos.Where(p => p.IdProdotto == (int)GVSaleStoreProduct.Rows[index].Cells["Id"].Value)
                        .FirstOrDefault(),
                        NProdotti = (int)GVSaleStoreProduct.Rows[index].Cells["Quantity"].Value,
                        IdDettagli = ctx.Dettaglivenditas.OrderByDescending(d => d.IdDettagli)
                        .Select(d => d.IdDettagli).FirstOrDefault() + 1
                    };
                    ctx.Dettaglivenditas.InsertOnSubmit(dettagli);
                }
                ctx.SubmitChanges();
                this.Close();
            }
        }

    }
}
