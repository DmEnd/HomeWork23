using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.    Разработать асинхронный метод для вычисления факториала числа. В методе Main выполнить проверку работы метода.*/
            Console.Write("Введите целое число ");
            int n = Convert.ToInt32(Console.ReadLine());

            FactorialAsync1(n);
            //FactorialAsync2(n);
            
            Console.ReadKey();
        }
        public static async Task FactorialAsync1(int n)
        {
            //Console.WriteLine("Начало Метода 1");
            int f = await Task.Run(() =>
            {
                f = 1;
                for (int i = 1; i <= n; i++)
                {
                    f *= i;
                    //Console.WriteLine($"Итерпция {i} Метода 1");
                }
                return f;
            });
            Console.WriteLine($"n!={f}");
            //Console.WriteLine("Конец Метода 1");
        }

        //        static async Task FactorialAsync2(int n)
        //        {
        //            Console.WriteLine("Начало Метода 2");
        //            int f = await Task.Run(() => Factorial(n));

        //            Console.WriteLine($"n!={f}");
        //            Console.WriteLine("Конец Метода 2");
        //        }

        //        public static int Factorial(int n)
        //        {
        //            int f = 1;
        //            for (int i = 1; i <= n; i++)
        //            {
        //                f *= i;
        //                Console.WriteLine($"Итерпция {i} Метода 2");
        //            }
        //            return f;
        //        }
    }
}
