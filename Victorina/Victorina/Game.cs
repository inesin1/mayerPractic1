using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victorina
{
    static class Game
    {
        private static int lives = 3; //Жизни
        private static int money; //Сколько денег выиграли

        public static int Money { get => money; set => money = value; }
        public static int Lives { get => lives; set => lives = value; }

        public static void start() {
            Questions q = new Questions();

            q.q1();
        }

        public static void end()
        {
            Console.WriteLine("Игра окончена!");
            Console.ReadLine();
        }

        public static void win() {
            Console.WriteLine("Молодец!\n" +
                $"Ты ответил правильно на все вопросы и победил в игре. Твой приз - вымышленные {Money}$");
        }
    }
}
