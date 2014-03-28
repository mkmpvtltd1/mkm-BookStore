using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Database;
using System.Data;
using System.Data.SqlClient;

namespace Authentication
{
    public class Login
    {
        private int ec = 0;
        private String em = null;
        private DataSet ds;

        public DataSet GetResult
        {
            get
            {
                return ds;
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
        public Login(String username, String Password)
        { 
            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter();
            para[0].ParameterName = "@Username";
            para[0].DbType = DbType.String;
            para[0].Value = username;

            para[1] = new SqlParameter();
            para[1].ParameterName = "@Password";
            para[1].DbType = DbType.String;
            para[1].Value = Password;

            Db conn = new Db();
            if (conn.ErrorMessage == null)
            {
                SelectRunProcedure run = new SelectRunProcedure(conn.getConnection, "spCheckLogin", para);
                if (run.ErrorMessage == null)
                {
                    this.ds = run.GetResult;
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
    }
}
