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
            char characterNumeroUno = 'E'; //skapar en char variabel med värdet E
            char characterNumeroDos = 'H'; //typ samma som ovan
            float floatNameYo = 4.5F; //skapar en float
            int integerNameIsNice = 5; //skapar en integer
            int[] theRealArrayTheBestArray = new int[10]; //skapar en int array
            for (int i = 0; i < 10; i++) //ger varje int i arrayen ett värde
            {
                theRealArrayTheBestArray[i] = i;
            }
            foreach(int arrayNumber in theRealArrayTheBestArray) //skriver ut arrayens värden
            {
                Console.WriteLine(arrayNumber);
            }
            if (floatNameYo < 4.0) //skriver ut en sak om floatNameYo är mindre än 4
            {
                Console.WriteLine("This Code Is Shit");
            }
            if (floatNameYo == 4.5F) //skriver ut ngt om floatNameYo är lika med 4.5
            {
                Console.WriteLine("This Code Is Almost Shit");
            }
            Console.WriteLine(characterNumeroUno); //skriver ut characterNumeroUno
            Console.WriteLine(characterNumeroDos); //skriver ut characterNumeroDos
            Console.ReadLine(); //läser
        }
    }
}
