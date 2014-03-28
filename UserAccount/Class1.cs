using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Database;
using EncryptMD5;
using System.Data.SqlClient;

namespace UserAccount
{
    public class AllUserTask
    {
        private int ec = 0;
        private String em = null;

        private int dec = 0;
        private String dem = null;
        public String updateRecords(String uid,String name,string pass, string type,string status)
        {
            Db d = new Db();
            if (d.ErrorMessage == null)
            {
                SqlParameter[] para = new SqlParameter[6];

                para[0] = new SqlParameter();
                para[0].ParameterName = "@Uid";
                para[0].DbType = DbType.Int16;
                para[0].Value = Int16.Parse(uid);

                para[1] = new SqlParameter();
                para[1].ParameterName = "@Name";
                para[1].DbType = DbType.String;
                para[1].Value = name;

                para[2] = new SqlParameter();
                para[2].ParameterName = "@Type";
                para[2].DbType = DbType.String;
                para[2].Value = type;

                para[3] = new SqlParameter();
                para[3].ParameterName = "@Pass";
                para[3].DbType = DbType.String;
                para[3].Value = pass;

                para[4] = new SqlParameter();
                para[4].ParameterName = "@Status";
                para[4].DbType = DbType.String;
                para[4].Value = status;

                para[5] = new SqlParameter();
                para[5].ParameterName = "@result";
                para[5].DbType = DbType.Int32;
                para[5].Direction = ParameterDirection.Output;

                RunProcedure rp = new RunProcedure(d.getConnection, "spUpdateUserAccount", para);
                if (rp.ErrorMessage == null)
                {
                    return rp.RowCount;
                }
                else
                {
                    this.ec = rp.ErrorCode;
                    this.em = rp.ErrorMessage;
                    return null;
                }

            }
            else
            {
                this.dec = d.ErrorCode;
                this.dem = d.ErrorMessage;
                return null;
            }
        }

        public String deleteRecord(String Bid)
        {
            
            Db d = new Db();
            if (d.ErrorMessage == null)
            {
                SqlParameter[] para = new SqlParameter[2];

                para[0] = new SqlParameter();
                para[0].ParameterName = "@Uid";
                para[0].DbType = DbType.Int16;
                para[0].Value = Int16.Parse(Bid);

                para[1] = new SqlParameter();
                para[1].ParameterName = "@result";
                para[1].DbType = DbType.Int64;
                para[1].Direction = ParameterDirection.Output;

                RunProcedure rp = new RunProcedure(d.getConnection, "spDeleteUser", para);

                if (rp.ErrorMessage == null)
                {
                    return rp.RowCount;
                }
                else
                {
                    this.ec = rp.ErrorCode;
                    this.em = rp.ErrorMessage;
                    return null;
                }
            }
            else
            {
                this.dec = d.ErrorCode;
                this.dem = d.ErrorMessage;
                return null;
            }
        }

        public DataSet GetAllRecord()
        {
            Db d = new Db();
            if (d.ErrorMessage == null)
            {
                SelectRunProcedure rp = new SelectRunProcedure(d.getConnection, "spSelectUser", null);
                if (rp.ErrorMessage == null)
                {
                    return rp.GetResult;
                }
                else
                {
                    this.ec = rp.ErrorCode;
                    this.em = rp.ErrorMessage;
                    return null;
                }
            }

            else
            {
                this.dec = d.ErrorCode;
                this.dem = d.ErrorMessage;
                return null;
            }
        }

        public String getDbErrorMessage
        {
            get
            {
                return this.dem;
            }
        }
        public String getQueryErrorMessage
        {
            get
            {
                return this.em;
            }
        }

        public int getDbErrorCode
        {
            get { return this.dec; }
        }
        public int getQueryErrorCode
        {
            get { return this.ec; }
        }
    }
}
