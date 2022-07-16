using Devart.Data.Linq;
using GamestartLogicContext;
using System;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;

namespace GameStartApp
{
    public partial class Menu : Form
    {
        private bool _online;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Text = "GameStart";
            // TODO: This line of code loads data into the 'gamestart_logicDataSet.torneo' table. You can move, or remove it, as needed.
            this.torneoTableAdapter.Fill(this.gamestart_logicDataSet.torneo);
            // TODO: This line of code loads data into the 'gamestart_logicDataSet.abbonamento' table. You can move, or remove it, as needed.
            this.abbonamentoTableAdapter.Fill(this.gamestart_logicDataSet.abbonamento);
            // TODO: This line of code loads data into the 'gamestart_logicDataSet.promozione' table. You can move, or remove it, as needed.
            this.promozioneTableAdapter.Fill(this.gamestart_logicDataSet.promozione);
            // TODO: This line of code loads data into the 'gamestart_logicDataSet.preordine' table. You can move, or remove it, as needed.
            this.preordineTableAdapter.Fill(this.gamestart_logicDataSet.preordine);
            // TODO: This line of code loads data into the 'gamestart_logicDataSet.preordine' table. You can move, or remove it, as needed.
            this.preordineTableAdapter.Fill(this.gamestart_logicDataSet.preordine);
            // TODO: This line of code loads data into the 'gamestart_logicDataSet.acquisto_online' table. You can move, or remove it, as needed.
            this.acquisto_onlineTableAdapter.Fill(this.gamestart_logicDataSet.acquisto_online);
            BtnSaleDispStore.Enabled = false;
            _online = false;
            // TODO: This line of code loads data into the 'gamestart_logicDataSet.acquisto_in_negozio' table. You can move, or remove it, as needed.
            this.acquisto_in_negozioTableAdapter.Fill(this.gamestart_logicDataSet.acquisto_in_negozio);
            // TODO: This line of code loads data into the 'gamestart_logicDataSet.prodotto' table. You can move, or remove it, as needed.
            this.prodottoTableAdapter.Fill(this.gamestart_logicDataSet.prodotto);
            CBProdType.Items.AddRange(new string[] { "Videogioco", "Pupazzo", "Codice" });
            DateProdMost.Format = DateTimePickerFormat.Custom;
            DateProdMost.CustomFormat = "MMM yyy";
            DateProdMost.ShowUpDown = true;
            // TODO: This line of code loads data into the 'gamestart_logicDataSet.dipendente' table. You can move, or remove it, as needed.
            this.dipendenteTableAdapter.Fill(this.gamestart_logicDataSet.dipendente);
            // TODO: This line of code loads data into the 'gamestart_logicDataSet.filiale' table. You can move, or remove it, as needed.
            this.filialeTableAdapter.Fill(this.gamestart_logicDataSet.filiale);
            DateBranchMost.Format = DateTimePickerFormat.Custom;
            DateBranchMost.CustomFormat = "MMM yyy";
            DateBranchMost.ShowUpDown = true;
            // TODO: This line of code loads data into the 'gamestart_logicDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.gamestart_logicDataSet.cliente);
        }

