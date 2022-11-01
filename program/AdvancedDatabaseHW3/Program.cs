using System;

namespace AdvancedDatabaseHW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of tables :");
            int nt = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[nt];
            int[] order = new int[nt];
            char[] name = new char[nt];
            char ch= 'A';
            for (int i = 0; i < nt; i++)
            {
                name[i] = ch;
                Console.Write("Enter rows of table "+ name[i]+ " : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                ch++;
            }

            Array.Sort(arr, name);
            order = arr;

            Console.WriteLine("");

            Console.WriteLine("Oder of Tables : ");
            for (int i = 0; i < nt; i++)
            {
                Console.Write(name[i] + " : ");
                Console.WriteLine(order[i] + " ");
            }

            Console.WriteLine("");

            Console.WriteLine("Optimal Oder : ");
            for (int i = 0; i < nt - 2; i++) Console.Write("<");
            Console.Write(name[0]+" Join "+ name[1]);
            for (int i = 2; i < nt; i++) Console.Write("> Join "+ name[i]);

            Console.WriteLine("");

            int Sum = 0;
            int PriorRowCount = order[0];

            for (int i = 1; i <= nt - 1; i++)
            {
                Sum += PriorRowCount * Convert.ToInt32(Math.Ceiling((double)order[i] / 20));
                PriorRowCount *= order[i];
            }

            Console.WriteLine("");

            Console.WriteLine("Optimal Cost : " + Sum);
        }
    }
}
