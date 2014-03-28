using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class Db
    {
        private int ec = 0;
        //private int rec = 0;
        private String em = null;
        private static String strConnection = "Data Source=MANOJ\\SQLEXPRESS;Initial Catalog=Book;Integrated Security=True";
        private SqlConnection connection;
        public Db()
        {
            try
            {
                this.connection = new SqlConnection();
                this.connection.ConnectionString = Db.strConnection;
                this.connection.Open();
            }
            catch (Exception ex)
            {
                this.ec = 001;
                this.em = ex.Message;
            }
        }
        public void DbClose()
        {
            this.connection.Close();
        }
        public String SetTempConnectionString
        {
            set
            {
                Db.strConnection = value;
            }
        }
        public String SetPermanentConnectionString
        {
            set
            {
                Db.strConnection = value;
            }
        }
        public SqlConnection getConnection
        {
            get
            {
                return this.connection;
            }
        }
        public int ErrorCode
        {
            get
            {
                return this.ec;
            }
        }
        public String ErrorMessage
        {
            get
            {
                return this.em;
            }
        }
    }

    public class RunProcedure
    {
        private int ec = 0;
        private String em = null;
        private String rc = null;
        private SqlCommand command;
        public RunProcedure(SqlConnection conn, String commandText, SqlParameter[] para)
        {
            try
            {
                this.command = new SqlCommand();
                this.command.Connection = conn;
                this.command.CommandText = commandText;
                this.command.CommandType = CommandType.StoredProcedure;
                if (para != null)
                {
                    this.command.Parameters.AddRange(para);
                    this.command.ExecuteNonQuery();
                }
                else
                {
                    this.command.ExecuteNonQuery();
                }
                this.rc = this.command.Parameters["@result"].Direction.ToString();
            }
            catch (Exception ex)
            {
                this.ec = 002;
                this.em = ex.Message;
            }
        }
        public String RowCount
        {
            get
            {
                return this.rc;
            }
        }
        public int ErrorCode
        {
            get
            {
                return this.ec;
            }
        }
        public String ErrorMessage
        {
            get
            {
                return this.em;
            }
        }
    }

    public class SelectRunProcedure
    {
        private int ec = 0;
        private String em = null;
        private DataSet ds;
        private SqlDataAdapter adp;
        private SqlCommand command;
        public SelectRunProcedure(SqlConnection conn, String commandText, SqlParameter[] para)
        {
            try
            {
                this.command = new SqlCommand();
                this.command.Connection = conn;
                this.command.CommandText = commandText;
                this.command.CommandType = CommandType.StoredProcedure;
                if (para != null)
                {
                    this.command.Parameters.AddRange(para);
                    this.adp = new SqlDataAdapter(this.command);
                    this.ds = new DataSet();
                    this.adp.Fill(this.ds, "tbl");
                }
                else
                {
                    this.adp = new SqlDataAdapter(this.command);
                    this.ds = new DataSet();
                    this.adp.Fill(this.ds, "tbl");
                }
            }
            catch (Exception ex)
            {
                this.ec = 003;
                this.em = ex.Message;
            }
        }
        public DataSet GetResult
        {
            get
            {
                return this.ds;
            }
        }
        public int ErrorCode
        {
            get
            {
                return this.ec;
            }
        }
        public String ErrorMessage
        {
            get
            {
                return this.em;
            }
        }
    }

}
