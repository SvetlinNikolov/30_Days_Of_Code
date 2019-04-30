using System;
using System.Linq;
using System.Collections.Generic;
namespace Day_8_Dictionaries_and_Maps
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfKvp = int.Parse(Console.ReadLine());

            var nameAndNumber = new Dictionary<string, string>();

            for (int i = 0; i < numberOfKvp; i++)
            {
                string[] nameAndPhoneNumberInput = Console.ReadLine().Split();

                string name = nameAndPhoneNumberInput[0];
                string number = nameAndPhoneNumberInput[1];

                nameAndNumber.Add(name, number);                            
            }

            while (true)
            {
                string name = Console.ReadLine();

                if (nameAndNumber.ContainsKey(name))
                {
                    Console.WriteLine($"{name}={nameAndNumber[name]}");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
