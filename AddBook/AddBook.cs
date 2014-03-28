using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Database;

namespace AddBook
{

    public class addBook
    {
        private int ec = 0;
        private String em = null;
        private String rc = null;

        public addBook(String Bname, String Publication, String Edition, String Author1, String Author2, String Price)
        {
            SqlParameter[] para = new SqlParameter[7];

            para[0] = new SqlParameter();
            para[0].ParameterName = "@BName";
            para[0].DbType = DbType.String;
            para[0].Value = Bname;

            para[1] = new SqlParameter();
            para[1].ParameterName = "@Publication";
            para[1].DbType = DbType.String;
            para[1].Value = Publication;


            para[2] = new SqlParameter();
            para[2].ParameterName = "@Edition";
            para[2].DbType = DbType.String;
            para[2].Value = Edition;

            para[3] = new SqlParameter();
            para[3].ParameterName = "@Author1";
            para[3].DbType = DbType.String;
            para[3].Value = Author1;

            para[4] = new SqlParameter();
            para[4].ParameterName = "@Author2";
            para[4].DbType = DbType.String;
            para[4].Value = Author2;

            para[5] = new SqlParameter();
            para[5].ParameterName = "@Price";
            para[5].DbType = DbType.Double;
            para[5].Value = Price;

            para[6] = new SqlParameter();
            para[6].ParameterName = "@result";
            para[6].DbType = DbType.Int64;
            para[6].Direction = ParameterDirection.Output;

            Db conn = new Db();
            if (conn.ErrorMessage == null)
            {
                RunProcedure run = new RunProcedure(conn.getConnection, "spInsertBook", para);
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
    public class GetRecords
    {
        private String rc = null;
        public DataSet getAllRecord()
        {
            Db d = new Db();
            SelectRunProcedure rp = new SelectRunProcedure(d.getConnection, "spSelectAllBook", null);
            return rp.GetResult;
        }

        public String GetResult
        {
            get
            {
                return this.rc;
            }
        }

    }
    public class AllBookTask
    {
        private int ec = 0;
        private String em = null;

        private int dec = 0;
        private String dem = null;
        public DataSet searchRecord(String id, String Bname, String Publication, String Edition, String Author1, String Author2, String Price)
        {
            Db d = new Db();
            if (d.ErrorMessage == null)
            {
                SqlParameter[] para = new SqlParameter[7];

                para[0] = new SqlParameter();
                para[0].ParameterName = "@Sid";
                para[0].DbType = DbType.String;
                para[0].Value = id;

                para[1] = new SqlParameter();
                para[1].ParameterName = "@SBook";
                para[1].DbType = DbType.String;
                para[1].Value = Bname;

                para[2] = new SqlParameter();
                para[2].ParameterName = "@SPublication";
                para[2].DbType = DbType.String;
                para[2].Value = Publication;

                para[3] = new SqlParameter();
                para[3].ParameterName = "@SEdition";
                para[3].DbType = DbType.String;
                para[3].Value = Edition;


                para[4] = new SqlParameter();
                para[4].ParameterName = "@SAuthor1";
                para[4].DbType = DbType.String;
                para[4].Value = Author1;

                para[5] = new SqlParameter();
                para[5].ParameterName = "@SAuthor2";
                para[5].DbType = DbType.String;
                para[5].Value = Author2;
                
                para[6] = new SqlParameter();
                para[6].ParameterName = "@SPrice";
                para[6].DbType = DbType.String;
                para[6].Value = Price;


                SelectRunProcedure rp = new SelectRunProcedure(d.getConnection, "spSearchBook", para);

                if (rp.ErrorMessage == null)
                {
                    return rp.GetResult;
                    // return rp.RowCount;
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
        public String updateBooks(String id, String Bname, String Publication, String Edition, String Author1, String Author2, String Price, int Stokes)
        {
            Db d = new Db();
            if (d.ErrorMessage == null)
            {
                SqlParameter[] para = new SqlParameter[9];

                para[0] = new SqlParameter();
                para[0].ParameterName = "@Id";
                para[0].DbType = DbType.Int16;
                para[0].Value = Int16.Parse(id);

                para[1] = new SqlParameter();
                para[1].ParameterName = "@BName";
                para[1].DbType = DbType.String;
                para[1].Value = Bname;

                para[2] = new SqlParameter();
                para[2].ParameterName = "@Publication";
                para[2].DbType = DbType.String;
                para[2].Value = Publication;

                para[3] = new SqlParameter();
                para[3].ParameterName = "@Edition";
                para[3].DbType = DbType.String;
                para[3].Value = Edition;

                para[4] = new SqlParameter();
                para[4].ParameterName = "@Author1";
                para[4].DbType = DbType.String;
                para[4].Value = Author1;

                para[5] = new SqlParameter();
                para[5].ParameterName = "@Author2";
                para[5].DbType = DbType.String;
                para[5].Value = Author2;

                para[6] = new SqlParameter();
                para[6].ParameterName = "@Price";
                para[6].DbType = DbType.Double;
                para[6].Value = Double.Parse(Price);

                para[7] = new SqlParameter();
                para[7].ParameterName = "@Stoke";
                para[7].DbType = DbType.Int16;
                para[7].Value = Stokes;

                para[8] = new SqlParameter();
                para[8].ParameterName = "@result";
                para[8].DbType = DbType.Int32;
                para[8].Direction = ParameterDirection.Output;

                RunProcedure rp = new RunProcedure(d.getConnection, "spUpdateBook", para);
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
                para[0].ParameterName = "@Bid";
                para[0].DbType = DbType.Int16;
                para[0].Value = Int16.Parse(Bid);

                para[1] = new SqlParameter();
                para[1].ParameterName = "@result";
                para[1].DbType = DbType.Int64;
                para[1].Direction = ParameterDirection.Output;

                RunProcedure rp = new RunProcedure(d.getConnection, "spDeleteBook", para);

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
                SelectRunProcedure rp = new SelectRunProcedure(d.getConnection, "spSelectAllBook", null);
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
