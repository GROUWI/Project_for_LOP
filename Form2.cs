using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ну_рванули
{
    public partial class Form2 : Form
    {
        public string ImageItemEnemy (int N, string directoryPath)
        {   

            Random h_armorenemy = new Random();
            string[] ways = new string[N];
            int i = 1;
            var pngshelm = Directory.EnumerateFiles(directoryPath, "*.png");
            foreach (var png in pngshelm)
            {
                ways[i-1] = png;
                i++;
            }
            return ways[h_armorenemy.Next(1, N)];
            
        }
        public int tempHP;
        public string strtempHP;
        /* переменные для обмена данными между Form1 и Form2 */
        public string helm_armor;
        public string helm_image;
        public int inthelm_armor;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /* переносим все показатели на арену */
            TBHelmarmor.Text = helm_armor;

            /* переносим фото */
            pictureHelmet.Image = Image.FromFile(helm_image);
        }
        private void choose_Click_1(object sender, EventArgs e)
        {
            /* рандомайзер для картинок шлема */
            pictureHelmetenemy.Image = Image.FromFile(ImageItemEnemy(16, @"E:\Для VS\Ну рванули 1.3\Helmets"));
            pictureArmourenemy.Image = Image.FromFile(ImageItemEnemy(18, @"E:\Для VS\Ну рванули 1.3\Armour"));
         //   pictureShieldenemy.Image = Image.FromFile(ImageItemEnemy(16, @"E:\Для VS\Ну рванули 1.3\Shields"));
            pictureWeaponenemy.Image = Image.FromFile(ImageItemEnemy(13, @"E:\Для VS\Ну рванули 1.3\Weapons\OneHanded"));

            //TBHelmarmorenemy.Text = h_armorenemy.Next(30, 250).ToString();
            //Random b_armorenemy = new Random();
            //TBBodyarmorenemy.Text = b_armorenemy.Next(35, 300).ToString();
            //Random mskill = new Random();
            //TBMSkillenemy.Text = mskill.Next(30, 100).ToString();
            //Random mdef = new Random();
            //TBMDefenemy.Text = mdef.Next(0, 70).ToString();
            //strtempHP = "100";
            //TBHealthenemy.Text = strtempHP + "/100";
            //Weapon(tempMin, tempMax)
            //TBWeapDamage.Text = strtempHP + "/100";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}


/*
    
// Минимальный процент попадания = 5;
// Максимальный процент попадания = 95;


// Формула формального попадания по врагу
    int Hitchance;
    if (MSkill - Mdef < 0){
        Hitchance = 5;
    }
    else
    {
        Hitchance = 5 + ((MSkill - MDef) / MSkill)*90;
    }

// Шанс попадания в голову
    int HeadHitChance = 25;    

// Функция рандом, значения от 0 до 1
    class rnd
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] rndArray = new int[3];
            for (int i = 0; i < 3; i++)
            {
                rndArray[i] = rand.NextDouble(0, 1);
            } 
        }
    }
    
// Формула подсчета урона у оружия
    Damage = MinDamgae + rndArray[0]*(MaxDamage - MinDamage);   //Damage как чистый урон оружия без коэфов


// Подсчет места попадания во врага (1 - попал, 0 - промазал)
    if (HitChance < rndArray[]*100)
    {
        BodyHit = 1;
        if (rndArray[1]*100) < 25
        {
            HeadHit = 1;
            BodyHit = 0;
        }
        else
        {
            HeadHit = 0;
        }
    }
    else
    {
        BodyHit = 0;
    }


    int TempArmor = Armor; //В самом начале боя
    int TempHealth=Health; //В самом начале боя
    int ArmorBorder = 75; //Граничное значение брони ниже которого начнется сниматься хп
// Формула фактического попадания по врагу с random и уроном по броне и хп
    
    {
    if (TempArmor >= Damage*armor_coef)
    {
        TempArmor = TempArmor - Damage*armor_coef;
        if (TempArmor <= ArmorBorder)
        {
            TempHealth = TempHealth - Damage*(1 - (TempArmor / Armor Border));
        }
    }
    else
    {
        TempArmor = 0;
        if (TempArmor >= ArmorBorder)
        {
            TempHealth = TempHealth - Damage;
        }
    }



 */