using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_a_W_output
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan nilai: ");
            int input = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < input; i++) // ini for utk baris
            {
                for (int j = 0; j <= input; j++) // ini for utk kolom
                {
                    if (j == input - 1) // sisi miring kanan pertama
                    {
                        for (int k = i; k < input -1; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("*");
                        if (i > 0)
                        {
                            for (int k = 0; k < (i*2) - 1; k++)
                            {
                                Console.Write(" ");
                            }
                            Console.Write("=");
                        }
                        if (i < input - 1)
                        {
                            for (int k = 0; k < (input -2-i)*2 + 1; k++)
                            {
                                Console.Write(" ");
                            }
                            Console.Write("*");
                        }
                    }
                    else if (i == j)
                    {
                            Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}
