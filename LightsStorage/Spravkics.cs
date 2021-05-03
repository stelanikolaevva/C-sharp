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
    public partial class Spravkics : Form
    {
        public Spravkics()
        {
            InitializeComponent();
        }
        Form1 frm = new Form1();
        SqlConnection myConnection;
        SqlCommand myCommand = default(SqlCommand);
        SqlDataAdapter adapt;

        public void updatePrices(int percent)
        {
            try
            {
                double discount = (100 - percent) / 100;
                myConnection = new SqlConnection(frm.cs);
                myCommand = new SqlCommand("UPDATE Lights SET netoPrice = ROUND(netoPrice/1.05,2) WHERE kodGrupa = 'OT'", myConnection);
                myConnection.Open();
                myCommand.Parameters.AddWithValue("@percent", discount);
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Spravkics_Load(object sender, EventArgs e)
        {
            myConnection = new SqlConnection(frm.cs);
            myConnection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT  ime, netoPrice FROM Lights WHERE kodGrupa = '1'", myConnection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;


            double discount = (100 - 5) / 100;
            myCommand = new SqlCommand("UPDATE Lights SET netoPrice = ROUND(netoPrice/1.05,2) WHERE kodGrupa = '1'", myConnection);

            adapt = new SqlDataAdapter("SELECT  ime, netoPrice FROM Lights WHERE kodGrupa = '1'", myConnection);
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;

        }
    }
   
}
