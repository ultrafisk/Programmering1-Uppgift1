using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1_Uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            char characterNumeroUno = 'E';
            char characterNumeroDos = 'H';
            float floatNameYo = 4.5F;
            int integerNameIsNice = 5;
            int[] theRealArrayTheBestArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                theRealArrayTheBestArray[i] = i;
            }
            foreach(int arrayNumber in theRealArrayTheBestArray)
            {
                Console.WriteLine(arrayNumber);
            }
            if (floatNameYo < 4.0)
            {
                Console.WriteLine("This Code Is Shit");
            }
            if (floatNameYo == 4.5F)
            {
                Console.WriteLine("This Code Is Almost Shit");
            }
            Console.WriteLine(characterNumeroUno);
            Console.WriteLine(characterNumeroDos);
            Console.ReadLine();
        }
    }
}
