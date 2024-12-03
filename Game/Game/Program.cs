using GameNamaSpaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите имя игрока: ");
        string playerName = Console.ReadLine();


        Player player = new Player(new Sword(), playerName);
        Game game = new Game(player);


        while (true)
        {
            game.Start();
            Console.WriteLine("Нажмите Enter, чтобы продолжить или 'q' для выхода.");
            if (Console.ReadLine()?.ToLower() == "q")
            {
                break;
            }
        }

        Console.WriteLine("Игра завершена. Спасибо за игру!");
    }
}