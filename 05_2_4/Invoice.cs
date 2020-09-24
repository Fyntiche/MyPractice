using System;
using System.Collections.Generic;
using System.Text;

namespace _05_2_4
{
    class Invoice
    {
        readonly int account;
        readonly string customer;
        readonly string provider;

        private string article;
        private int quantity;

        public Invoice(int account, string customer = null, string provider = null)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }




    }
}
