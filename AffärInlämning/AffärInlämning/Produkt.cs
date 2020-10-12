using System;
using System.Collections.Generic;
using System.Text;

namespace AffärInlämning
{
    class Produkt
    {
        private string _productName;
        public string Name
        {
            get { return _productName; }
            set { _productName = value; }
        }
       
        private int _price;
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

    }
}
