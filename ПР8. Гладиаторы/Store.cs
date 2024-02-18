﻿using System;

namespace ПР8.Гладиаторы
{
    class Store
    {
        internal Armor[] Armors { get; }
        internal Weapon[] Weapons { get; }

        internal Store()
        {
            Armors = new Armor[]
            {
                new Armor("Простая кожаная броня", 1.1, 30),
                new Armor("Плащ путешественника", 1.2, 40),
                new Armor("Плетеный доспех", 1.3, 50),
                new Armor("Рваная кольчуга", 1.4, 60),
                new Armor("Кольчуга с кожаными вставками", 1.5, 70),
                new Armor("Легкий пластинчатый доспех", 1.6, 80),
                new Armor("Стальной корсет", 1.7, 90),
                new Armor("Усиленная кольчуга", 1.8, 100),
                new Armor("Бригантина", 1.9, 110),
                new Armor("Чешуйчатый доспех", 2.0, 120),
                new Armor("Доспехи орка", 2.1, 130),
                new Armor("Тяжелый пластинчатый доспех", 2.2, 140),
                new Armor("Бесшовная броня", 2.3, 150),
                new Armor("Кольчуга с пластинами", 2.4, 160),
                new Armor("Драконьи чешуйки", 2.5, 170),
                new Armor("Поврежденные латы", 2.6, 180),
                new Armor("Латы", 2.7, 190),
                new Armor("Шкура дракона", 2.8, 200),
                new Armor("Кольчуга из мифрила", 2.9, 210),
                new Armor("Доспех великого хранителя", 3.0, 250)
            };

            Weapons = new Weapon[]
            {
                new Weapon("Деревянный меч", 20, 40),
                new Weapon("Старый кинжал", 25, 50),
                new Weapon("Ржавый клинок", 30, 60),
                new Weapon("Стальной меч", 35, 70),
                new Weapon("Копье", 40, 80),
                new Weapon("Железный боевой топор", 45, 90),
                new Weapon("Лук и стрелы", 50, 100),
                new Weapon("Катана", 55, 110),
                new Weapon("Двуручный меч", 65, 120),
                new Weapon("Рапира", 70, 130),
                new Weapon("Клеймор", 75, 140),
                new Weapon("Палица", 80, 150),
                new Weapon("Алебарда", 90, 160),
                new Weapon("Пика", 95, 170),
                new Weapon("Экскалибур", 100, 180),
                new Weapon("Посох мага", 105, 190),
                new Weapon("Клинок тьмы", 110, 200),
                new Weapon("Палаш Погибели", 120, 210),
                new Weapon("Молот бога", 130, 250)
            };
        }

        internal void ShowArmors()
        {
            for (int i = 0; i < Armors.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {Armors[i].Info()}. Цена: {Armors[i].Price} монет");
            }
            Console.WriteLine($"\n{Armors.Length + 1}) Вернуться назад");
        }

        internal void ShowWeapons()
        {
            for (int i = 0; i < Weapons.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {Weapons[i].Info()}. Цена: {Weapons[i].Price} монет");
            }
            Console.WriteLine($"\n{Weapons.Length + 1}) Вернуться назад");
        }
    }
}
