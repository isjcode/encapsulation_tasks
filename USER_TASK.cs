using System;

namespace USER_TASK
{
    class Task
    {
        static void Main(string[] args)
        {
            User user = new User("Afaasfasfasf", "214214");
        }

    }

    class User
    {
        private string user_name;
        private string password;

        public User(string a_username, string a_password)
        {
            Password = a_password;
            Username = a_username;
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                Console.WriteLine("Password: ");
                string Password = Console.ReadLine();
                while (!check_password(Password))
                {
                    Console.WriteLine("Sehv password.");
                    Password = Console.ReadLine();
                }

            }
        }
        private string Username
        {
            get
            {
                return user_name;
            }
            set
            {
                Console.WriteLine("Username: ");
                string Username = Console.ReadLine();

                while (Username.Length < 8)
                {
                    Console.WriteLine("Qisa.");
                    Username = Console.ReadLine();
                }
            }
        }


        static bool check_password(string s)
        {
            bool upper_flag = false;
            bool lower_flag = false;
            bool digit_flag = false;

            foreach (char c in s)
            {
                if (char.IsUpper(c))
                {
                    upper_flag = true;
                }
                else if (char.IsLower(c))
                {
                    lower_flag = true;
                }
                else if (char.IsDigit(c))
                {
                    digit_flag = true;
                }
            }

            if (upper_flag && lower_flag && digit_flag)
            {
                return true;
            }

            return false;
        }

    }
}