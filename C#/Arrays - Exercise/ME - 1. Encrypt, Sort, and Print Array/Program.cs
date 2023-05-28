namespace ME___1._Encrypt__Sort__and_Print_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> encryptedValues = new List<int>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int encryptedValue = EncryptString(input);
                encryptedValues.Add(encryptedValue);
            }

            encryptedValues.Sort();

            foreach (int value in encryptedValues)
            {
                Console.WriteLine(value);
            }
        }

        static int EncryptString(string input)
        {
            int vowelSum = 0;
            int consonantSum = 0;

            foreach (char ch in input)
            {
                if (IsVowel(ch))
                {
                    vowelSum += ch * input.Length;
                }
                else
                {
                    consonantSum += ch / input.Length;
                }
            }

            int encryptedValue = vowelSum + consonantSum;
            return encryptedValue;
        }

        static bool IsVowel(char ch)
        {
            char lowerCh = char.ToLower(ch);
            return lowerCh == 'a' || lowerCh == 'e' || lowerCh == 'i' || lowerCh == 'o' || lowerCh == 'u';
        }
    }
}