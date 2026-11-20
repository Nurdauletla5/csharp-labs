using System;

class Program
{
    static string RemoveDigits(string text, out int digitCount)
    {
        string result = "";
        digitCount = 0;

        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            if (char.IsDigit(ch))
            {
                digitCount++;
            }
            else
            {
                result += ch;
            }
        }

        return result;
    }

    static void Main()
    {
        string text;

        do
        {
            Console.Write("Жол енгізіңіз: ");
            text = Console.ReadLine();
        }
        while (string.IsNullOrEmpty(text));

        string newText = RemoveDigits(text, out int count);

        Console.WriteLine();
        Console.WriteLine("Бастапқы жол:");
        Console.WriteLine(text);

        Console.WriteLine();
        Console.WriteLine("Нәтиже:");
        Console.WriteLine(newText);

        Console.WriteLine();
        Console.WriteLine("Алып тасталған цифрлар саны: " + count);
    }
}
