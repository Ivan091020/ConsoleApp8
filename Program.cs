using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Zadacha1
            Random rnd = new Random();
            int number = rnd.Next(10, 99);
            Console.WriteLine($"number = {number}");
            string stroka = (number % 2 == 0) ? "четное число" : "нечетное число";
            Console.WriteLine($"{stroka}");
            ///Задача 2.
            Random random = new Random();
            int randomNumber = random.Next(1, 8);
            string dayOfWeek = GetDayOfWeekName(randomNumber);
            Console.WriteLine($"Случайное число: {randomNumber}, день недели: {dayOfWeek}");
        }

        /// 6


        static string GetDayOfWeekName(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Понедельник";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                case 7: return "Воскресенье";
                default:
                    return "Неверное число";
                    ///zadaca3
                    int a = 4;
                    int b = 6;
                    int c = 8;

                    if (a % 2 == 0 && b % 2 == 0 && c % 2 == 0)
                    {
                        a /= 2;
                        b /= 2;
                        c /= 2;
                    }
                    else if (a % 2 == 0 || b % 2 == 0 || c % 2 == 0)
                    {
                        a *= 2;
                        b *= 2;
                        c *= 2;
                    }
                    else
                    {
                        a++;
                        b++;
                        c++;
                    }

                    Console.WriteLine("a = " + a);
                    Console.WriteLine("b = " + b);
                    Console.WriteLine("c = " + c);
                    ///4
                    int score = 75;

                    if (score >= 90 && score <= 100)
                    {
                        Console.WriteLine("Отлично");
                    }
                    else if (score >= 70 && score <= 89)
                    {
                        Console.WriteLine("Хорошо");
                    }
                    else if (score >= 50 && score <= 69)
                    {
                        Console.WriteLine("Удовлетворительно");
                    }
                    else
                    {
                        Console.WriteLine("Неудовлетворительно");

                    }
            }
            ///z5
            Console.WriteLine("Введите тип геометрической фигуры (к - круг, п - прямоугольник, т - треугольник):");
            char figureType = Convert.ToChar(Console.ReadLine());

            if (figureType == 'к')
            {
                Console.WriteLine("Введите радиус круга:");
                double radius = Convert.ToDouble(Console.ReadLine());
                double perimeter = 2 * Math.PI * radius;
                double area = Math.PI * radius * radius;
                Console.WriteLine("Периметр круга: " + perimeter);
                Console.WriteLine("Площадь круга: " + area);
            }
            else if (figureType == 'п')
            {
                Console.WriteLine("Введите длину прямоугольника:");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите ширину прямоугольника:");
                double width = Convert.ToDouble(Console.ReadLine());
                double perimeter = 2 * (length + width);
                double area = length * width;
                Console.WriteLine("Периметр прямоугольника: " + perimeter);
                Console.WriteLine("Площадь прямоугольника: " + area);
            }
            else if (figureType == 'т')
            {
                Console.WriteLine("Введите длину стороны A:");
                double sideA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите длину стороны B:");
                double sideB = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите длину стороны C:");
                double sideC = Convert.ToDouble(Console.ReadLine());
                double perimeter = sideA + sideB + sideC;
                double halfPerimeter = perimeter / 2;
                double area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
                Console.WriteLine("Периметр треугольника: " + perimeter);
                Console.WriteLine("Площадь треугольника: " + area);
            }
            else
            {
                Console.WriteLine("Некорректный тип геометрической фигуры.");
                //6
                Console.WriteLine("Введите марку автомобиля:");
                string carBrand = Console.ReadLine();

                Console.WriteLine("Введите срок страхования (от 1 до 12 месяцев):");
                int insuranceMonths = Convert.ToInt32(Console.ReadLine());

                double insuranceRate;
                if (insuranceMonths < 3)
                {
                    insuranceRate = 10;
                }
                else if (insuranceMonths >= 3 && insuranceMonths < 6)
                {
                    insuranceRate = 8;
                }
                else
                {
                    insuranceRate = 5;
                }

                double insuranceSum = 50 * insuranceMonths * (1 + insuranceRate / 100);

                Console.WriteLine("Ваш автомобиль марки " + carBrand + " был застрахован.");
                Console.WriteLine("Сумма страхового взноса составила " + insuranceSum + " рублей.");
            }
        }
    }
}
