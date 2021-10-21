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
        int[] MyTurn(int m_skill, int min_damage, int max_damage, double armor_coef,
            int helm_armorEnemy, int body_armorEnemy, int hpEnemy, int m_defEnemy, int ArmorBorder)
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
            bool BodyHit;
            bool HeadHit;
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
            {
                HeadHit = false;
                BodyHit = false;
            }
            
                
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
                    double Totaldamage = 1.5 * Damage * (1 - (helm_armorEnemy / ArmorBorder));
                    hpEnemy = Convert.ToInt32(hpEnemy - Totaldamage);
                    
                    
                }

            }
            else
            {
                /* если броня шлема врага меньше чем урон оружия * коэф по броне
                 * то броня игнорируется*/
                helm_armorEnemy = 0;
                hpEnemy = Convert.ToInt32(hpEnemy - Damage);    
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
            bool BodyHit;
            bool HeadHit;
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
            {
                BodyHit = false;
                HeadHit = false;
            }
                
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
            Thread.Sleep(1000);
            int[] returnesfunc = new int[3];
            returnesfunc[0] = helm_armor;
            returnesfunc[1] = body_armor;
            returnesfunc[2] = hp;
            return returnesfunc;
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

        /* массивы для битвы и очередности ходов */
        public int[] returnesEnemy = new int[3];
        public int[] returnes = new int[3];
        /* начальные значения брони */
        public string beginHelmarmor;
        public string beginBodyarmor;
        public string beginHelmarmorEnemy;
        public string beginBodyarmorEnemy;

        public bool flag = true;
        public bool myturn = true;

        int[] fight = new int[7];
        int[] fightEnemy = new int[7];
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
            fightbutt.Enabled = false;
            btnNextTurn.Enabled = false;
            // не работает
            pictureHelmet.Image = Image.FromFile(image_form2[0]);
            pictureArmour.Image = Image.FromFile(image_form2[1]);
            pictureWeapon.Image = Image.FromFile(image_form2[2]);
            pictureShield.Image = Image.FromFile(image_form2[3]);

            
        }
        private void choose_Click_1(object sender, EventArgs e)
        {
            
            fightbutt.Enabled = true;
            TBHelmarmor.Text = text[0];
            TBBodyarmor.Text = text[1];
            TBHealth.Text = text[2];
            TBMSkill.Text = text[3];
            TBMDef.Text = text[4];
            TBWeapDamage.Text = text[5];
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
        private void fightbutt_Click_1(object sender, EventArgs e)
        {
            btnNextTurn.Enabled = true;
            fightbutt.Enabled = false;
            choose.Enabled = false;
            fight[0] = value[0];
            fight[1] = value[1];
            fight[2] = value[2];
            fight[3] = value[3];
            fight[4] = value[4];
            fight[5] = value[5];
            fight[6] = value[6];
            fightEnemy[0] = valueEnemy[0];
            fightEnemy[1] = valueEnemy[1];
            fightEnemy[2] = valueEnemy[2];
            fightEnemy[3] = valueEnemy[3];
            fightEnemy[4] = valueEnemy[4];
            fightEnemy[5] = valueEnemy[5];
            fightEnemy[6] = valueEnemy[6];
            beginHelmarmor = TBHelmarmor.Text;
            beginBodyarmor = TBBodyarmor.Text;

            beginHelmarmorEnemy = TBHelmarmorEnemy.Text;
            beginBodyarmorEnemy = TBBodyarmorEnemy.Text;

            TBHelmarmor.Text = beginHelmarmor + "/" + beginHelmarmor;
            TBBodyarmor.Text = beginBodyarmor + "/" + beginBodyarmor;
            TBHealth.Text = value[2].ToString() + "/100";

            TBHelmarmorEnemy.Text = beginHelmarmorEnemy + "/" + beginHelmarmorEnemy;
            TBBodyarmorEnemy.Text = beginBodyarmorEnemy + "/" + beginBodyarmorEnemy;
            TBHealthEnemy.Text = valueEnemy[2].ToString() + "/100";


        }

        private void btnNextTurn_Click(object sender, EventArgs e)
        {
          
            if (myturn == true & fightEnemy[2] > 0) // хп врага
            {
                
                returnesEnemy = MyTurn(fight[3], fight[5], fight[6], armor_coef,
                fightEnemy[0], fightEnemy[1], fightEnemy[2], fightEnemy[4], 75);
                fightEnemy[0] = returnesEnemy[0];
                fightEnemy[1] = returnesEnemy[1];
                fightEnemy[2] = returnesEnemy[2];
                log.Text = "урон по врагу - " + (100 - fightEnemy[2]).ToString();
                TBHelmarmorEnemy.Text = fightEnemy[0].ToString() + "/" + beginHelmarmorEnemy;
                TBBodyarmorEnemy.Text = fightEnemy[1].ToString() + "/" + beginBodyarmorEnemy;
                TBHealthEnemy.Text = fightEnemy[2].ToString() + "/100";
            }
            if (fightEnemy[2] <= 0)
            {
                TBHealthEnemy.Text = "0/100";
                MessageBox.Show("Вы выиграли!");
                btnNextTurn.Enabled = false;
                choose.Enabled = true;
            }
            if (myturn == false & fight[2] > 0) // хп наше
            {
                
                returnes = EnemyTurn(fight[0], fight[1], fight[2], fight[4], fightEnemy[3],
                fightEnemy[5], fightEnemy[6], armor_coefEnemy, 75);
                fight[0] = returnes[0];
                fight[1] = returnes[1];
                fight[2] = returnes[2];
                log.Text = "урон по нам - " + (100 - fight[2]).ToString();
                TBHelmarmor.Text = fight[0].ToString() + "/" + beginHelmarmor;
                TBBodyarmor.Text = fight[1].ToString() + "/" + beginBodyarmor;
                TBHealth.Text = fight[2].ToString() + "/100";
            }
            if (fight[2] <= 0)
            {
                TBHealth.Text = "0/100";
                MessageBox.Show("Вы проиграли!");
                btnNextTurn.Enabled = false;
                choose.Enabled = true;
            }
            myturn = !myturn;
        }
    }
}