using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblemUsingGenerics
{
    internal class GenericClassPrintArray
    {
        public class GenericClass<T>
        {
            public T[] array;
            public GenericClass(T[] array)
            {
                this.array = array;
            }
            public void ToPrint()
            {
                Console.WriteLine("Displaying Array");
                foreach (T elements in array)
                {
                    Console.Write(elements + " ");
                }
                Console.WriteLine("\n");
            }




        }
    }
}
