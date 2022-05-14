// See https://aka.ms/new-console-template for more information
using AlgorithmPrograms;

Console.WriteLine("Welcome to Algorithm Programs");
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