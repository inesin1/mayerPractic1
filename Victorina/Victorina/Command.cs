using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victorina
{
    class Command
    {
        private static string playerCommand; //Команда

        public static string PlayerCommand { get => playerCommand; set => playerCommand = value; } //Геттер, сеттер

        //Ввод
        public static string input()
        {
            Console.Write("Команда: ");
            PlayerCommand = Console.ReadLine();

            return PlayerCommand;
        }
    }
}
