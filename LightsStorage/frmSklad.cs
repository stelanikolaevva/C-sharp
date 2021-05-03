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
    public partial class frmSklad : Form
    {
        public frmSklad()
        {
            InitializeComponent();
        }
        Form1 frm = new Form1();
        SqlConnection myConnection;
        SqlCommand myCommand = default(SqlCommand);
        SqlDataAdapter adapt;

        private void DisplayData()
        {
            myConnection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Storage", myConnection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(frm.cs);
                myCommand = new SqlCommand("Insert into Storage(StorageID,naimenovanie,adres" +
                                           "values(@StorageID,@naimenovanie,@adres", myConnection);
                myConnection.Open();
                myCommand.Parameters.AddWithValue("@StorageID", textBox1.Text);
                myCommand.Parameters.AddWithValue("@naimenovanie", textBox2.Text);
                myCommand.Parameters.AddWithValue("@adres", textBox3.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(frm.cs);
                myCommand = new SqlCommand("delete Storage where StorageID=@StorageID", myConnection);
                myConnection.Open();
                myCommand.Parameters.AddWithValue("@StorageID", textBox1.Text);
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Delete successfully!");
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(frm.cs);
                myCommand = new SqlCommand("update Storage SET naimenovanie=@naimenovanie, adres=@adres  where StorageID=@StorageID",
                myConnection);
                myConnection.Open();
                myCommand.Parameters.AddWithValue("@StorageID", textBox1.Text);
                myCommand.Parameters.AddWithValue("@naimenovanie", textBox2.Text);
                myCommand.Parameters.AddWithValue("@adres", textBox3.Text);
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Update successfully!");
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
        public static string storage;
        private void button4_Click_1(object sender, EventArgs e)
        {
            TelaSubform subform = new TelaSubform();
            storage = textBox1.Text;
            subform.Show();
        }
}
}
