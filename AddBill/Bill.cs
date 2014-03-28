using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Database;

namespace AddBill
{

    public class AddBill
    {
        private int ec = 0;
        private String em = null;
        private String rc = null;
         
        public AddBill(int sn, int Bid, string  Item, float  Price, int Amount, float  Total, float Discount, float GrandTotal)
        {
            SqlParameter[] para = new SqlParameter[9];

            para[0] = new SqlParameter();
            para[0].ParameterName = "@sn";
            para[0].DbType = DbType.Int16;
            para[0].Value = sn;

            para[1] = new SqlParameter();
            para[1].ParameterName = "@Bid";
            para[1].DbType = DbType.Int16;
            para[1].Value = Bid;


            para[2] = new SqlParameter();
            para[2].ParameterName = "@Item";
            para[2].DbType = DbType.String;
            para[2].Value = Item;

            para[3] = new SqlParameter();
            para[3].ParameterName = "@Price";
            para[3].DbType = DbType.Double;
            para[3].Value = Price;

            para[4] = new SqlParameter();
            para[4].ParameterName = "@Amount";
            para[4].DbType = DbType.Int16;
            para[4].Value = Amount;

            para[5] = new SqlParameter();
            para[5].ParameterName = "@Total";
            para[5].DbType = DbType.Double;
            para[5].Value = Total;

            para[6] = new SqlParameter();
            para[6].ParameterName = "@Discount";
            para[6].DbType = DbType.Double;
            para[6].Value = Discount;

            para[7] = new SqlParameter();
            para[7].ParameterName = "@GrandTotal";
            para[7].DbType = DbType.Double;
            para[7].Value = GrandTotal;

            para[8] = new SqlParameter();
            para[8].ParameterName = "@result";
            para[8].DbType = DbType.Int64;
            para[8].Direction = ParameterDirection.Output;

            Db conn = new Db();
            if (conn.ErrorMessage == null)
            {
                RunProcedure run = new RunProcedure(conn.getConnection, "spInsertToBill", para);
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

    public class GetBillRecords
    {
        private int ec = 0;
        private String em = null;

        private int dec = 0;
        private String dem = null;
        private String rc = null;
        public DataSet getAllBillRecord()
        {
            Db d = new Db();
            SelectRunProcedure rp = new SelectRunProcedure(d.getConnection, "spSelectAllBill", null);
            return rp.GetResult;
        }
        public DataSet DeleteBillRecords()
        {
            Db d = new Db();
            if (d.ErrorMessage == null)
            {
                SelectRunProcedure rp = new SelectRunProcedure(d.getConnection, "spDeleteAllBill", null);
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

        public String GetResult
        {
            get
            {
                return this.rc;
            }
        }

    }
   
  
}
