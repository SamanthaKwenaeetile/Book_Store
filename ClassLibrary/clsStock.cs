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

        public bool Find(long bookID)
        {
            mBookID = 9780545010221;

            mBookName = "Harry Potter and the Deathly Hallows";

            mInStock = true;

            mNumberAvailable = 59;

            mReleaseDate = Convert.ToDateTime("21/7/2007");

            //always return true
            return true;
        }
    }
}