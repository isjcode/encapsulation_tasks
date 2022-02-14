namespace USER_TASK
{
    class Task
    {
        static void Main(string[] args)
        {
            Book[] arr = { };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Page Count: ");
                int page_count;
                int.TryParse(Console.ReadLine(), out page_count);
                Array.Resize(ref arr, arr.Length + 1);
                arr[i] = new Book(name, page_count);

            }
        

        }

    }
    class Book
    {
        private string name;
        private int page_count;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length < 3)
                {

                    Console.WriteLine("Qisa ad");
                    return;

                }
                else
                {
                    name = value;
                }

            }
        }

        public int PageCount
        {
            get
            {
                return page_count;
            }
            set
            {
                if (value < 10)
                {
                    Console.WriteLine("10 dan kicik ola bilmez.");
                    return;
                }
                else
                {
                    page_count = value;
                }
            }
        }

        public Book(string a_name, int a_page_count)
        {
            Name = a_name;
            PageCount = a_page_count;
        }
    }
}
