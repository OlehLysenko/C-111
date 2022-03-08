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
            while (true)
            {
                Console.Clear();
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
                        Console.WriteLine("Ошибка при вводе. Выбран Человек:");
                        break;
                }
                Weapon sword = new Weapon();
                int sword_hit = sword.damage(10, 1);
                Weapon bow = new Weapon();
                int bow_hit = bow.damage(9, 1);
                Weapon axe = new Weapon();
                int axe_hit = axe.damage(11, 1);
                Weapon dagger = new Weapon();
                int dagger_hit = dagger.damage(5, 2);
                Weapon pistol = new Weapon();
                int pistol_hit = pistol.damage(5, 2);

                Console.WriteLine("\tМеч - {0} \n\tЛук - {1}\n\tТопор - {2}\n\tКинжалы - {3} \n\tПистолеты - {4}",
                    sword.info(), bow.info(), axe.info(), dagger.info(), pistol.info());
                Console.Write("Выбери оружие: ");
                string weapon = Convert.ToString(Console.ReadLine());

                Enemy orc = new Enemy();
                int orc_hp = orc.setValues(100);


                while (orc_hp > 0)
                {
                    switch (weapon)
                    {
                        case ("Меч"):
                            Console.WriteLine("Наносим удар мечом.");
                            orc_hp = orc_hp - sword_hit;
                            Console.WriteLine("Здоровье орка: " + orc_hp);
                            break;
                        case ("Лук"):
                            Console.WriteLine("Наносим удар луком.");
                            orc_hp = orc_hp - bow_hit;
                            Console.WriteLine("Здоровье орка: " + orc_hp);
                            break;
                        case ("Топор"):
                            Console.WriteLine("Наносим удар топором. ");
                            orc_hp = orc_hp - axe_hit;
                            Console.WriteLine("Здоровье орка: " + orc_hp);
                            break;
                        case ("Кинжалы"):
                            Console.WriteLine("Наносим удар кинжалами.");
                            orc_hp = orc_hp - dagger_hit;
                            Console.WriteLine("Здоровье орка: " + orc_hp);
                            break;
                        case ("Пистолеты"):
                            Console.WriteLine("Наносим удар пистолетами. ");
                            orc_hp = orc_hp - pistol_hit;
                            Console.WriteLine("Здоровье орка: " + orc_hp);
                            break;
                        default:
                            Console.WriteLine("Ошибка при вводе. Наносим удар мечом: ");
                            orc_hp = orc_hp - pistol_hit;
                            Console.WriteLine("Здоровье орка: " + orc_hp);
                            break;
                    }
                    if (orc_hp > 0)
                    {
                        Console.Write("Выбери оружие: ");
                        weapon = Convert.ToString(Console.ReadLine());
                    }
                    else if (orc_hp < 0 || orc_hp == 0)
                    {
                        Console.WriteLine("Вы поберили орка!");
                    }



                }
                Console.ReadKey();
            }


        }
    }
}
