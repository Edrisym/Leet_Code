public class Solution
{
    public bool IsValid(string word)
    {
        if (string.IsNullOrEmpty(word) || word.Length < 3)
        {
            return false;
        }

        bool hasVowel = false;
        bool hasConsonant = false;

        foreach (char ch in word)
        {
            if (!char.IsLetterOrDigit(ch))
            {
                return false;
            }

            if (char.IsLetter(ch))
            {
                char lowerCh = char.ToLower(ch);

                if ("aeiou".Contains(lowerCh))
                {
                    hasVowel = true;
                }
                else
                {
                    hasConsonant = true;
                }
            }
        }

        return hasVowel && hasConsonant;
    }
}