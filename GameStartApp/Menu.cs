using GamestartLogicContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // TODO: This line of code loads data into the 'gamestart_logicDataSet.acquisto_online' table. You can move, or remove it, as needed.
            this.acquisto_onlineTableAdapter.Fill(this.gamestart_logicDataSet.acquisto_online);
            BtnSaleDispStore.Enabled = false;
            _online = false;
            // TODO: This line of code loads data into the 'gamestart_logicDataSet.acquisto_in_negozio' table. You can move, or remove it, as needed.
            this.acquisto_in_negozioTableAdapter.Fill(this.gamestart_logicDataSet.acquisto_in_negozio);
            // TODO: This line of code loads data into the 'gamestart_logicDataSet.prodotto' table. You can move, or remove it, as needed.
            this.prodottoTableAdapter.Fill(this.gamestart_logicDataSet.prodotto);
            // TODO: This line of code loads data into the 'gamestart_logicDataSet.dipendente' table. You can move, or remove it, as needed.
            this.dipendenteTableAdapter.Fill(this.gamestart_logicDataSet.dipendente);
            // TODO: This line of code loads data into the 'gamestart_logicDataSet.filiale' table. You can move, or remove it, as needed.
            this.filialeTableAdapter.Fill(this.gamestart_logicDataSet.filiale);
            // TODO: This line of code loads data into the 'gamestart_logicDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.gamestart_logicDataSet.cliente);
        }

        private void CBBranchesManager_Click(object sender, EventArgs e)
        {
            using (GamestartLogicDataContext ctx = new GamestartLogicDataContext())
            {
                CBBranchesManager.Items.Clear();
                CBBranchesManager.Items.AddRange(ctx.Gestores.Select(q => q.CodFiscale).ToArray());
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
                var form = new AddSaleStore();
                form.Height = 400;
                form.Width = 350;
                form.ShowDialog();
                form.FormClosed += (s, ea) => RefreshGrid(GVSaleStore);
            } else
            {

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
    }
}
