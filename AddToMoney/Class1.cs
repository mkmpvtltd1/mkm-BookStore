using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Database;

namespace AddToMoney
{
    public class addToMoney
    {
        private int ec = 0;
        private String em = null;
        private String rc = null;

        public addToMoney(float Money,string transitionDate,string transitionTime)
        {
            SqlParameter[] para = new SqlParameter[4];

            para[0] = new SqlParameter();
            para[0].ParameterName = "@Money";
            para[0].DbType = DbType.Double;
            para[0].Value = Money;

            para[1] = new SqlParameter();
            para[1].ParameterName = "@TransitionDate";
            para[1].DbType = DbType.String;
            para[1].Value = transitionDate;


            para[2] = new SqlParameter();
            para[2].ParameterName = "@TransitionTime";
            para[2].DbType = DbType.String;
            para[2].Value = transitionTime;

            para[3] = new SqlParameter();
            para[3].ParameterName = "@result";
            para[3].DbType = DbType.Int64;
            para[3].Direction = ParameterDirection.Output;

            Db conn = new Db();
            if (conn.ErrorMessage == null)
            {
                RunProcedure run = new RunProcedure(conn.getConnection, "spInsertMoney", para);
                if (run.ErrorMessage == null)
                {
                    this.rc = run.RowCount;
                    conn.DbClose();
                }
                else
                {
                    this.em = run.ErrorMessage;
                    this.ec = run.ErrorCode;
                    conn.DbClose();
                }

            }
            else
            {
                this.em = conn.ErrorMessage;
                this.ec = conn.ErrorCode;
            }
        }

        public String GetResult
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
}
namespace AddToBook
{
    public class addToBook
    {
        private int ec = 0;
        private String em = null;
        private String rc = null;

        public addToBook(int Bid, int BCount,string transitionDate,string transitionTime )
        {
            SqlParameter[] para = new SqlParameter[5];

            para[0] = new SqlParameter();
            para[0].ParameterName = "@BID";
            para[0].DbType = DbType.Int32;
            para[0].Value = Bid;

            para[1] = new SqlParameter();
            para[1].ParameterName = "@BCOUNT";
            para[1].DbType = DbType.Int32;
            para[1].Value = BCount;

            para[2] = new SqlParameter();
            para[2].ParameterName = "@TRANSITIONDATE";
            para[2].DbType = DbType.String;
            para[2].Value = transitionDate;


            para[3] = new SqlParameter();
            para[3].ParameterName = "@TRANSITIONTIME";
            para[3].DbType = DbType.String;
            para[3].Value = transitionTime;

            para[4] = new SqlParameter();
            para[4].ParameterName = "@result";
            para[4].DbType = DbType.Int64;
            para[4].Direction = ParameterDirection.Output;

            Db conn = new Db();
            if (conn.ErrorMessage == null)
            {
                RunProcedure run = new RunProcedure(conn.getConnection, "spInsertBookTransition", para);
                if (run.ErrorMessage == null)
                {
                    this.rc = run.RowCount;
                    conn.DbClose();
                }
                else
                {
                    this.em = run.ErrorMessage;
                    this.ec = run.ErrorCode;
                    conn.DbClose();
                }

            }
            else
            {
                this.em = conn.ErrorMessage;
                this.ec = conn.ErrorCode;
            }
        }

        public String GetResult
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
}
