using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace KontrolnaRabota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 9 5 1 9 7 4 9 

            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int elements = array.Length;
            int sum = 0;
            int num = 0;
            int repeat = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int sameNum = array[i];
                
                sum = num + array[i];
                if (array[i] < elements)
                {
                    elements = array[1];
                    Console.WriteLine($"The biggest number is:{elements}");

                }
                if (sameNum > array[i])
                {
                    repeat+=1;
                    sameNum = array[i];
                    Console.WriteLine(repeat);
                    
                }
                Console.WriteLine($"sum:{sum}");
            }








        }
    }
}
