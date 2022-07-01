using System;

namespace IJunior_HomeWork_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Семенов";
            string surname ="Дмитрий";
            string tempLine;
            Console.WriteLine($"Ваше имя {name}. Ваша фамилия {surname}.");
            tempLine = name;
            name = surname;
            surname = tempLine;
            Console.WriteLine($"Ваше имя {name}. Ваша фамилия {surname}.");
        }
    }
}
