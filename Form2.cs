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
using System.Threading;

namespace Ну_рванули
{
    public partial class Form2 : Form
    {
        int[] MyTurn( int m_skill, int min_damage, int max_damage, double armor_coef,
            int helm_armorEnemy, int body_armorEnemy, int hpEnemy, int m_defEnemy,  int ArmorBorder)
        {
            int Hitchance;
            /* НАШ ХОД */
            // Функция рандом, значения от 0 до 1
            double[] rndArray = new double[3];
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                rndArray[i] = rand.NextDouble();
            }
            /* проверка шанса попадания */
            if (m_skill - m_defEnemy < 0)
            {
                Hitchance = 5;
            }
            else
            {
                Hitchance = 5 + 90 * (m_skill - m_defEnemy) / m_skill;
            }
            // Формула подсчета урона у оружия
            //Damage как чистый урон оружия без коэфов
            int Damage = Convert.ToInt32(min_damage + rndArray[0] * (max_damage - min_damage));
            // Подсчет места попадания во врага (1 - попал, 0 - промазал)
            bool BodyHit = false;
            bool HeadHit = false;
            if (Hitchance > rndArray[0] * 100)
            {
                BodyHit = true;
                if ((rndArray[1] * 100) < 25)
                {
                    HeadHit = true;
                    BodyHit = false;
                }
                else
                    HeadHit = false;
            }
            else
                BodyHit = false;
                BodyHit = false;
            // Формула фактического попадания по врагу с random и уроном по броне и хп
            /* для шлема */
            if (helm_armorEnemy >= Convert.ToInt32(Damage * armor_coef))
            {
                /* если броня шлема врага больше чем урон оружия * коэф по броне
                 * то идет урон по броне шлема по данной формуле*/
                helm_armorEnemy = Convert.ToInt32(helm_armorEnemy - Damage * armor_coef);

                if ((helm_armorEnemy <= ArmorBorder) & (HeadHit == true))
                {
                    /* если броня шлема врага меньше чем граничное значение
                    * то идет урон по ХП по данной формуле*/
                    hpEnemy = Convert.ToInt32(hpEnemy - 1.5 * Damage * (1 - (helm_armorEnemy / ArmorBorder)));
                }

            }
            else
            {
                /* если броня шлема врага меньше чем урон оружия * коэф по броне
                 * то броня игнорируется*/
                helm_armorEnemy = 0;
                hpEnemy = Convert.ToInt32(hpEnemy - Damage * (1 - (helm_armorEnemy / ArmorBorder)));
            }

            /* для доспеха аналогично, как и для шлема */
            if (body_armorEnemy >= Damage * armor_coef)
            {
                body_armorEnemy = Convert.ToInt32(body_armorEnemy - Damage * armor_coef);

                if ((body_armorEnemy <= ArmorBorder) & (BodyHit == true))
                {
                    hpEnemy = Convert.ToInt32(hpEnemy - Damage * (1 - (body_armorEnemy / ArmorBorder)));
                }
            }
            else
            {
                body_armorEnemy = 0;
                hpEnemy = Convert.ToInt32(hpEnemy - Damage * (1 - (body_armorEnemy / ArmorBorder)));
            }

