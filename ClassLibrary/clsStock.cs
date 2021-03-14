using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //BookID private member variable
        private long mBookID;
        //BookID public property
        public long BookID {
            get
            {
                return mBookID;
            }

            set
            {
                mBookID = value;
            }       
         }

        //BookName private member variable
        private string mBookName;
        //BookName public property
        public string BookName {
            get
            {
                return mBookName;
            }

            set
            {
                mBookName = value;
            }
        }

        //InStock private member variable
        private Boolean mInStock;
        //InStock public property
        public bool InStock {
            get
            {
                return mInStock;
            }

            set
            {
                mInStock = value;
            }
        }

        //NumberAvailable private member variable
        private int mNumberAvailable;
        //NumberAvailable public property
        public int NumberAvailable {
            get
            {
                return mNumberAvailable;
            }

            set
            {
                mNumberAvailable = value;
            }
        }

        //ReleaseDate private member variable
        private DateTime mReleaseDate;
        //ReleaseDate public property
        public DateTime ReleaseDate {
            get
            {
                return mReleaseDate;
            }
            set
            {
                mReleaseDate = value;
            }
        }

        public bool Find(long BookID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@BookID", BookID);
            DB.Execute("sproc_tblStock_FilterByBookID");
            if(DB.Count == 1)
            {
                mBookID = Convert.ToInt32(DB.DataTable.Rows[0]["BookID"]);
                mBookName = Convert.ToString(DB.DataTable.Rows[0]["BookName"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                mNumberAvailable = Convert.ToInt32(DB.DataTable.Rows[0]["NumberAvailable"]);
                mReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ReleaseDate"]);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}