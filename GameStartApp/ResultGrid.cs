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
    public partial class ResultGrid : Form
    {
        private IQueryable<object> query;

        private ResultGrid()
        {
            InitializeComponent();
        }

        public ResultGrid(IQueryable<object> query) : this()
        {
            this.query = query;
            GVResult.DataSource = query;
        }
    }
}
