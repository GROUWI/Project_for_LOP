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
        private int min_damage;
        private int max_damage;
        private float armor_coef;
        private string w_image;

        public void setWeaponImage(string filename) { w_image = filename; }
        public string getWeaponImage() { return w_image; }
    }
    class DoubleWeapon : Weapon
    {
        private string w_image;
    }
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

