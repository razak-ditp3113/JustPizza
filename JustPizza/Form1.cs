using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustPizza
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void circlePizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCirclePizza frmCirclePizza = new FormCirclePizza();
            frmCirclePizza.MdiParent = this;
            frmCirclePizza.Dock = DockStyle.Fill;
            frmCirclePizza.Show();
        }

        private void squarePizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSquarePizza frmSquarePizza = new FormSquarePizza
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            frmSquarePizza.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void hexagonPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHexagonPizza frmHexagonPizza = new FormHexagonPizza
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            frmHexagonPizza.Show();
        }
    }
}
