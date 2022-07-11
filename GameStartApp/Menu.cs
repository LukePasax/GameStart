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
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
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

    }
}
