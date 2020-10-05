namespace _05_2_4
{
    internal class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;

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