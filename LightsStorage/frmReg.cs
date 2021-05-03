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
    public partial class frmReg : Form
    {
        public frmReg()
        {
            InitializeComponent();
        }
        Form1 frm = new Form1();
        SqlConnection myConnection;
        SqlCommand myCommand;
        SqlDataAdapter adapt;
        private void DisplayData()
        {
            myConnection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select username from Registration where username='" + textBox1.Text + "'", myConnection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(frm.cs);
                myCommand = new SqlCommand("Insert into Registration values('" + textBox1.Text + "','" + textBox2.Text + "')", myConnection);
                myConnection.Open();
                myCommand.Parameters.AddWithValue("@username", textBox1.Text);
                myCommand.Parameters.AddWithValue("@password", textBox2.Text);
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Insert successfully!");
                DisplayData();
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
