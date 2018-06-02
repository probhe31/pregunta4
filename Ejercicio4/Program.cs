using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Duplicates duplicates = new Duplicates();
            int[] numbers = { 45, 69, 2, 1, 3, 7, 8, 9, 10, 11, 15, 17, 18, 20, 25, 26, 27, 19, 38, 38 };
            ResultDto resultDto = duplicates.DuplicateValues_Better(numbers);
            Console.WriteLine("N: " + numbers.Length);
            Console.WriteLine("has duplicate values: " + resultDto.HasDuplicate());
            Console.WriteLine("steps: " + resultDto.GetSteps());


            Console.WriteLine("N: " + numbers.Length);

            Console.ReadKey();
        }
    }
}
