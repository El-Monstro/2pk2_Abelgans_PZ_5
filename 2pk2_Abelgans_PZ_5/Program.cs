using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2pc2_Abelgans_PZ5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            int a = 0;
            int b = 90;
            for (; a <= b; a += 5)
            {
                Console.WriteLine(a.ToString());
            }
            Console.ReadKey();
            {
                Console.WriteLine("Задание 2");
                char symbol = 'b';
                string result = "";
                for (int i = 0; i < 6; i++)
                    result += Convert.ToChar(symbol + i);

                Console.WriteLine(result);
                {
                    Console.WriteLine("Задание 3");
                    int n = 4;
                    int m = 5;
                    for (int i = 0; i < m; i++)

                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write('#');
                        }
                        Console.WriteLine();
                        {
                            Console.WriteLine("Задание 4");
                            int value = 7;
                            for (int i = 0; i < 100; i++)
                            {
                                Console.WriteLine(i);
                            }
                            {
                                Console.WriteLine("Задание 5");
                                int i = 1;
                                int j = 40;
                                int defference = 18;
                                for (; ; i++, j--)
                                {
                                    if (j - i == defference)
                                    {
                                        Console.WriteLine($"i = {i} \nj = {j}");
                                        break;
                                    }
                                }
                            }

                        }

                    }
                }
            }
        }
    }
}
