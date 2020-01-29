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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connection_string;
                SqlConnection connect;
                connection_string = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=New_Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                connect = new SqlConnection(connection_string);
                connect.Open();
                SqlCommand cmd;
                string sql = "select *from mytable";
                cmd = new SqlCommand(sql);
                cmd.Connection = connect;

                SqlDataReader dataReader;

                dataReader = cmd.ExecuteReader();
                string op = "";
                while (dataReader.Read())
                {
                    op += dataReader.GetValue(0)+" "+ dataReader.GetValue(1) + " "+dataReader.GetValue(2) + "\n";
                }
                MessageBox.Show(op);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error : "+ee);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
          //  SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            string id = textBox1.ToString();
            string name = textBox2.ToString();
            sql = "Insert into mytable values(" + id +","+name+")";
       //     command = new SqlCommand(sql, connect);
         //   adapter.InsertCommand = new SqlCommand(sql, connect);
           // adapter.InsertCommand.ExecuteNonQuery();

            //command.Dispose(): 
		    //connect.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'new_DatabaseDataSet3.mytable' table. You can move, or remove it, as needed.
            this.mytableTableAdapter1.Fill(this.new_DatabaseDataSet3.mytable);
            // TODO: This line of code loads data into the 'new_DatabaseDataSet.mytable' table. You can move, or remove it, as needed.
            this.mytableTableAdapter.Fill(this.new_DatabaseDataSet.mytable);

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
    }
}
