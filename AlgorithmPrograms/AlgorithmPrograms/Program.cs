﻿// See https://aka.ms/new-console-template for more information
using AlgorithmPrograms;

Console.WriteLine("Welcome to Algorithm Programs");
while (true)
{
    Console.WriteLine("Please choose the option :\n1) Anagram \n2) Binary Search");
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
            break;
        default:
            Console.WriteLine("Please choose the correct ");
            break;
    }
}