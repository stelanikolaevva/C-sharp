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
    public partial class TelaSubform : Form
    {
        public TelaSubform()
        {
            InitializeComponent();
        }
        Form1 frm = new Form1();
        SqlConnection myConnection;
        SqlDataAdapter adapt;
        public static string storage;
        private void TelaSubform_Load(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(frm.cs);
                myConnection.Open();
                DataTable dt = new DataTable();
                storage = frmSklad.storage;
                adapt = new SqlDataAdapter("select * from Storage where @StorageID LIKE storage", myConnection);
                adapt.Fill(dt);
                dataGrid.DataSource = dt;
                myConnection.Close();
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
