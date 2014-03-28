using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Database;

namespace allBillPrint
{
    public class BillPRint
    {

        private int ec = 0; //For holding error code of SelectRunProcedure class.
        private String em = null; //For holding error message of SelectRunProcedure class.

        private int dec = 0; //For holding error code of Db class.
        private String dem = null; //For holding error message of Db class.

        public DataSet getAllRecord()
        {
            Db d = new Db();
            if (d.ErrorMessage == null)
            {
                SelectRunProcedure rp = new SelectRunProcedure(d.getConnection, "spSelectMoneyTransition", null);
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