            TBHealthEnemy.Text = hpEnemy.ToString() + "/100";
            Thread.Sleep(1000);
            int[] returnesfuncEnemy = new int[3];
            returnesfuncEnemy[0] = helm_armorEnemy;
            returnesfuncEnemy[1] = body_armorEnemy;
            returnesfuncEnemy[2] = hpEnemy;
            return returnesfuncEnemy;
            
        }
        int[] EnemyTurn(int helm_armor, int body_armor, int hp, int m_def, int m_skillEnemy,
            int min_damageEnemy, int max_damageEnemy, double armor_coefEnemy, int ArmorBorder)
        {
            int Hitchance;
            /* ХОД ПРОТИВНИКА */
            // Функция рандом, значения от 0 до 1
            double[] rndArray = new double[3];
            Random rand = new Random();
            armor_coefEnemy = rand.NextDouble();
            for (int i = 0; i < 3; i++)
            {
                rndArray[i] = rand.NextDouble();
            }
            /* проверка шанса попадания */
            if (m_skillEnemy - m_def < 0)
            {
                Hitchance = 5;
            }
            else
            {
                Hitchance = 5 + 90 * (m_skillEnemy - m_def) / m_skillEnemy;
            }
            // Формула подсчета урона у оружия
            //Damage как чистый урон оружия без коэфов
            int Damage = Convert.ToInt32(min_damageEnemy + rndArray[0] * (max_damageEnemy - min_damageEnemy));
            // Подсчет места попадания в нас (1 - попал, 0 - промазал)
            bool BodyHit = false;
            bool HeadHit = false;
            if (Hitchance < rndArray[0] * 100)
            {
                BodyHit = true;
                if ((rndArray[1] * 100) < 25)
                {
                    HeadHit = true;
                    BodyHit = false;
                }
                else
                    HeadHit = false;
            }
            else
                BodyHit = false;
                HeadHit = false;
            // Формула фактического попадания по нам с random и уроном по броне и хп
            /* для шлема */
            if (helm_armor >= Convert.ToInt32(Damage * armor_coefEnemy))
            {
                /* если броня шлема наща больше чем урон оружия * коэф по броне
                 * то идет урон по броне шлема по данной формуле*/
                helm_armor = Convert.ToInt32(helm_armor - Damage * armor_coefEnemy);

                if ((helm_armor <= ArmorBorder) & (HeadHit == true))
                {
                    /* если броня шлема наша меньше чем граничное значение
                    * то идет урон по ХП по данной формуле*/
                    hp = Convert.ToInt32(hp - 1.5 * Damage * (1 - (helm_armor / ArmorBorder)));
                    
                }

            }
            else
            {
                /* если броня шлема наша меньше чем урон оружия * коэф по броне
                 * то броня игнорируется*/
                helm_armor = 0;
                hp = Convert.ToInt32(hp - Damage * (1 - (helm_armor / ArmorBorder)));
            }

            /* для доспеха аналогично, как и для шлема */
            if (body_armor >= Damage * armor_coefEnemy)
            {
                body_armor = Convert.ToInt32(body_armor - Damage * armor_coefEnemy);

                if ((body_armor <= ArmorBorder) & (BodyHit == true))
                {
                    hp = Convert.ToInt32(hp - Damage * (1 - (body_armor / ArmorBorder)));
                }
            }
            else
            {
                body_armor = 0;
                hp = Convert.ToInt32(hp - Damage * (1 - (body_armor / ArmorBorder)));
            }
            TBHealth.Text = hp.ToString() + "/100";
            Thread.Sleep(1000);
            int[] returnesfunc = new int[3]; 
            returnesfunc[0] = helm_armor;
            returnesfunc[1] = body_armor;
            returnesfunc[2] = hp;
            return returnesfunc;
        }

    

    // Минимальный процент попадания = 5;
    // Максимальный процент попадания = 95;
    public void Fight()
        {
            int[] storage = new int[3];
            storage[0] = value[0];
            storage[1] = value[1];
            storage[2] = value[2];
            int[] storageEnemy = new int[3];
            storageEnemy[0] = valueEnemy[0];
            storageEnemy[1] = valueEnemy[1];
            storageEnemy[2] = valueEnemy[2];
            int[] returnes = new int[3];
            int[] returnesEnemy = new int[3];
            int hp = storage[2];
            int hpEnemy = storageEnemy[2];
            /* деремся пока живы */
            while (hp >= 0 || hpEnemy >= 0)
            {
                returnesEnemy = MyTurn(value[3], value[5], value[6], armor_coef,
            storageEnemy[0], storageEnemy[1], hpEnemy, valueEnemy[4], 75);
                storageEnemy[0] = returnesEnemy[0];
                storageEnemy[1] = returnesEnemy[1];
                hpEnemy = returnesEnemy[2];
                
                if (hpEnemy <= 0)
                {
                    TBHealthEnemy.Text = "0/100";
                    MessageBox.Show("вы выиграли");
                    break;
                }
                
                    
                
                returnes = EnemyTurn(storage[0], storage[1], hp, value[4], valueEnemy[3],
             valueEnemy[5], valueEnemy[6], armor_coefEnemy, 75);
                storage[0] = returnes[0];
                storage[1] = returnes[1];
                hp = returnes[2];
                
                if (hp <= 0)
                {
                    TBHealth.Text = "0/100";
                    MessageBox.Show("вы проиграли");
                    break;
                }
            }
        }

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
        /* переменные для обмена данными между Form1 и Form2 */
        Random ItemEnemy = new Random();
        public string[] text = new string[6];
        public int[] value = new int[7];
        public int[] valueEnemy = new int[7];
        public string[] image_form2 = new string[4];
        public string name_v;
        public double armor_coef;
        public double armor_coefEnemy;
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
            valueEnemy[0] = ItemEnemy.Next(30, 300); // helm  armour enemy
            valueEnemy[1] = ItemEnemy.Next(valueEnemy[0]-20, valueEnemy[0]+50); // body armour enemy 
            valueEnemy[2] = 100;    // health enemy
            valueEnemy[3] = ItemEnemy.Next(40, 70); // melee skill enemy
            valueEnemy[4] = ItemEnemy.Next(10, 50); // melee def enemy
            valueEnemy[5] = ItemEnemy.Next(10, 60);// min damage enemy
            valueEnemy[6] = ItemEnemy.Next(valueEnemy[5]+10, valueEnemy[5]+25);// max damage enemy
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
        private void fightbutt_Click_1(object sender, EventArgs e)
        {
            Fight();
            TBHealth.Text = "100/100";
        }
    }
}