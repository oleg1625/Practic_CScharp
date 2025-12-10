using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            const string AL = "admin";
            const string AP = "qwerty123";
            var login = Console.ReadLine();
            var password = Console.ReadLine();

            if (AL == login && AP == password)
            {
                Console.WriteLine("Access is allowed");
            }
            else
            {
                Console.WriteLine("Access denied");
            }

            //3
            var nums = Console.ReadLine().Split(' ').Select(x => int.Parse(x.Trim())).ToList();

            foreach (var x in nums)
            {
                if (Convert.ToInt32(x) % 2 == 0)
                {
                    Console.Write(x + " ");
                }
            }

            Console.WriteLine();
            //4
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            string[] words = { "", "One", "Two", "Three", "Four", "Five" };

            foreach (string numStr in numbers)
            {
                // Пропускаем пустые строки
                if (numStr == "")
                    continue;

                int num = int.Parse(numStr);
                Console.Write(words[num] + " ");
            }

            Console.WriteLine();

            //5
            string[] parts = Console.ReadLine().Split(' ');

            int sum = 0;
            int product = 1;

            for (int i = 0; i < parts.Length; i++)
            {
                sum += int.Parse(parts[i]);
                product *= int.Parse(parts[i]);
            }

            Console.WriteLine(sum + " " + product);
        }
           
        


        //2
        public static void Proverka(int temp, int vib)
        {
            if (temp >= 70 && vib >= 11)
            {
                Console.WriteLine("Авврийное состояние");
            }
            else if (temp >= 70 && vib < 11)
            {
                Console.WriteLine("Повышенная темп");
            }
            else if (temp < 70 && vib >= 11)
            {
                Console.WriteLine("Повышенная вибрация");
            }
            else if (temp < 70 && vib < 11)
            {
                Console.WriteLine("Всё норм");
            }

        }
    }
}
