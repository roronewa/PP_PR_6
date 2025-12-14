namespace pr_6_2
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Console.Write("Введіть довжину: ");
            string namber_str = Console.ReadLine();

            Console.Write("Введіть який пароль бажаєте 1 - літери 2 - літери і цифри 3 - всі символи: ");
            string wer = Console.ReadLine();
            int length = Convert.ToInt32(namber_str);

            string pool = "";

            if (wer == "1")
            {
                pool = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }

            else if (wer == "2")
            {
                pool = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            }

            else 
            {
                pool = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*";
            }

            Random random = new Random();

            string password = "";

            for (int i = 0; i < length; i++ )
            {
                int index = random.Next(pool.Length);

                char randomChar = pool[index];

                password += randomChar;
            }

            Console.WriteLine($"Згенерований пароль довжиною {length}: {password}");
        }
    }
}
