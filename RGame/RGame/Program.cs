using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RGame
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Дарова, путник. Твой путь привёл тебя в запретный лес. " +
                "\nТебя наверняка предупреждали... На тебя напал орк " +
                "\n\nВыбери героя: Эльф, Дворф, Человек");
            string hero = Convert.ToString(Console.ReadLine());
            switch (hero)
            {
                case ("Эльф"):
                    Console.WriteLine("Ты выбрал Эльфа. Основной вид оружия - Лук");
                    break;
                case ("Дворф"):
                    Console.WriteLine("Ты выбрал Дворфа. Основной вид оружия - Топор");
                    break;
                case ("Человек"):
                    Console.WriteLine("Ты выбрал Человека. Основной вид оружия - Меч");
                    break;
                default:
                    Console.WriteLine ("Ошибка при вводе. Выбран Человек:");
                    break;
            }
            Weapon sword = new Weapon();
            int sword_hit = sword.attack(6, 1);
            Weapon bow = new Weapon();
            int bow_hit = bow.attack(7, 1);
            Weapon axe = new Weapon();
            int axe_hit = axe.attack(8, 1);
            Weapon dagger = new Weapon();
            int dagger_hit = dagger.attack(4, 2);
            Weapon pistol = new Weapon();
            int pistol_hil = pistol.attack(4, 2);
            Console.WriteLine("Выбери себе оружие: \n Меч - {0} \n Лук - {1}\n Топор - {2}\n Кинжалы - {3} \n Пистолеты - {4}", 
                sword.info(), bow.info(), axe.info(), dagger.info(), pistol.info());
            string weapon = Convert.ToString(Console.ReadLine());
            Enemy orc = new Enemy();
            int orc_hp = orc.setValues(100);
            Console.ReadKey();


        }
    }
}