        private void CBBranchesManager_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                CBBranchesManager.Items.Clear();
                CBBranchesManager.Items.AddRange(ctx.Gestores.Where(q => q.Filiale == null).Select(q => q.CodFiscale).ToArray());
            }
        }

        private void BtnSaleDispStore_Click(object sender, EventArgs e)
        {
            GVSaleStore.Visible = true;
            GVSaleOnline.Visible = false;
            BtnSaleDispStore.Enabled = false;
            BtnSaleDispOnline.Enabled = true;
            _online = false;
        }

        private void BtnSaleDispOnline_Click(object sender, EventArgs e)
        {
            GVSaleOnline.Visible = true;
            GVSaleStore.Visible = false;
            BtnSaleDispOnline.Enabled = false;
            BtnSaleDispStore.Enabled = true;
            _online = true;
        }

        private void BtnSaleAdd_Click(object sender, EventArgs e)
        {
            if (!_online)
            {
                var form = new AddSaleStore
                {
                    Text = "Add Sale in Store",
                    Height = 400,
                    Width = 350
                };
                form.ShowDialog();
                form.FormClosed += (s, ea) => RefreshGrid(GVSaleStore);
            } else
            {
                var form = new AddSaleOnline
                {
                    Text = "Add Sale Online",
                    Height = 400,
                    Width = 350
                };
                form.ShowDialog();
                form.FormClosed += (s, ea) => RefreshGrid(GVSaleOnline);
            }
        }

        private void RefreshGrid(DataGridView gridView)
        {
            acquistoinnegozioBindingSource.ResetBindings(true);
            var src = gridView.DataSource;
            gridView.DataSource = null;
            gridView.DataSource = src;
            gridView.Refresh();
        }

        private void BtnBranchAdd_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                Filiale filiale = new Filiale();
                filiale.CittÃ = TxtBranchCity.Text;
                filiale.Gestore = ctx.Gestores.Where(g => g.CodFiscale == (string)CBBranchesManager.SelectedItem)
                    .FirstOrDefault();
                filiale.Via = TxtBranchesStreet.Text == "" ? null : TxtBranchesStreet.Text;
                filiale.NCivico = TxtBranchesCivic.Text == "" ? null : TxtBranchesCivic.Text;
                ctx.Filiales.InsertOnSubmit(filiale);
                ctx.SubmitChanges();
            }
        }

        private void BtnManAdd_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                Gestore gestore = new Gestore();
                gestore.CittÃ = TxtManCity.Text;
                gestore.Via = TxtManCity.Text == "" ? null : TxtManCity.Text;
                gestore.NCivico = TxtManCivic.Text == "" ? null : TxtManCivic.Text;
                gestore.CodFiscale = TxtManCod.Text;
                gestore.Nome = TxtManName.Text;
                gestore.Cognome = TxtManSurname.Text;
                gestore.DataNascita = DateManBirth.Value;
                ctx.Gestores.InsertOnSubmit(gestore);
                ctx.SubmitChanges();
            }
        }

        private void BtnEmpAdd_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                Dipendente dipendente = new Dipendente();
                dipendente.CittÃ = TxtEmpCity.Text;
                dipendente.Via = TxtEmpCity.Text == "" ? null : TxtEmpCity.Text;
                dipendente.NCivico = TxtEmpCivic.Text == "" ? null : TxtEmpCivic.Text;
                dipendente.CodFiscale = TxtEmpCod.Text;
                dipendente.Nome = TxtEmpName.Text;
                dipendente.Cognome = TxtEmpSurname.Text;
                dipendente.DataNascita = DateEmpBirth.Value;
                ctx.Dipendentes.InsertOnSubmit(dipendente);
                ctx.SubmitChanges();
            }
        }

        private void CBPreCodCli_Click(object sender, EventArgs e)
        {
            using(GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                CBPreCodCli.Items.Clear();
                CBPreCodCli.Items.AddRange(ctx.Clientes.Select(c => c.CodFiscale).ToArray());
            }
        }

        private void CBPreProd_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                CBPreProd.Items.Clear();
                CBPreProd.Items.AddRange(ctx.Prodottos.Select(c => c.IdProdotto.ToString()).ToArray());
            }
        }

        private void BtnPreAdd_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                Preordine preordine = new Preordine();
                preordine.Prodotto = ctx.Prodottos.Where(p => p.IdProdotto == long.Parse((string)CBPreProd.SelectedItem))
                    .FirstOrDefault();
                preordine.Cliente = ctx.Clientes.Where(c => c.CodFiscale == (string) CBPreCodCli.SelectedItem).FirstOrDefault();
                preordine.DataVendita = DatePreorder.Value;
                preordine.DataUscitaProdotto = DatePreArrival.Value;
                preordine.IdPreordine = ctx.Preordines.OrderByDescending(p => p.IdPreordine).Select(p => p.IdPreordine)
                    .FirstOrDefault() + 1;
                ctx.Preordines.InsertOnSubmit(preordine);
                ctx.SubmitChanges();
            }
        }

        private void BtnPromAdd_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                Promozione promozione = new Promozione();
                promozione.Descrizione = TxtPromDesc.Text;
                promozione.Sconto = long.TryParse(TxtPromSconto.Text, out long sconto) ? sconto : -1;
                if (sconto > 0)
                {
                    promozione.DataInizio = DatePromStart.Value;
                    promozione.DataFine = DatePromEnd.Value;
                    promozione.IdPromozione = ctx.Promoziones.OrderByDescending(p => p.IdPromozione).Select(p => p.IdPromozione)
                        .FirstOrDefault() + 1;
                    ctx.Promoziones.InsertOnSubmit(promozione);
                    ctx.SubmitChanges();
                }
            }
        }

        private void CBSubCod_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                CBSubCod.Items.Clear();
                CBSubCod.Items.AddRange(ctx.Clientes.Select(c => c.CodFiscale).ToArray());  
            }
        }

        private void BtnSubAdd_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                Abbonamento abbonamento = new Abbonamento();
                abbonamento.Cliente = ctx.Clientes.Where(c => c.CodFiscale == (string) CBSubCod.SelectedItem).FirstOrDefault();
                abbonamento.DataInizio = DateSubStart.Value;
                abbonamento.ValiditÃ = DateSubEnd.Value;
                abbonamento.IdAbbonamento = ctx.Abbonamentos.OrderByDescending(a => a.IdAbbonamento).Select(a => a.IdAbbonamento)
                    .FirstOrDefault() + 1;
                ctx.Abbonamentos.InsertOnSubmit(abbonamento);
                ctx.SubmitChanges();
            }
        }

        private void BtnProdAdd_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                Prodotto prodotto = new Prodotto();
                prodotto.Nome = TxtProdName.Text;
                prodotto.Prezzo = double.TryParse(TxtProdPrice.Text, out double prezzo) ? prezzo : -1;
                if (prezzo > 0)
                {
                    prodotto.IdProdotto = ctx.Prodottos.OrderByDescending(p => p.IdProdotto).Select(p => p.IdProdotto)
                        .FirstOrDefault() + 1;
                    ctx.Prodottos.InsertOnSubmit(prodotto);
                    ctx.SubmitChanges();
                }
            }
        }

        private void CBTourId_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                CBTourId.Items.Clear();
                CBTourId.Items.AddRange(ctx.Filiales.Select(f => f.IdFiliale.ToString()).ToArray());
            }
        }

        private void BtnTourAdd_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                Torneo torneo = new Torneo();
                torneo.Filiale = ctx.Filiales.Where(f => f.IdFiliale == long.Parse((String)CBTourId.SelectedItem))
                    .FirstOrDefault();
                torneo.Gioco = TxtTourGame.Text;
                torneo.Premio = TxtTourPrize.Text;
                torneo.NPartecipanti = 0;
                torneo.DataTorneo = DateTournament.Value;
                ctx.Torneos.InsertOnSubmit(torneo);
                ctx.SubmitChanges();
            }
        }

        private void CBTourPart_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                CBTourPart.Items.Clear();
                CBTourPart.Items.AddRange(ctx.Abbonamentos.Select(a => a.CodFiscale).ToArray());
            }
        }

        private void CBTourIdPart_Change(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                CBTourDate.Visible = true;
                CBTourDate.Items.Clear();
                CBTourDate.Items.AddRange(ctx.Torneos.Where(t => t.IdFiliale == long.Parse((string) CBTourIdPart.SelectedItem))
                    .Select(t => t.DataTorneo.ToString()).ToArray());
            }
        }

        private void CBTourIdPart_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                CBTourIdPart.Items.Clear();
                CBTourIdPart.Items.AddRange(ctx.Filiales.Select(f => f.IdFiliale.ToString()).ToArray());
            }
        }

        private void BtnTourAddPart_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                var torneo = ctx.Torneos
                    .Where(t => t.IdFiliale == long.Parse(CBTourIdPart.Text) &&
                    t.DataTorneo == DateTime.Parse(CBTourDate.Text))
                    .Single();
                torneo.Abbonamento.Add(ctx.Abbonamentos
                    .Where(a => a.CodFiscale == CBTourPart.Text).Single());
                torneo.NPartecipanti += 1;
                ctx.SubmitChanges();
            }
        }

        private void CBTourIdShow_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                CBTourIdShow.Items.Clear();
                CBTourIdShow.Items.AddRange(ctx.Filiales.Select(f => f.IdFiliale.ToString()).ToArray());
            }
        }

        private void CBTourIdShow_Change(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                CBTourDateShow.Visible = true;
                CBTourDateShow.Items.Clear();
                CBTourDateShow.Items.AddRange(ctx.Torneos.Where(t => t.IdFiliale == long.Parse((string)CBTourIdShow.SelectedItem))
                    .Select(t => t.DataTorneo.ToString()).ToArray());
            }
        }

        private void BtnTourShow_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                var torneo = ctx.Torneos.Where(t => t.IdFiliale == long.Parse(CBTourIdShow.Text) && 
                t.DataTorneo == DateTime.Parse(CBTourDateShow.Text)).Single();
                var query = ctx.Abbonamentos.Where(a => a.Torneo.Contains(torneo))
                    .Select(a => new
                    {
                        a.CodFiscale,
                        a.Cliente.Nome,
                        a.Cliente.Cognome,
                        a.Cliente.DataNascita,
                        a.IdAbbonamento
                    });
                ShowResults(query);
            }
        }

        private void BtnProdShowMost_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                var dateProd = from d in ctx.Dettaglivenditas
                               where d.AcquistoInNegozio.DataVendita.Month == DateProdMost.Value.Month ||
                               d.AcquistoOnline.DataVendita.Month == DateProdMost.Value.Month
                               select new
                               {
                                   d.IdProdotto,
                                   d.NProdotti
                               };
                var nProd = dateProd.GroupBy(d => d.IdProdotto)
                    .Select(d => new
                    {
                        IdProdotto = d.Key,
                        n = d.Sum(v => v.NProdotti)
                    });
                var max = nProd.Max(n => n.n);
                var maxProd = nProd.Where(n => n.n == max);
                var finalProd = maxProd.Join(ctx.Prodottos, o => o.IdProdotto, i => i.IdProdotto, (o,i) => new
                {
                    i.IdProdotto,
                    i.Nome,
                    i.Prezzo,
                    i.Tipologia,
                    o.n
                });
                ShowResults(finalProd);
            }
        }

        private void BtnBranchShowMost_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                var nProd = ctx.Dettaglivenditas
                    .Where(d => d.AcquistoInNegozio != null)
                    .Select(d => new
                    {
                        d.AcquistoInNegozio.Dipendente.Filiale.IdFiliale,
                        Città = d.AcquistoInNegozio.Dipendente.Filiale.CittÃ,
                        d.NProdotti
                    })
                    .GroupBy(d => d.IdFiliale)
                    .Select(i => new
                    {
                        IdFiliale = i.Key,
                        Città = ctx.Filiales.Where(f => f.IdFiliale == i.Key).Select(f => f.CittÃ).Single(),
                        n = i.Sum(d => d.NProdotti)
                    });
                var max = nProd.Max(n => n.n);
                var finalBranch = nProd.Where(b => b.n == max);
                ShowResults(finalBranch);
            }
        }

        private void ShowResults(IQueryable<object> query)
        {
            var result = new ResultGrid(query)
            {
                Text = "Result"
            };
            result.ShowDialog();
        }
    }
}
 