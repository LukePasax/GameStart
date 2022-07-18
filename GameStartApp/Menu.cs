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
            // TODO: This line of code loads data into the 'gamestart_logicDataSet.gestore' table. You can move, or remove it, as needed.
            this.gestoreTableAdapter.Fill(this.gamestart_logicDataSet.gestore);
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
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext()) {
                if (!_online)
                {
                    var form = new AddSaleStore
                    {
                        Text = "Add Sale in Store",
                        Height = 400,
                        Width = 350
                    };
                    form.ShowDialog();
                    form.FormClosed += (s, ea) =>
                    {
                        GVSaleStore.DataSource = ctx.AcquistoInNegozios.ToList();
                    };
                } else
                {
                    var form = new AddSaleOnline
                    {
                        Text = "Add Sale Online",
                        Height = 400,
                        Width = 350
                    };
                    form.ShowDialog();
                    form.FormClosed += (s, ea) =>
                    {
                        GVSaleOnline.DataSource = ctx.AcquistoOnlines.ToList();
                    };
                }
            }
        }

        private void BtnBranchAdd_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                Filiale filiale = new Filiale
                {
                    CittÃ = TxtBranchCity.Text,
                    Gestore = ctx.Gestores.Where(g => g.CodFiscale == (string)CBBranchesManager.SelectedItem)
                    .FirstOrDefault(),
                    Via = TxtBranchesStreet.Text == "" ? null : TxtBranchesStreet.Text,
                    NCivico = TxtBranchesCivic.Text == "" ? null : TxtBranchesCivic.Text
                };
                ctx.Filiales.InsertOnSubmit(filiale);
                ctx.SubmitChanges();
                GVBranches.DataSource = ctx.Filiales.ToList();
            }
        }

        private void BtnManAdd_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                Gestore gestore = new Gestore
                {
                    CittÃ = TxtManCity.Text,
                    Via = TxtManCity.Text == "" ? null : TxtManCity.Text,
                    NCivico = TxtManCivic.Text == "" ? null : TxtManCivic.Text,
                    CodFiscale = TxtManCod.Text,
                    Nome = TxtManName.Text,
                    Cognome = TxtManSurname.Text,
                    DataNascita = DateManBirth.Value
                };
                ctx.Gestores.InsertOnSubmit(gestore);
                ctx.SubmitChanges();
                GVManager.DataSource = ctx.Gestores.ToList();
            }
        }

        private void BtnEmpAdd_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                Dipendente dipendente = new Dipendente
                {
                    CittÃ = TxtEmpCity.Text,
                    Via = TxtEmpCity.Text == "" ? null : TxtEmpCity.Text,
                    NCivico = TxtEmpCivic.Text == "" ? null : TxtEmpCivic.Text,
                    CodFiscale = TxtEmpCod.Text,
                    Nome = TxtEmpName.Text,
                    Cognome = TxtEmpSurname.Text,
                    DataNascita = DateEmpBirth.Value
                };
                ctx.Dipendentes.InsertOnSubmit(dipendente);
                ctx.SubmitChanges();
                GVEmployee.DataSource = ctx.Dipendentes.ToList();
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
                Preordine preordine = new Preordine
                {
                    Prodotto = ctx.Prodottos.Where(p => p.IdProdotto == long.Parse((string)CBPreProd.SelectedItem))
                    .FirstOrDefault(),
                    Cliente = ctx.Clientes.Where(c => c.CodFiscale == (string)CBPreCodCli.SelectedItem).FirstOrDefault(),
                    DataVendita = DatePreorder.Value,
                    DataUscitaProdotto = DatePreArrival.Value,
                    IdPreordine = ctx.Preordines.OrderByDescending(p => p.IdPreordine).Select(p => p.IdPreordine)
                    .FirstOrDefault() + 1
                };
                ctx.Preordines.InsertOnSubmit(preordine);
                ctx.SubmitChanges();
                GVPreorder.DataSource = ctx.Preordines.ToList();
            }
        }

        private void BtnPromAdd_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                Promozione promozione = new Promozione
                {
                    Descrizione = TxtPromDesc.Text,
                    Sconto = long.TryParse(TxtPromSconto.Text, out long sconto) ? sconto : -1
                };
                if (sconto > 0)
                {
                    promozione.DataInizio = DatePromStart.Value;
                    promozione.DataFine = DatePromEnd.Value;
                    promozione.IdPromozione = ctx.Promoziones.OrderByDescending(p => p.IdPromozione).Select(p => p.IdPromozione)
                        .FirstOrDefault() + 1;
                    ctx.Promoziones.InsertOnSubmit(promozione);
                    ctx.SubmitChanges();
                    GVPromozione.DataSource = ctx.Promoziones.ToList();
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
                Abbonamento abbonamento = new Abbonamento
                {
                    Cliente = ctx.Clientes.Where(c => c.CodFiscale == (string)CBSubCod.SelectedItem).FirstOrDefault(),
                    DataInizio = DateSubStart.Value,
                    ValiditÃ = DateSubEnd.Value,
                    IdAbbonamento = ctx.Abbonamentos.OrderByDescending(a => a.IdAbbonamento).Select(a => a.IdAbbonamento)
                    .FirstOrDefault() + 1
                };
                ctx.Abbonamentos.InsertOnSubmit(abbonamento);
                ctx.SubmitChanges();
                GVSubscription.DataSource = ctx.Abbonamentos.ToList();
            }
        }

        private void BtnProdAdd_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                Prodotto prodotto = new Prodotto
                {
                    Nome = TxtProdName.Text,
                    Prezzo = double.TryParse(TxtProdPrice.Text, out double prezzo) ? prezzo : -1
                };
                if (prezzo > 0)
                {
                    prodotto.IdProdotto = ctx.Prodottos.OrderByDescending(p => p.IdProdotto).Select(p => p.IdProdotto)
                        .FirstOrDefault() + 1;
                    ctx.Prodottos.InsertOnSubmit(prodotto);
                    ctx.SubmitChanges();
                    GVProduct.DataSource = ctx.Prodottos.ToList();
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
                Torneo torneo = new Torneo
                {
                    Filiale = ctx.Filiales.Where(f => f.IdFiliale == long.Parse((String)CBTourId.SelectedItem))
                    .FirstOrDefault(),
                    Gioco = TxtTourGame.Text,
                    Premio = TxtTourPrize.Text,
                    NPartecipanti = 0,
                    DataTorneo = DateTournament.Value
                };
                ctx.Torneos.InsertOnSubmit(torneo);
                ctx.SubmitChanges();
                GVTournament.DataSource = ctx.Torneos.ToList();
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
                GVTournament.DataSource = ctx.Torneos.ToList();
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
                    .Where(d => d.AcquistoInNegozio != null && 
                    d.AcquistoInNegozio.DataVendita.Month == DateBranchMost.Value.Month)
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

        private void BtnClientAdd_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                Cliente cliente = new Cliente
                {
                    CittÃ = TxtManCity.Text,
                    Via = TxtManCity.Text == "" ? null : TxtManCity.Text,
                    NCivico = TxtManCivic.Text == "" ? null : TxtManCivic.Text,
                    CodFiscale = TxtManCod.Text,
                    Nome = TxtManName.Text,
                    Cognome = TxtManSurname.Text,
                    DataNascita = DateManBirth.Value
                };
                ctx.Clientes.InsertOnSubmit(cliente);
                ctx.SubmitChanges();
                GVClient.DataSource = ctx.Clientes.ToList();
            }
        }

        private void BtnEmpShowMost_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                var startDate = DateEmpMost.Value.AddDays(-7);
                var endDate = DateEmpMost.Value;
                var nProd = ctx.Dettaglivenditas
                    .Where(d => d.AcquistoInNegozio != null &&
                    d.AcquistoInNegozio.DataVendita.CompareTo(startDate) >= 0 &&
                    d.AcquistoInNegozio.DataVendita.CompareTo(endDate) <= 0)
                    .Select(d => new
                    {
                        d.AcquistoInNegozio.Dipendente.CodFiscale,
                        d.AcquistoInNegozio.Dipendente.Nome,
                        d.AcquistoInNegozio.Dipendente.Cognome,
                        d.NProdotti
                    })
                    .GroupBy(d => d.CodFiscale)
                    .Select(d => new
                    {
                        CodFiscale = d.Key,
                        Nome = ctx.Dipendentes.Where(f => f.CodFiscale == d.Key).Select(f => f.Nome).Single(),
                        Cognome = ctx.Dipendentes.Where(f => f.CodFiscale == d.Key).Select(f => f.Cognome).Single(),
                        n = d.Sum(i => i.NProdotti)
                    });
                var max = nProd.Max(n => n.n);
                var finalEmp = nProd.Where(n => n.n == max);
                ShowResults(finalEmp);
            }
        }
    }
}
 