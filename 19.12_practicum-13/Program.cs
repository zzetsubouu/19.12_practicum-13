using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1.Вычислить значение функции для целых аргументов двумя способами(1 - й способ: полный условный оператор; 2 - й способ: тернарная операция)

            //Console.Write("x=");
            //int x = int.Parse(Console.ReadLine());
            //double y = 0;

            //полный условный оператор

            //if (x < 0)
            //{
            //    y = Math.Pow(Math.Sin(x), 2);//y = Math.sin(x)*Math.sin(x)


            //}
            //else
            //{
            //    y = 1 - 2 * Math.Pow(Math.Sin(x), 2);//y=1-2*Math.Sin(x*x);

            //}
            //Console.WriteLine($"y={y:f3}");
            //Console.ReadLine();

            //тернарная операция

            //double ter = (x < 0)? Math.Pow(Math.Sin(x), 2) : 1 - 2 * Math.Pow(Math.Sin(x), 2);
            //Console.WriteLine($"ter={ter:f3}");

            //Console.ReadLine();

            //Задание 2.Используя двузначное случайное число, вывести на экран информацию о четности или нечетности этого числа с использованием тернарной операции.

            //Random rnd = new Random();
            //int x = rnd.Next(10, 99);
            //Console.WriteLine(x);
            //string y = (x % 2 == 0) ? "четное" : "нечетное";
            //Console.WriteLine(y);
            //Console.ReadKey();


            //Задание 3.Даны три целых положительных числа. Если все они четные, каждое число увеличить на 1; если хотя бы одно из них четное, уменьшить на 1; если четных чисел нет, каждое число увеличить в 2 раза.

            //Console.Write("x=");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("y=");
            //int y = int.Parse(Console.ReadLine());
            //Console.Write("z=");
            //int z = int.Parse(Console.ReadLine());
            //if (x%2 == 0 && y%2 == 0 && z%2 == 0) 
            //{
            //    x += 1;
            //    y += 1;
            //    z += 1;
            //}
            //else if (x%2 != 0 | y%2 !=0 | z%2 !=0)
            //{
            //    x-=1;
            //    y-=1;
            //    z-=1;
            //}
            //else 
            //{
            //    x *= 1;
            //    y *= 1;
            //    z *= 1;
            //}
            //Console.WriteLine($"{x} {y} {z}");
            //Console.ReadKey();



            //Задание 4. Используя случайное число в диапазоне от -20 до 20, вывести на экран название месяца в году.


            Random rnd = new Random();
            int number = rnd.Next(-20, 20);
            Console.WriteLine(number);
            switch (number)
            {
                case 1: Console.WriteLine("январь"); break;
                case 2: Console.WriteLine("февраль"); break;
                case 3: Console.WriteLine("март"); break;
                case 4: Console.WriteLine("апрель"); break;
                case 5: Console.WriteLine("май"); break;
                case 6: Console.WriteLine("июнь"); break;
                case 7: Console.WriteLine("июль"); break;
                case 8: Console.WriteLine("август"); break;
                case 9: Console.WriteLine("сентябрь"); break;
                case 10: Console.WriteLine("октябрь"); break;
                case 11: Console.WriteLine("ноябрь"); break;
                case 12: Console.WriteLine("декабрь"); break;
                default: Console.WriteLine("ошибка"); break;
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
