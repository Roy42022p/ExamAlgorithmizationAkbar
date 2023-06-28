//using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите фамилию: ");
        string фамилия = Console.ReadLine();

        Console.Write("Введите оценку: ");
        int оценка = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Поздравляю, {фамилия}! У Вас автоматом {оценка} за экзамен. ");

    }
}