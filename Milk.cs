namespace USER_TASK
{
    class Milk : Product
    {
        public int Volume;
        public int FatRate;

        public Milk(string a_name, int a_price, int a_count, int a_total_income, int volume, int fat_rate) : base(a_name, a_price, a_count, a_total_income)
        {
            Volume = volume;   
            FatRate = fat_rate;
        }
    }
}