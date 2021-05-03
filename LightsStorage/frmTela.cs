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
    public partial class frmTela : Form
    {
        public frmTela()
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
            adapt = new SqlDataAdapter("select * from Lights", myConnection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(frm.cs);
                myCommand = new SqlCommand("insert into Lights(LightsID,bodyNumber,ime,available,minimal,netoPrice," +
                    "DDS,mqrka,kodGrupa,kodSklad) " +
                    "values(@LightsID,@bodyNumber,@ime,@available,@minimal,@netoPrice,@DDS,@mqrka," +
                    "@kodGrupa,@kodSklad)", myConnection);
                myConnection.Open();
                myCommand.Parameters.AddWithValue("@LightsID", textBox1.Text);
                myCommand.Parameters.AddWithValue("@bodyNumber", textBox2.Text);
                myCommand.Parameters.AddWithValue("@ime", textBox3.Text);
                myCommand.Parameters.AddWithValue("@available", textBox4.Text);
                myCommand.Parameters.AddWithValue("@minimal", textBox5.Text);
                myCommand.Parameters.AddWithValue("@netoPrice", textBox6.Text);
                myCommand.Parameters.AddWithValue("@DDS", textBox7.Text);
                myCommand.Parameters.AddWithValue("@kodGrupa", textBox8.Text);
                myCommand.Parameters.AddWithValue("@mqrka", textBox9.Text);
                myCommand.Parameters.AddWithValue("@kodSklad", textBox10.Text);

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

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(frm.cs);
                myCommand = new SqlCommand("delete Lights where LightsID=@LightsID", myConnection);
                myConnection.Open();
                myCommand.Parameters.AddWithValue("@LightsID", textBox1.Text);
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(frm.cs);
                myCommand = new SqlCommand("update Lights SET bodyNumber=@bodyNumber, ime=@ime, available=@available,minimal=@minimal," +
                    "netoPrice=@netoPrice," + "DDS=@DDS,mqrka=@mqrka,kodSklad=@kodSklad, kodGrupa=@kodGrupa where LightsID=@LightsID", myConnection);
                myConnection.Open();
                myCommand.Parameters.AddWithValue("@LightsID", textBox1.Text);
                myCommand.Parameters.AddWithValue("@bodyNumber", textBox2.Text);
                myCommand.Parameters.AddWithValue("@ime", textBox3.Text);
                myCommand.Parameters.AddWithValue("@available", textBox4.Text);
                myCommand.Parameters.AddWithValue("@minimal", textBox5.Text);
                myCommand.Parameters.AddWithValue("@netoPrice", textBox6.Text);
                myCommand.Parameters.AddWithValue("@DDS", textBox7.Text);
                myCommand.Parameters.AddWithValue("@kodGrupa", textBox8.Text);
                myCommand.Parameters.AddWithValue("@mqrka", textBox9.Text);
                myCommand.Parameters.AddWithValue("@kodSklad", textBox10.Text);

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

        private void button4_Click(object sender, EventArgs e)
        {
            myConnection = new SqlConnection(frm.cs);
            myConnection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Lights", myConnection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }
    }
}
