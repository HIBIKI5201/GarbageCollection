namespace GabageCollection.MemoryPressure
{

    public static class StringCreator
    {
        public static string BuildString(string str1, string str2)
        {
            string[] str1Array = new string[str1.Length];
            string[] str2Array = new string[str2.Length];

            for (int i = 0; i < str1.Length; i++)
            {
                str1Array[i] = str1[i].ToString();
            }

            for (int i = 0; i < str2.Length; i++)
            {
                str2Array[i] = str2[i].ToString();
            }

            char[][] str1CharArrays = new char[str1Array.Length][];
            char[][] str2CharArrays = new char[str2Array.Length][];

            for (int i = 0; i < str1Array.Length; i++)
            {
                str1CharArrays[i] = str1Array[i].ToCharArray();
            }

            for (int i = 0; i < str2Array.Length; i++)
            {
                str2CharArrays[i] = str2Array[i].ToCharArray();
            }

            char[] str1Chars = new char[str1.Length];
            char[] str2Chars = new char[str2.Length];

            int index = 0;

            for (int i = 0; i < str1CharArrays.Length; i++)
            {
                for (int j = 0; j < str1CharArrays[i].Length; j++)
                {
                    str1Chars[index++] = str1CharArrays[i][j];
                }
            }

            index = 0;

            for (int i = 0; i < str2CharArrays.Length; i++)
            {
                for (int j = 0; j < str2CharArrays[i].Length; j++)
                {
                    str2Chars[index++] = str2CharArrays[i][j];
                }
            }

            char[] finalChars = new char[str1Chars.Length + str2Chars.Length];

            for (int i = 0; i < str1Chars.Length; i++)
            {
                finalChars[i] = str1Chars[i];
            }

            for (int i = 0; i < str2Chars.Length; i++)
            {
                finalChars[str1Chars.Length + i] = str2Chars[i];
            }

            return new string(finalChars);
        }
    }
}
