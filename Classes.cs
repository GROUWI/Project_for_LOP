using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ну_рванули
{
    /* записываем в класс Item общие параметры остальных классов */
    /* НАСЛЕДОВАНИЕ */
    class Item
    {
        public string Name { get; set; }
        public int Armor { get; set; }
        private string Image;
        public void setItemImage(string filename) { Image = filename; }
        public string getItemImage() { return Image; }
    }
    class Helmet : Item
    {
        public Helmet(string name, int armor) { Name = name; Armor = armor; } // конструктор шлема
    }
    class Armour : Item
    { 
        public Armour(string name, int armor) { Name = name; Armor = armor; } // конструктор брони
    }
    class Weapon : Item
    {
        public int min_damage { get; set; }
        public int max_damage { get; set; }
        public double armor_coef { get; set; }
        public double HHitChance { get; set; }
        public Weapon(string name, int min, int max, double coef, double headChance) { Name = name; min_damage = min; max_damage = max; armor_coef = coef; HHitChance = headChance; } 
    }
    class OneWeapon : Weapon
    {
        public OneWeapon(string name, int min, int max, double coef, double headChance) : base(name, min, max, coef, headChance)
        { Name = name; min_damage = min; max_damage = max; armor_coef = coef; HHitChance = headChance; }
    }
    class TwoWeapon : Weapon
    { 
        /* наследование конструктора из Weapon */
        public TwoWeapon(string name, int min, int max, double coef, double headChance) : base(name, min, max, coef, headChance)
        { Name = name; min_damage = min; max_damage = max; armor_coef = coef; HHitChance = headChance;  }
    }
    class Shield : Item
    {
        public int m_def { get; set; }
        public Shield(string name, int mdef) { Name = name; m_def = mdef; }
    }
    //class Character
    //{
    //    private int m_skill;
    //    private int m_def;
    //    private int hp;
    //}
}

