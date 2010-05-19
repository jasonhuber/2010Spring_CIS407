using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class db
    {
        private string _connectionstring;
        private System.Data.SqlClient.SqlCommand _command = new System.Data.SqlClient.SqlCommand();
        private System.Data.SqlClient.SqlConnection _connection = new System.Data.SqlClient.SqlConnection();
            //videos are at tr.im/cis407
            //we are using sql server
        public string connectionstring
            { 
            get
            {
                return _connectionstring;
            }
            set
                 { _connectionstring = value;}
            }

        //insert update and delete will use this method
        public void Execute(string SQL)
        {
            if (_connection.State != System.Data.ConnectionState.Open)
	            {
		            OpenConnection(connectionstring);
	            }
            _command.Connection = _connection;
            _command.CommandText = SQL;
            _command.ExecuteNonQuery();
        }

       public void Execute(string SQL, string ConnectionString)
        {
          this.connectionstring = ConnectionString;
           Execute(SQL);
        }

    public void OpenConnection(string connectionstring)
    {
 	    _connection.ConnectionString = _connectionstring;
        _connection.Open();

    }


        //this takes a SQL select and returns a reader
        public System.Data.SqlClient.SqlDataReader GetData(string SQL)
        {
               if (_connection.State != System.Data.ConnectionState.Open)
	            {
		            OpenConnection(connectionstring);
	            }
            _command.Connection = _connection;
            _command.CommandText = SQL;
            return _command.ExecuteReader();
        }
        //this takes a SQL select and returns a dataset
        public System.Data.DataSet GetDataSet(string SQL)
        {
            if (_connection.State != System.Data.ConnectionState.Open)
	            {
		            OpenConnection(connectionstring);
	            }
            System.Data.SqlClient.SqlDataAdapter da = new  System.Data.SqlClient.SqlDataAdapter ();
            System.Data.DataSet ds = new System.Data.DataSet();
            _command.Connection = _connection;
            _command.CommandText = SQL;
            da.SelectCommand = _command;
            da.Fill(ds);
            return ds;

        }
        //allows me to add parameters onto my parameterized queries
        public void addparam(string paramname, string paramvalue)
        {
            _command.Parameters.AddWithValue(paramname, paramvalue);            
        }

    }
}
