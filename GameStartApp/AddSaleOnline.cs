using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GamestartLogicContext;

namespace GameStartApp
{
    public partial class AddSaleOnline : Form
    {

        private bool _first;
        public AddSaleOnline()
        {
            InitializeComponent();
        }

        private void AddSaleOnline_Load(object Sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                CBSaleOnlineCodClient.Items.AddRange(ctx.Clientes.Select(q => q.CodFiscale).ToArray());
                CBSaleOnlineProdId.Items.AddRange(ctx.Prodottos.Select(q => q.IdProdotto.ToString()).ToArray());
                CBSaleOnlineShipper.Items.AddRange(ctx.Corrieres.Select(q => q.IdCorriere.ToString()).ToArray());
                CBSaleOnlinePromotion.Items.AddRange(ctx.Promoziones.Select(q => q.IdPromozione.ToString()).ToArray());
                CBSaleOnlinePromotion.Visible = false;
                _first = true;
                GVSaleOnlineProduct.Rows.Clear();
            }
        }

        private void BtnSaleOnlineAddProd_Click(object sender, EventArgs e)
        {
            int index = 0;
            bool present = false;
            if (!_first)
            {
                for (; index < GVSaleOnlineProduct.Rows.Count; index++)
                {
                    if ((long)GVSaleOnlineProduct.Rows[index].Cells["Id"].Value ==
                        long.Parse((String)CBSaleOnlineProdId.SelectedItem))
                    {
                        present = true;
                        break;
                    }
                }
            }
            var quantity = Int32.TryParse(TxtSaleOnlineProdN.Text, out int q ) ? q : -1;
            if (quantity > 0)
            {
                if (present)
                {
                    int tot = (int)GVSaleOnlineProduct.Rows[index].Cells["Quantity"].Value;
                    GVSaleOnlineProduct.Rows[index].Cells["Quantity"].Value = tot + quantity;
                }
                else
                {
                    index = GVSaleOnlineProduct.Rows.Add();
                    GVSaleOnlineProduct.Rows[index].Cells["Id"].Value = long.Parse((String)CBSaleOnlineProdId.SelectedItem);
                    GVSaleOnlineProduct.Rows[index].Cells["Quantity"].Value = quantity;
                    _first = false;
                }
            }
        }

        private void CBSaleOnlineCodClient_Change(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                if (ctx.Abbonamentos.Where(c => c.CodFiscale == (String)CBSaleOnlineCodClient.SelectedItem).Any())
                {
                    CBSaleOnlinePromotion.Visible = true;
                }
                else
                {
                    CBSaleOnlinePromotion.Visible = false;
                }
            }
        }

        private void BtnSaleOnlineCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSaleOnlineOk_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                var acquisto = new AcquistoOnline
                {
                    DataVendita = DateSaleOnline.Value,
                    Cliente = ctx.Clientes.Where(c => c.CodFiscale == (String)CBSaleOnlineCodClient.SelectedItem)
                    .FirstOrDefault(),
                    IdVendita = ctx.AcquistoOnlines.OrderByDescending(a => a.IdVendita).Select(a => a.IdVendita)
                    .FirstOrDefault() + 1
                };
                if (CBSaleOnlinePromotion.Visible && CBSaleOnlinePromotion.SelectedItem != null)
                {
                    var promozione = ctx.Promoziones.Where(p => p.IdPromozione == (int)CBSaleOnlinePromotion.SelectedItem)
                        .FirstOrDefault();
                    acquisto.Promozione = promozione;
                    var abbonamento = ctx.Abbonamentos.Where(a => a.CodFiscale == acquisto.CodFiscale).Single();
                    var offerta = new Offerta
                    {
                        Abbonamento = abbonamento,
                        Promozione = promozione,
                        IdOfferta = ctx.Offertas.Select(o => o.IdOfferta).OrderByDescending(o => o).FirstOrDefault() + 1
                    };
                }
                else
                {
                    acquisto.Promozione = null;
                }
                ctx.AcquistoOnlines.InsertOnSubmit(acquisto);
                Spedizione spedizione = new Spedizione
                {
                    AcquistoOnline = acquisto,
                    Corriere = ctx.Corrieres.Where(c => c.IdCorriere == (long)CBSaleOnlineShipper.SelectedItem).FirstOrDefault(),
                    DataOrdinazione = DateSaleOnline.Value
                };
                ctx.Spediziones.InsertOnSubmit(spedizione);
                for (int index = 0; index < GVSaleOnlineProduct.Rows.Count; index++)
                {
                    var dettagli = new Dettaglivendita
                    {
                        AcquistoInNegozio = null,
                        AcquistoOnline = acquisto,
                        Prodotto = ctx.Prodottos.Where(p => p.IdProdotto == (int)GVSaleOnlineProduct.Rows[index].Cells["Id"].Value)
                        .FirstOrDefault(),
                        NProdotti = (int)GVSaleOnlineProduct.Rows[index].Cells["Quantity"].Value,
                        IdDettagli = ctx.Dettaglivenditas.OrderByDescending(d => d.IdDettagli)
                        .Select(d => d.IdDettagli).FirstOrDefault() + index + 1
                    };
                    ctx.Dettaglivenditas.InsertOnSubmit(dettagli);
                }
                ctx.SubmitChanges();
                this.Close();
            }
        }
    }
}
