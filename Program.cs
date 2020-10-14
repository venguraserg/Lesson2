using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2");
            Method_Assignment2();
            Console.WriteLine("Задание 3");
            Method_Assignment3();
            Console.WriteLine("Задание 4");
            Method_Assignment4();
            Console.WriteLine("Задание 5");
            Method_Assignment5();
            Console.WriteLine("Задание 6");
            Method_Assignment6();
            Console.WriteLine("Задание 7");
            int[] a = { 1, 2, 3, 4, 5 };
            (int, int, int, string) cort = Method_Assignment7(a,"hello");
            Console.ReadLine();

            (int,int,int,string) Method_Assignment7(int[] massive, string str)
            {
                return (massive.Max(), massive.Min(), massive.Sum(), str.First().ToString());

            }
        }

        static void Method_Assignment2()
        {
            int[,] massive = new[,] { {1,2,3,4,5 },{6,7,8,9,10 } };
            int rows = massive.GetUpperBound(0) + 1;
            int columns = massive.Length / rows;
            

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{massive[i, j]}   ");
                }
                Console.WriteLine();
            }

        }

        static void Method_Assignment3()
        {
            string[] mass = new[] {"З","а","д","а","н","и","е","","3" };

            Console.Write($"Длинна массива = {mass.Length}, типданных {mass.GetType()} содержание - ");
            foreach (var i in mass)
            {
                Console.Write(i);

            }
            Console.WriteLine();

            Console.WriteLine($"Выберите номер элемента массива для замены из диапазон 0 - {mass.Length-1}") ;
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение для заменяемого элемента");
            mass[n] = Console.ReadLine();
            foreach (var i in mass)
            {
                Console.Write(i);

            }
            Console.WriteLine();
        }
        static void Method_Assignment4()
        {
            decimal[][] massive= new decimal[3][];
            massive[0] = new decimal[2] ;
            massive[1] = new decimal[3] ;
            massive[2] = new decimal[4] ;

            for (int i = 0; i < massive.Length; i++)
            {
                for (int j = 0; j < massive[i].Length; j++)
                {
                    Console.WriteLine($"Ввеждите элемент массива с индексом Столбец {i} Строка {j}");
                    massive[i][j] = decimal.Parse(Console.ReadLine());
                }
                
            }
            foreach (var i in massive)
            {
                foreach(var j in i)
                {
                    Console.Write($"{j}\t");

                }
                Console.WriteLine();
            }


        }
        static void Method_Assignment5()
        {
            var massive = new [,] { {1,2 },{1,2 } }; 
            var _str =  "asd";
        }
        static void Method_Assignment6()
        {
            (int, string, char, string, ulong) cortege = (15, "Hello", 'f', "Goodbye", 65452188);
            Console.WriteLine(cortege);
            Console.WriteLine(cortege.Item1);
            Console.WriteLine(cortege.Item3);
            Console.WriteLine(cortege.Item5);
            var item1 = cortege.Item1;
            Console.WriteLine(item1);
            var item2 = cortege.Item2;
            Console.WriteLine(item2);
            var item3 = cortege.Item3;
            Console.WriteLine(item3);
            var item4 = cortege.Item4;
            Console.WriteLine(item4);
            var item5 = cortege.Item5;
            Console.WriteLine(item5);

            (int, string, char, string, ulong) cortege2 = (14, "Hello", 'f', "Goodbye", 65452188);
            switch (cortege.CompareTo(cortege2))
            {
                case -1:
                    Console.WriteLine("кортеж 1 меньше кортежа 2");
                    break;
                case 0:
                    Console.WriteLine("кортеж 1 равен кортежу 2");
                    break;
                case 1:
                    Console.WriteLine("кортеж 2 меньше кортежа 1");
                    break;


            }
                
            
        }
    }
}
