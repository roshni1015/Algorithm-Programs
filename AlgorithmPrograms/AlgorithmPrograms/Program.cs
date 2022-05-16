// See https://aka.ms/new-console-template for more information
using AlgorithmPrograms;

Console.WriteLine("Welcome to Algorithm Programs");
while (true)
{
    Console.WriteLine("Please choose the option :\n1) Anagram \n2) Binary Search \n3) Insertion Sort \n4) Bubble Sort \n5) Finding Prime Numbers \n6) Merge sort \n7)Finding Number");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            AnagramDetection anagram = new();
            Console.WriteLine("Please Enter the Two Strings to Find if They are Anagrams or not. :");
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (anagram.AnagramDetector(first, second))
            {
                Console.WriteLine("Given words are Anagrams!");
            }
            else
            {
                Console.WriteLine("No! Given words are not Anagrams!");
            }
            Console.WriteLine("*****************************************************************************");
            break;
        case 2:
            BinarySearch binarysearch = new();
            string[] arr = { "apple", "ball", "cat", "dog", "ice", "keys" };
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }
            Array.Sort(arr);
            Console.WriteLine("Please Enter a String to be Searched :");
            string key = Console.ReadLine();
            int result = binarysearch.binarySearch(arr, key);
            if (result == -1)
            {
                Console.WriteLine("Element not present");
            }
            else
            {
                Console.WriteLine("Element found at " + "index " + result);
            }
            Console.WriteLine(result);
            Console.WriteLine("*****************************************************************************");
            break;
        case 3:
            InsertionSort Insert = new();
            Insert.Insertion_Sort();
            break;
        case 4:
            BubbleSort Bubble = new();
            Bubble.Bubblesort();
            break;
        case 5:
            PrimeNumber p1 = new();
            p1.Primenumber();
            break;
        case 6:
            MergeSort merge = new MergeSort();
            int n = 8;
            int[] array = { 35, 6, 50, 22, 45, 95, 67, 11, 75, 47 };
            Console.WriteLine("Merge Sort");
            Console.Write("Initial array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            merge.MergeSort1(array, 0, n - 1);
            Console.Write("\nSorted Array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("*****************************************************************************");
            break;
        case 7:
            FindingNumber Number = new();
            Number.Guess();
            break;
        default:
            Console.WriteLine("Please choose the correct ");
            break;
    }
}