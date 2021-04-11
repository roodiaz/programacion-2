using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            /*las coleccciones stack y queue no se puede ordenar
            hay que convertirlas en lista pra poder hacerlo*/

            Stack<int> numStack = new Stack<int>();
            List<int> numList = new List<int>();
            Queue<int> numQue = new Queue<int>();

            Random rnd = new Random();

            #region Stack           
            for (int i = 0; i < 20; i++)
            {
                //cargo numeros en stack
                numStack.Push(rnd.Next(-20, 20));
            }

            Console.WriteLine("Stack sin ordenar:");
            foreach (int item in numStack)
            {
                Console.Write($"{item}, ");
            }
            #endregion

            #region List
            numList = numStack.ToList();//copio los numeros del stack a lista
            numList.Sort();//ordeno

            Console.WriteLine("\n\nordenados:");
            foreach (int item in numList)
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine("\n\nnegativos:");
            foreach (int item in numList)
            {
                if (item < 0)
                {
                    Console.Write($"{item}, ");
                }

            }

            Console.WriteLine("\n\npositivos:");
            foreach (int item in numList)
            {
                if (item > 0)
                {
                    Console.Write($"{item}, ");
                }

            }
            #endregion

            #region Queue
            for (int i = 0; i < 20; i++)
            {
                //cargo numeros a queue
                numQue.Enqueue(rnd.Next(-20, 20));
            }


            Console.WriteLine("\n\nQueue sin ordenar:");
            foreach (int item in numQue)
            {
                Console.Write($"{item}, ");
            }

            numList = numQue.ToList();//convierto queue a lista para ponder ordenar
            numList.Sort();//ordeno

            Console.WriteLine("\n\nOrdenado:");
            foreach (int item in numList)
            {
                Console.Write($"{item}, ");
            }
            #endregion

            Console.ReadKey();
        }
    }
}
