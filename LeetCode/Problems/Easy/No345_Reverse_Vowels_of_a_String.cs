namespace LeetCode.Problems
{
    //Given a string s, reverse only all the vowels in the string and return it.

    //The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.



    //Example 1:

    //Input: s = "hello"
    //Output: "holle"
    //Example 2:

    //Input: s = "leetcode"
    //Output: "leotcede"

    public class No345_Reverse_Vowels_of_a_String
    {
        public static string ReverseVowels(string s)
        {
            int start = 0, end = s.Length - 1;
            char[] sChar = s.ToCharArray();
            while (start < end)
            {
                // Find the leftmost vowel
                while (start < s.Length && !IsVowel(sChar[start]))
                {
                    start++;
                }
                // Find the rightmost vowel
                while (end >= 0 && !IsVowel(sChar[end]))
                {
                    end--;
                }
                // Swap them if start is left of end
                if (start < end)
                {
                    Swap(sChar, start, end);
                    start++;
                    end--;
                }
            }

            return new string(sChar);
        }
        static void Swap(char[] sChar, int sIndex, int eIndex)
        {
            sChar[sIndex] ^= sChar[eIndex];
            sChar[eIndex] ^= sChar[sIndex];
            sChar[sIndex] ^= sChar[eIndex];
        }
        static bool IsVowel(char s)
        {
            switch (s)
            {
                case 'a': case 'A': case 'e': case 'E': case 'i': case 'I': case 'o': case 'O': case 'u': case 'U': return true;
                default: return false;
            }
        }

        public static string ReverseVowels_Ori(string s)
        {
            string result = string.Empty;
            string rs = string.Empty;
            int rsIndex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'A' || s[i] == 'e' || s[i] == 'E' || s[i] == 'i' || s[i] == 'I' || s[i] == 'o' || s[i] == 'O' || s[i] == 'u' || s[i] == 'U')
                {
                    rs = s[i] + rs;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'A' || s[i] == 'e' || s[i] == 'E' || s[i] == 'i' || s[i] == 'I' || s[i] == 'o' || s[i] == 'O' || s[i] == 'u' || s[i] == 'U')
                {
                    result += rs[rsIndex];
                    rsIndex++;
                }
                else
                {
                    result += s[i];
                }
            }
            return result;
        }
    }
}
