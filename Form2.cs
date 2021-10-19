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
        public string ImageItemEnemy(int N, string directoryPath)
        {

            Random randomImage = new Random();
            string[] ways = new string[N];
            int i = 1;
            var pngshelm = Directory.EnumerateFiles(directoryPath, "*.png");
            foreach (var png in pngshelm)
            {
                ways[i - 1] = png;
                i++;
            }
            return ways[randomImage.Next(1, N)];

        }
        public int tempHP;
        public string strtempHP;
        /* переменные для обмена данными между Form1 и Form2 */
        public string[] text = new string[6];
        public int[] value = new int[7];
        public int[] valueEnemy = new int[7];
        public string[] image_form2 = new string[4];
        public string name_v;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /* переносим все показатели на арену */
            TBHelmarmor.Text = text[0];
            TBBodyarmor.Text = text[1];
            TBHealth.Text = text[2];
            TBMSkill.Text = text[3];
            TBMDef.Text = text[4];
            TBWeapDamage.Text = text[5];
            /* переносим фото */
            arena.Enabled = false;
            name.Text = name_v;
            // не работает
            pictureHelmet.Image = Image.FromFile(image_form2[0]);
            pictureArmour.Image = Image.FromFile(image_form2[1]);
            pictureWeapon.Image = Image.FromFile(image_form2[2]);
            pictureShield.Image = Image.FromFile(image_form2[3]);


        }
        private void choose_Click_1(object sender, EventArgs e)
        {
            /* рандомайзер для картинок амуниции */
            pictureHelmetenemy.Image = Image.FromFile(ImageItemEnemy(16, @"E:\Для VS\Ну рванули 1.3\Helmets"));
            pictureArmourenemy.Image = Image.FromFile(ImageItemEnemy(18, @"E:\Для VS\Ну рванули 1.3\Armour"));
            pictureShieldenemy.Image = Image.FromFile(ImageItemEnemy(5, @"E:\Для VS\Ну рванули 1.3\Shields"));
            pictureWeaponenemy.Image = Image.FromFile(ImageItemEnemy(13, @"E:\Для VS\Ну рванули 1.3\Weapons\OneHanded"));
            /* задаем параметры противника */
            Random ItemEnemy = new Random();
            valueEnemy[0] = ItemEnemy.Next(30, 250); // helm  armour enemy
            valueEnemy[1] = ItemEnemy.Next(40, 300); // body armour enemy 
            valueEnemy[2] = 100;    // health enemy
            valueEnemy[3] = ItemEnemy.Next(30, 100); // melle skill enemy
            valueEnemy[4] = ItemEnemy.Next(40, 70); // melle def enemy
            valueEnemy[5] = ItemEnemy.Next(10, 80);// min damage enemy
            valueEnemy[6] = ItemEnemy.Next(30, 110);// max damage enemy
            /* выводим их на экран */
            TBHelmarmorEnemy.Text = valueEnemy[0].ToString();
            TBBodyarmorEnemy.Text = valueEnemy[1].ToString();
            TBHealthEnemy.Text = valueEnemy[2].ToString() + "/100";
            TBMSkillEnemy.Text = valueEnemy[3].ToString();
            TBMDefEnemy.Text = valueEnemy[4].ToString();
            TBWeapDamageEnemy.Text = valueEnemy[5].ToString() + "--" + valueEnemy[6].ToString();

        }
        private void createchar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 createchar = new Form1();
            createchar.name_v = name_v;
            createchar.Show();
        }

        private void name_Click(object sender, EventArgs e)
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
        if (TempArmor <= ArmorBorder) and (HeadHit = 1)
        {
            TempHealth = TempHealth - 1,5*Damage*(1 - (TempArmor / Armor Border));
        }
        else
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






    public class Example
    {
        private static System.Timers.Timer aTimer;
   
        public static void Main()
        {
            SetTimer();

            Console.WriteLine("Бой начался в {0:HH:mm:ss.fff}", DateTime.Now);
            Console.ReadLine();
            aTimer.Stop();
            aTimer.Dispose();
      
        if (health <= 0)
        {
            DamageLogs.WriteLine("Вы проиграли. Бой закончен");
        }
        if (healthenemy <= 0)
        {
            DamageLogs.WriteLine("Вы выиграли. Бой закончен");
        }

        private static void SetTimer()
        {
            // Таймер на 2.5 секунды.
            aTimer = new System.Timers.Timer(2500);
            // Функции на таймер
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                          e.SignalTime);
        }
    }  
  
 
















 *\