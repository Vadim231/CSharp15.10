using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp15._10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Read

                int[] arr = System.IO.File.ReadAllText("text.txt").Split(' ').Select(n => int.Parse(n)).ToArray();
                foreach(int numbs in arr)
                {
                    Console.WriteLine(numbs+" ");
                }
                int sum=0;
                int perv = arr[(arr.Length)-2];
                int vtor = arr[arr.Length-1];
                
                //Write
                StreamWriter writer = File.AppendText("text.txt");
                for (int i = 0; i < arr.Length; i++)
                {
                    sum = perv + vtor;

                    writer.Write(sum + " ");

                    perv = vtor;
                    vtor = sum;
                }

                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            Console.ReadLine();
        }
    }
}
