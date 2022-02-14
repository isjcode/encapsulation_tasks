namespace USER_TASK
{
    class Product
    {
        public string product_name;
        public int product_price;
        private int count;
        public int total_income;

        public Product (string a_name, int a_price, int a_count, int a_total_income)
        {
            product_name = a_name;
            product_price = a_price;
            count = a_count;
            total_income = a_total_income;
        }

        public void Sell()
        {
            if (count == 0)
            {
                Console.WriteLine("Product bitib.");
                return;
            }

            count--;
            total_income += product_price;
            Console.WriteLine("Satildi.");
        }
    }
}