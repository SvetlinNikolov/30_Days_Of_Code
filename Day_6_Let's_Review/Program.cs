using System;

namespace Day_6_Let_s_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWordsToRead = int.Parse(Console.ReadLine());

            string even = string.Empty;
            string odd = string.Empty;

            for (int i = 0; i < numberOfWordsToRead; i++)
            {
                string word = Console.ReadLine();

                for (int j = 0; j < word.Length; j++)
                {
                    if (j%2==0)
                    {
                        even += word[j];
                    }
                    else
                    {
                        odd += word[j];
                    }
                }
                Console.Write(even+" ");
                Console.WriteLine(odd);

                even = string.Empty;
                odd = string.Empty;
            }
        }

    }
}
