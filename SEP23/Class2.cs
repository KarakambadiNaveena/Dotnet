using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondlibrary
{
    public class Class1
    {
        private int _productid;
        public int ProductId
        {
            get
            {
                return _productid;
            }
            set
            {

                if (value > 77)
                {
                    throw new Exception("product id not valid");

                }
                else
                {
                    _productid = value;
                }
            }
        }
        private string _productname;

        public string ProductName
        {
            get { return _productname; }
            set
            {
                if ((value.Length > 40) || string.IsNullOrEmpty(value))
                {
                    throw new Exception("Not valid name.... Please check");
                }
                else
                {
                    _productname = value;
                }

            }
        }
       
    }
}
