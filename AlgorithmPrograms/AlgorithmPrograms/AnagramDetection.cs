using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class AnagramDetection
    {
        public bool AnagramDetector(string First, string Second)
        {
            if (First == null || Second == null)
            {
                Console.WriteLine("Please enter two strings!");
                return false;
            }
            if (First.Length != Second.Length)
            {
                Console.WriteLine("Please enter two strings of same length!");
                return false;
            }
            char[] FirstCharArray = First.ToLower().ToCharArray();
            char[] SecondCharArray = Second.ToLower().ToCharArray();
            Array.Sort(FirstCharArray);
            Array.Sort(SecondCharArray);
            for (int i = 0; i < FirstCharArray.Length; i++)
            {
                if (FirstCharArray[i] != SecondCharArray[i])
                    return false;
            }
            return true;
        }
    }
}
        
    
