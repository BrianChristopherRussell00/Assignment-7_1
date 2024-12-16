using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_1
{
    public class MergeStringsMethod
    {
        public static string MergeStrings(string word1, string word2)
        {
            int maxLength = 0;
            if (word1.Length > word2.Length)
            {
                maxLength = word1.Length;
            }
            else
            {
                maxLength = word2.Length;
            }
            char[] result = new char[word1.Length + word2.Length];
            int index = 0;

            for (int i = 0; i < maxLength; i++)
            {
                if (i < word1.Length)
                {
                    result[index++] = word1[i];


                }
                if (i < word2.Length)
                {
                    result[index++] = word2[i];

                }

            }
            return new string(result);
        }
    }
}