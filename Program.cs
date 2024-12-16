namespace Assignment_7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sort.SortGrades();//7.1 See Classes (Sort/Swap) for code/ futher explanation
            Swap.SwapGrades(1, 1);
            string word1 = "Greetings";                            //7.2 Merge Strings
            string word2 = "World";
            Console.WriteLine($"The two words that you choose are {word1} and {word2}");
            string mergedWord = MergeStringsMethod.MergeStrings(word1, word2); //7.2 Merge Strings
            Console.WriteLine($"The merged string is: {mergedWord}");
        }
    }
}
