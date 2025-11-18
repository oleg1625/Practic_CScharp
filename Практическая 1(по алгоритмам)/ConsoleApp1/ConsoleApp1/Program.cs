using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1. Линейные алгоритмы

            // Площадь прямоугольника
            double length = 10;
            double width = 5;
            double area = length * width;
            Console.WriteLine($"Площадь прямоугольника: {area}");

            // Цельсий в Фаренгейты
            double celsius = 25;
            double fahrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine($"Температура в Фаренгейтах: {fahrenheit}");

            // Стоимость покупки
            double price = 150.50;
            int quantity = 3;
            double totalCost = price * quantity;
            Console.WriteLine($"Общая стоимость: {totalCost}");

            // Задание 2. Простые алгоритмы ветвления

            // Проверка чётности
            int number1 = 7;
            if (number1 % 2 == 0)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число нечётное");
            }

            // Определение знака числа
            int number2 = -5;
            if (number2 > 0)
            {
                Console.WriteLine("Число положительное");
            }
            else if (number2 < 0)
            {
                Console.WriteLine("Число отрицательное");
            }
            else
            {
                Console.WriteLine("Число равно нулю");
            }

            // Проверка совершеннолетия
            int age = 20;
            if (age >= 18)
            {
                Console.WriteLine("Совершеннолетний");
            }
            else
            {
                Console.WriteLine("Несовершеннолетний");
            }

            // Задание 3. Сложные алгоритмы ветвления

            // Решение квадратного уравнения
            double a = 1, b = -3, c = 2;
            double discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Два корня: x1 = {x1}, x2 = {x2}");
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Один корень: x = {x}");
            }
            else
            {
                Console.WriteLine("Действительных корней нет");
            }

            // Определение времени года
            int month = 7;
            string season;
            switch (month)
            {
                case 12: case 1: case 2: season = "Зима"; break;
                case 3: case 4: case 5: season = "Весна"; break;
                case 6: case 7: case 8: season = "Лето"; break;
                case 9: case 10: case 11: season = "Осень"; break;
                default: season = "Неверный номер месяца"; break;
            }
            Console.WriteLine($"Время года: {season}");

            // Калькулятор
            double num1 = 10, num2 = 5;
            char operation = '+';
            double result = 0;
            switch (operation)
            {
                case '+': result = num1 + num2; break;
                case '-': result = num1 - num2; break;
                case '*': result = num1 * num2; break;
                case '/': result = num2 != 0 ? num1 / num2 : double.NaN; break;
                default: Console.WriteLine("Неизвестная операция"); break;
            }
            Console.WriteLine($"Результат: {result}");

            // Задание 4. Комбинированные алгоритмы

            // Заработная плата с премией и налогами
            double salary = 50000;
            int experience = 3;
            double bonus = experience > 5 ? salary * 0.2 : salary * 0.1;
            double tax = (salary + bonus) * 0.13;
            double netSalary = salary + bonus - tax;
            Console.WriteLine($"Чистая зарплата: {netSalary}");

            // Тип треугольника
            double side1 = 3, side2 = 4, side3 = 5;
            string triangleType;
            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                if (side1 == side2 && side2 == side3)
                    triangleType = "Равносторонний";
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                    triangleType = "Равнобедренный";
                else if (side1 * side1 + side2 * side2 == side3 * side3 ||
                         side1 * side1 + side3 * side3 == side2 * side2 ||
                         side2 * side2 + side3 * side3 == side1 * side1)
                    triangleType = "Прямоугольный";
                else
                    triangleType = "Разносторонний";
            }
            else
            {
                triangleType = "Не треугольник";
            }
            Console.WriteLine($"Тип треугольника: {triangleType}");

            // Проверка сложности пароля
            string password = "MyPass123";
            int strength = 0;
            if (password.Length >= 8) strength++;
            if (password.Any(char.IsUpper)) strength++;
            if (password.Any(char.IsLower)) strength++;
            if (password.Any(char.IsDigit)) strength++;
            if (password.Any(ch => !char.IsLetterOrDigit(ch))) strength++;

            switch (strength) 
            {
                case 5:
                    Console.WriteLine("Очень сильный");
                    break;
                case 4:
                    Console.WriteLine("Сильный");
                    break;
                case 3:
                    Console.WriteLine("Средний");
                    break;
                case 2:
                    Console.WriteLine("Слабый");
                    break;
                default:
                    Console.WriteLine("Очень слабый");
                    break;
            }
        }
    }
}
