using System;

class Metod3
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        bool is_ok = Check(text);

        if (is_ok)
        {
            Console.WriteLine("Скобки расставлены правильно");
        }
        else
        {
            Console.WriteLine("Скобки расставлены неправильно");
        }
    }

    static bool Check(string text)
    {
        int counter = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '(')
            {
                counter++;
            }
            else if (text[i] == ')')
            {
                if (counter == 0)
                {
                    Console.WriteLine($"Лишняя закрывающая скобка на позиции {i}");
                    return false;
                }

                counter--;
            }
        }

        if (counter > 0)
        {
            Console.WriteLine($"Лишние открывающие скобки в количестве {counter}");
            return false;
        }

        return true;
    }
}