using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblemUsingGenerics
{
    internal class GenericsPrintArray
    {
        public static void ToPrint<T>(T[] array)
        {
            Console.WriteLine("Displaying Array");
            foreach (T elements in array)
            {
                Console.Write(elements + " ");

            }
        }
    }

}
