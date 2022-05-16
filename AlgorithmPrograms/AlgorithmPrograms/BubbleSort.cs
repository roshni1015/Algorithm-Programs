using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BubbleSort
    {
        public void Bubblesort()
        {
            List<int> list = new List<int>() { 77, 44, 22, 55, 33, 11, 99, 66 };
            int temp;
            Console.Write("The Original elements are: ");
            foreach (int a in list)
                Console.Write(a + " ");
            Console.WriteLine();
            Console.WriteLine();
            for (int j = 0; j <= list.Count - 2; j++)
            {
                for (int i = 0; i <= list.Count - 2; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        temp = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = temp;
                    }
                }
            }
            Console.Write("The Bubble sorted elements are: ");
            foreach (int p in list)
                Console.Write(p + " ");
            Console.WriteLine();
            Console.WriteLine("*****************************************************************************");


        }
    }

}



