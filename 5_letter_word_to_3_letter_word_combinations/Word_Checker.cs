namespace _5_letter_word_to_3_letter_word_combinations
{
    public static class Word_Checker
    {
        // checks the word to make sure that it is five letters and not under 5 letter or above 5 letters but also will be checking for any numbers as well and will not return and ask user to restrat what they put in.
        public static bool IsValidWord(string word)
        {
            if(word.Length != 5) 
                return false; // ensures that the words is excatly 5 characters long

            foreach (char c in word)
            {
                if(!char.IsLetter(c)) // ensures that each character is a letter.
                    return false; //returns false if a non-letter character is found
            }
            return true; // returns true if the word form user passes both of these test to ensure that the word is a word with out numbers and 
        }
    }
}
