using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                var acquisto = new AcquistoOnline();
                acquisto.DataVendita = DateSaleOnline.Value;
                acquisto.Cliente = ctx.Clientes.Where(c => c.CodFiscale == (String)CBSaleOnlineCodClient.SelectedItem)
                    .FirstOrDefault();
                acquisto.IdVendita = ctx.AcquistoOnlines.OrderByDescending(a => a.IdVendita).Select(a => a.IdVendita)
                    .FirstOrDefault() + 1;
                if (CBSaleOnlinePromotion.Visible && CBSaleOnlinePromotion.SelectedItem != null)
                {
                    var promozione = ctx.Promoziones.Where(p => p.IdPromozione == (int)CBSaleOnlinePromotion.SelectedItem)
                        .FirstOrDefault();
                    acquisto.Promozione = promozione;
                    promozione.Abbonamento.Add(ctx.Abbonamentos.Where(a => a.CodFiscale == acquisto.CodFiscale).Single());

                }
                else
                {
                    acquisto.Promozione = null;
                }
                ctx.AcquistoOnlines.InsertOnSubmit(acquisto);
                Spedizione spedizione = new Spedizione();
                spedizione.AcquistoOnline = acquisto;
                spedizione.Corriere = ctx.Corrieres.Where(c => c.IdCorriere == (long)CBSaleOnlineShipper.SelectedItem).FirstOrDefault();
                spedizione.DataOrdinazione = DateSaleOnline.Value;
                ctx.Spediziones.InsertOnSubmit(spedizione);
                for (int index = 0; index < GVSaleOnlineProduct.Rows.Count; index++)
                {
                    var dettagli = new Dettaglivendita();
                    dettagli.AcquistoInNegozio = null;
                    dettagli.AcquistoOnline = acquisto;
                    dettagli.Prodotto = ctx.Prodottos.Where(p => p.IdProdotto == (int)GVSaleOnlineProduct.Rows[index].Cells["Id"].Value)
                        .FirstOrDefault();
                    dettagli.NProdotti = (int)GVSaleOnlineProduct.Rows[index].Cells["Quantity"].Value;
                    dettagli.IdDettagli = ctx.Dettaglivenditas.OrderByDescending(d => d.IdDettagli)
                        .Select(d => d.IdDettagli).FirstOrDefault() + index +1;
                    ctx.Dettaglivenditas.InsertOnSubmit(dettagli);
                }
                ctx.SubmitChanges();
                this.Close();
            }
        }
    }
}
