using System.Text;

namespace CSES_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs1 = { "eat", "tea", "tan", "ate", "nat", "bat" };
            // Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
            string[] strs2 = { "" };
            // Output: [[""]]
            string[] strs3 = { "a" };
            // Output: [["a"]]

            Console.WriteLine(GroupAnagrams(strs1));
            Console.WriteLine(GroupAnagrams(strs2));
            Console.WriteLine(GroupAnagrams(strs3));
        }
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if (strs.Length == 0)
                return new List<IList<string>>();

            Dictionary<string, List<string>> anagrams = new();

            foreach (string word in strs)
            {
                int[] count = new int[26];

                foreach (char c in word)
                    count[c - 'a']++;

                StringBuilder sb = new();

                for (int i = 0; i < 26; i++)
                {
                    sb.Append("#");
                    sb.Append(count[i]);
                }
                string key = sb.ToString();

                if (!anagrams.ContainsKey(key))
                    anagrams[key] = new List<string>();

                anagrams[key].Add(word);
            }
            return new List<IList<string>>(anagrams.Values);
        }
    }
}
