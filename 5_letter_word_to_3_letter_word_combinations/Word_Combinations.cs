namespace _5_letter_word_to_3_letter_word_combinations
{
    public static class Word_Combinations
    {
        //Generates unquie word combinations from the user's 5 letter word
        public static List <string> GenerateThreeLetterCombinations(string word)
        {
            List <string> combinations = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == i)
                        continue; // skips if the smae letter is used tp prevent duplicate letters and an overflow of the same letter combinations like aaa or ooo words that only use one letter
                    for (int k = 0; k < 5; k++)
                    {
                       if (k == i || k == j) continue; // skips if the letter is already used so same as the last one but check to see if the word is used in another 3 letter combination to prevent some duplicate words.
                       string combination = $"{word[i]}{word[j]}{word[k]}";
                        if (!combination.Contains(combination));  // ensures no duplicates
                        {
                            combinations.Add(combination);
                        }
                    }
                }
            }
            return combinations;
        }
    }
}
