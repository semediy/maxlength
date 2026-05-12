using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       
        Console.Write("Введіть слово: ");

        string word = Console.ReadLine();

        List<char> current = new List<char>();
        List<char> longest = new List<char>();

        for (int i = 0; i < word.Length; i++)
        {
            char symbol = word[i];

            
            if (!current.Contains(symbol))
            {
                current.Add(symbol);
            }
            else
            {
              
                while (current[0] != symbol)
                {
                    current.RemoveAt(0);
                }
                
                current.RemoveAt(0);

                
                current.Add(symbol);
            }
            
            if (current.Count > longest.Count)
            {
                longest = new List<char>(current);
            }
        }

        Console.WriteLine("Найдовший унікальний підрядок:");

        foreach (char c in longest)
        {
            Console.Write(c);
        }

        Console.WriteLine();
        Console.WriteLine("Довжина: " + longest.Count);
    }
}