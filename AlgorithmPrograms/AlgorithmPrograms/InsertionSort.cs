using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class InsertionSort
    {
        public void Insertion_Sort()
        {
            List<string> list = new List<string>() { "Pinapple" ,"Deer","Potato","Flower","Coffe", "Strawberry", "JackFruit","Lion", "Umbrella","Angel" };
            int n = 10, i, j, flag;
            string val;
            Console.Write("Initial List is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            for (i = 1; i < n; i++)
            {
                val = list[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val.CompareTo(list[j]) < 0)
                    {
                        list[j + 1] = list[j];
                        j--;
                        list[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            Console.Write("\nSorted List is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("*****************************************************************************");
        }

    }
}
