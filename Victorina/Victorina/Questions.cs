using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victorina
{
    class Questions
    {
        public void q1() {
            Console.Clear();
            Console.WriteLine("Вопрос 1\n" +
                "Почему небо голубое?\n\n" +
                "1) Потому что акварелью раскрасили      2) Потому что озоновый слой\n" +
                "3) Потому что машины не летают          4) Потому что солнце голубое\n");

            switch (Command.input()) {
                case "1": Console.WriteLine("Не верно!"); if (Game.Lives > 0) { Game.Lives -= 1; q2(); } else Game.end(); break;
                case "2": Console.WriteLine("Верно!\n"); Game.Money += 1000; q2(); break;
                case "3": Console.WriteLine("Не верно!"); if (Game.Lives > 0) { Game.Lives -= 1; q2(); } else Game.end(); break;
                case "4": Console.WriteLine("Не верно!"); if (Game.Lives > 0) { Game.Lives -= 1; q2(); } else Game.end(); break;

                default: q1(); break;
            }             
        }

        public void q2()
        {
            Console.Clear();
            Console.WriteLine("Вопрос 2\n" +
                "Какая фамилия у Путина?\n\n" +
                "1) Назарбаев         2) Алексей\n" +
                "3) Путин             4) Чиполино\n");

            switch (Command.input())
            {
                case "1": Console.WriteLine("Не верно!"); if (Game.Lives > 0) { Game.Lives -= 1; q3(); } else Game.end(); break;
                case "2": Console.WriteLine("Не верно!"); if (Game.Lives > 0) { Game.Lives -= 1; q3(); } else Game.end(); break;
                case "3": Console.WriteLine("Верно!\n"); Game.Money += 1000; q3(); return;
                case "4": Console.WriteLine("Не верно!"); if (Game.Lives > 0) { Game.Lives -= 1; q3(); } else Game.end(); break;

                default: q2(); break;
            }
        }

        public void q3()
        {
            Console.Clear();
            Console.WriteLine("Вопрос 3\n" +
                "Кто доказал, что люди произошли от обезьян?\n\n" +
                "1) Чарльз Дарвин             2) Валентин Стрыкало\n" +
                "3) АЛександр Пушкин          4) Владимир Путин");

            switch (Command.input())
            {
                case "1": Console.WriteLine("Верно!"); Game.Money += 1000; q4(); return;
                case "2": Console.WriteLine("Не верно!"); if (Game.Lives > 0) { Game.Lives -= 1; q4(); } else Game.end(); break;
                case "3": Console.WriteLine("Не верно!"); if (Game.Lives > 0) { Game.Lives -= 1; q4(); } else Game.end(); break;
                case "4": Console.WriteLine("Не верно!"); if (Game.Lives > 0) { Game.Lives -= 1; q4(); } else Game.end(); break;

                default: q3(); break;
            }
        }

        public void q4()
        {
            Console.Clear();
            Console.WriteLine("Вопрос 4\n" +
                "В каком году появился майнкрафт?\n\n" +
                "1) 1998          2) 2005\n" +
                "3) 2008          4) 2015\n");

            switch (Command.input())
            {
                case "1": Console.WriteLine("Не верно!"); if (Game.Lives > 0) { Game.Lives -= 1; q5(); } else Game.end(); break;
                case "2": Console.WriteLine("Не верно!"); if (Game.Lives > 0) { Game.Lives -= 1; q5(); } else Game.end(); break;
                case "3": Console.WriteLine("Верно!\n"); Game.Money += 1000; q5(); return;
                case "4": Console.WriteLine("Не верно!"); if (Game.Lives > 0) { Game.Lives -= 1; q5(); } else Game.end(); break;

                default: q4(); break;
            }
        }

        public void q5()
        {
            Console.Clear();
            Console.WriteLine("Вопрос 5\n" +
                "Почему носят шляпу?\n\n" +
                "1) Холодно       2) Она сама ходить не умеет\n" +
                "3) Жарко         4) Красиво\n");

            switch (Command.input())
            {
                case "1": Console.WriteLine("Не верно!"); if (Game.Lives > 0) { Game.Lives -= 1; Game.win(); } else Game.end(); break;
                case "2": Console.WriteLine("Верно!\n"); Game.Money += 1000; Game.win(); break;
                case "3": Console.WriteLine("Не верно!"); if (Game.Lives > 0) { Game.Lives -= 1; Game.win(); } else Game.end(); break;
                case "4": Console.WriteLine("Не верно!"); if (Game.Lives > 0) { Game.Lives -= 1; Game.win(); } else Game.end(); break;

                default: q5(); break;
            }
        }
    }                     
}                         
                          