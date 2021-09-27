using System;

namespace ConsoleApp1
{
    //author: Naufal Norman Hisyam

    class Program
    {
        static void Main(string[] args)
        {
            int lockerNumber;
            Program p = new Program();

            while (true)
            {
                Console.Write("Insert Lokcer Number: ");
                try
                {
                    lockerNumber = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Floor: "+p.solve(lockerNumber));
                }
                catch
                {
                    Console.WriteLine("Invalid Input.");
                }
            }
        }

        int solve(int num)
        {
            int iter = (num / 18);
            int residue = num % 18;

            if (num > 18)
                iter *= 3;

            if (residue <= 5 && residue != 0)
                iter += 1;
            else if (residue <= 11)
                iter += 2;
            else 
                iter += 3;

            return iter;
        }


    }
}
