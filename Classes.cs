using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ну_рванули
{
    class Helmet
    {
        public string h_name { get; set; }
        public int h_armor { get; set; }

        public Helmet(string name, int armor) { h_name = name; h_armor = armor; } // конструктор
        private string h_image;
        public void setHelmetImage(string filename) { h_image = filename; }
        public string getHelmetImage() { return h_image; }  
    }
    class Armour
    {
        public string b_name { get; set; }
        public int b_armor { get; set; }

        public Armour(string name, int armor) { b_name = name; b_armor = armor; } // конструктор
        private string b_image;
        public void setArmourImage(string filename) { b_image = filename; }
        public string getArmourImage() { return b_image; }
    }
    class Weapon
    {
        public string w_name;
        public int min_damage { get; set; }
        public int max_damage { get; set; }
        public double armor_coef { get; set; }
        private string w_image;
        public Weapon(string name, int min, int max, double coef) { w_name = name; min_damage = min; max_damage = max; armor_coef = coef; }
        public void setWeaponImage(string filename) { w_image = filename; }
        public string getWeaponImage() { return w_image; }
    }
    /*class DoubleWeapon : Weapon
    {
        private string w_image;
    }*/
    class Shield
    {
        private int m_def;

        private string s_image;
        public void setShieldImage(string filename) { s_image = filename; }
        public string getShieldImage() { return s_image; }
    }
    class Character
    {
        private int m_skill;
        private int m_def;
        private int hp;
    }
}

