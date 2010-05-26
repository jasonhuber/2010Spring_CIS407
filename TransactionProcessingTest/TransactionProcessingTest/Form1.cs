using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace TransactionProcessingTest
{
	public partial class Form1: Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGrid();

        }

        private void LoadGrid()
        {
            this.huber_BankCustomersTableAdapter.Fill(this.devrystudentsp10DataSet.Huber_BankCustomers);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection connection =
                new System.Data.SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TransactionProcessingTest.Properties.Settings.devrystudentsp10ConnectionString"].ConnectionString);
            connection.Open();
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand();
            command.Connection = connection;
            System.Data.SqlClient.SqlTransaction transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
            command.Transaction = transaction;
            string sql = "";
            bool isGood = true;
            for (int i = 0; i < int.Parse(txtTimes.Text); i++)
            {
                sql = "update huber_bankcustomers set balance = balance - @balance where customerid = @customerid";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@balance",int.Parse(txtAmount.Text));
                command.Parameters.AddWithValue("@customerid",txtCustomerId.Text);
                command.CommandText = sql;
                command.ExecuteNonQuery();

                sql = "select balance from huber_bankcustomers where customerid = @customerid";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@customerid", txtCustomerId.Text);
                command.CommandText = sql;
                if (int.Parse(command.ExecuteScalar().ToString()) < 0)
                {
                    transaction.Rollback();
                    isGood = false;
                    i = int.Parse(txtTimes.Text);
                    MessageBox.Show("Sorry that transaction was rolled back. The customer is not allowed to go below a 0 balance.");
                }
                    
            }
            if (isGood)
            {
                transaction.Commit();
            }
            LoadGrid();
            
        }

      
	}
}
