﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР8.Гладиаторы
{
    internal class Player
    {
        int money;
        int glory;
        List<Gladiator> gladiators;

        internal Player()
        {
            money = 100;
            glory = 0;
            gladiators = new List<Gladiator>()
            {
                new Gladiator("Аурелиан Железный Клинок"),
                new Gladiator("Северус Кровавый Гром"),
                new Gladiator("Леонид Сокрушитель"),
                new Gladiator("Максимус Безжалостный"),
                new Gladiator("Валерий Череполом"),
                new Gladiator("Артемий Молотильщик")
            };
        }

        internal void HireGladiators(int number)
        {
            for (int i = 0; i < number; i++) { gladiators.Add(new Gladiator("Григорий")); }
        }

        internal void Heal(Gladiator gladiator)
        {
            gladiator.Health = 100;
            money -= 100;
            Console.WriteLine($"Гладиатор {gladiator.Name} восстановил свое здоровье.");
        }

        internal void BuyArmor(Gladiator gladiator, Armor armor)
        {
            if (money < armor.Price)
            {
                Console.WriteLine("У вас недостаточно монет для покупки этого доспеха.");
                return;
            }

            money -= armor.Price;
            gladiator.Armor = armor;
            Console.WriteLine($"Вы купили {armor.Name} за {armor.Price} монет.");
        }

        internal void BuyWeapon(Gladiator gladiator, Weapon weapon)
        {
            if (money < weapon.Price)
            {
                Console.WriteLine("У вас недостаточно денег для покупки этого оружия.");
                return;
            }

            money -= weapon.Price;
            gladiator.Weapon = weapon;
            Console.WriteLine($"Вы купили {weapon.Name} за {weapon.Price} монет.");
        }
    }
}
