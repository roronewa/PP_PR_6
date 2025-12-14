namespace pr_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть число: ");
            string namber_str = Console.ReadLine();
            float number = Convert.ToInt32(namber_str);
            bool isnat = true;

            if (number <= 1)
            {
                isnat = false;
            }
            else if (number == 2)
            {
                isnat = true;
            }
            else if (number % 2 == 0)
            {
                isnat = false;
            }
            else
            {
                int limit = (int)Math.Sqrt(number);
                for (int i = 3; i * i <= number; i += 2)
                {
                    if (number % i == 0)
                    {
                        isnat = false;
                        break;
                    }
                }
            }

            if (isnat)
            {
                Console.WriteLine($"Число {number} є простим.");
            }
            else
            {
                Console.WriteLine($"Число {number} не є простим.");
            }
        }
    }
}