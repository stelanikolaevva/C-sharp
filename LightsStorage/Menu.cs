using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LightsStorage
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void вСкладToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSklad fSklad = new frmSklad();
            fSklad.Show();
        }

        private void вОсветителниТелаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTela fTela = new frmTela();
            fTela.Show();
        }

        private void безНамалениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spravkics frmSpravka = new Spravkics();
            frmSpravka.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
           
        }
    }
}
