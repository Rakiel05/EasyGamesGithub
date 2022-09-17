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

namespace Easy_Games_Assessment
{
    public partial class EasyGames : Form
    {
        public EasyGames()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=LAPTOP-R8CMIH4A\SQLSERVER;Initial Catalog=EasyGames;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            
            cnn.Close();

            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM Client", cnn);
            cnn.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while(sqlReader.Read())
            {
                comboBoxClientName.Items.Add(sqlReader["Name"].ToString());
            }

            sqlReader.Close();

            comboBoxFilter.Items.Add("Comment");
            comboBoxFilter.Items.Add("TransactionType");

            comboBoxTransactionType.Items.Add("Debit");
            comboBoxTransactionType.Items.Add("Credit");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void comboBoxClientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = @"Data Source=LAPTOP-R8CMIH4A\SQLSERVER;Initial Catalog=EasyGames;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT TransactionID,Amount,TransactionTypeID,ClientID,Comment FROM TransactionTable";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            
            
            sqlDataAdap.Fill(dtRecord);



            dtRecord.Columns.Add("TransactionType", typeof(String));
            foreach (DataRow dr in dtRecord.Rows)
            {
                if(comboBoxClientName.SelectedIndex != Int32.Parse(dr["ClientID"].ToString()))
                {
                    dtRecord.Rows.Remove(dr);

                }
                if (Int32.Parse(dr["TransactionTypeID"].ToString()) == 1)
                {
                    dr["TransactionType"] = "Debit";
                }
                else
                {
                    dr["TransactionType"] = "Credit";
                }
            }

            dtRecord.Columns.Remove("ClientID");

           

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtRecord;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = @"Data Source=LAPTOP-R8CMIH4A\SQLSERVER;Initial Catalog=EasyGames;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";

            sql = "INSERT INTO TransactionTable (Amount,TransactionTypeID,ClientID,Comment) values (@var1,@var2,@var3,@var4)";
            command = new SqlCommand(sql, cnn);
            command.Parameters.Add("@var1",txtAmount.Text);
            command.Parameters.Add("@var2", comboBoxTransactionType.SelectedIndex + 1);
            command.Parameters.Add("@var3", comboBoxClientName.SelectedIndex + 1);
            command.Parameters.Add("@var4",txtComment.Text);
            command.CommandText = sql;

            
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnEditComment_Click(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = @"Data Source=LAPTOP-R8CMIH4A\SQLSERVER;Initial Catalog=EasyGames;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((string)row.Cells["TransactionID"].Value == txtTransComment.Text)
                {
                    row.Cells["Comment"].Value = txtCommentEdit.Text;
                    sql = "UPDATE TransactionTable set Comment = @var2 where TransactionID = @var1";

                    command.Parameters.Add("@var1", txtTransComment.Text);
                    command.Parameters.Add("@var2", txtCommentEdit.Text);

                    adapter.UpdateCommand = new SqlCommand(sql, cnn);
                    adapter.UpdateCommand.ExecuteNonQuery();
                }

            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int option = comboBoxFilter.SelectedIndex;
            if (option == 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((string)row.Cells["Comment"].Value != txtFilterValue.Text)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((string)row.Cells["TransactionType"].Value != txtFilterValue.Text)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
        }

        private void btnOrderAmount_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["Amount"], ListSortDirection.Ascending);
        }

        private void btnOrderTransType_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["TransactionTypeID"], ListSortDirection.Ascending);
        }

        private void btnOrderComment_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["Comment"], ListSortDirection.Ascending);
        }
    }
}
