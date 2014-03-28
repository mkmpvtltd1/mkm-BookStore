using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Database;
using EncryptMD5;

namespace Signup
{
    public class DoSignup
    {
        private int ec = 0;
        private String em = null;
        private String rc = null;

        public DoSignup(String name, String uname, String Pass, String Email, String accType, String Status)
        {
            SqlParameter[] para = new SqlParameter[6];

            para[0] = new SqlParameter();
            para[0].ParameterName = "@Name";
            para[0].DbType = DbType.String;
            para[0].Value = name;

            para[1] = new SqlParameter();
            para[1].ParameterName = "@Username";
            para[1].DbType = DbType.String;
            para[1].Value = uname;


            para[2] = new SqlParameter();
            para[2].ParameterName = "@Password";
            para[2].DbType = DbType.String;
            para[2].Value = Pass;

            para[3] = new SqlParameter();
            para[3].ParameterName = "@AccType";
            para[3].DbType = DbType.String;
            para[3].Value = accType;

            para[4] = new SqlParameter();
            para[4].ParameterName = "@Status";
            para[4].DbType = DbType.String;
            para[4].Value = Status;

            para[5] = new SqlParameter();
            para[5].ParameterName = "@result";
            para[5].DbType = DbType.Int64;
            para[5].Direction = ParameterDirection.Output;

            Db conn = new Db();
            if (conn.ErrorMessage == null)
            {
                RunProcedure run = new RunProcedure(conn.getConnection, "spInsertUser", para);
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
