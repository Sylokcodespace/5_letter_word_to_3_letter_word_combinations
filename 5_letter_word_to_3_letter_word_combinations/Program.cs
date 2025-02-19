namespace _5_letter_word_to_3_letter_word_combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a five letter word");
            string? word = Console.ReadLine();
            if (word == null || word.Length == 0)
            {
                Console.WriteLine("Input is invalid or its empty");
                return;
            }

            // validates what the user has put in as their five letter word combination and if it is not a complete string of words like bathe then it will return an error mesage to the user.
            if (!Word_Checker.IsValidWord(word))
            {
                Console.WriteLine("Error: Please enter a excatly five letter word with no numbers");
                return;
            }
            Console.WriteLine("All possiable word combinations");

            //generates the possiable three letter word combinations form the user's five letter word
            List<string> combinations = Word_Combinations.GenerateThreeLetterCombinations(word);
            foreach (string combo in combinations)
            {
                Console.WriteLine(combo);
            }
        }
    }
}
