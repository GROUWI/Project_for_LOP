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
    public partial class Form1 : Form
    {
         
    public Form1()
        {
            InitializeComponent();
            /* характеристики шлемов в лист, принимающих на вход тип Helmet
               с помощью конструктора записываем все шлема */
            List<Helmet> h_ch = new List<Helmet>
        {
            new Helmet ("empty", 0),
            new Helmet ("Hood", 30),
            new Helmet ("Aketon Cap", 60),
            new Helmet ("Duelist`s Hat", 70),
            new Helmet ("Mail Coif", 80),
            new Helmet ("Nasal Helmet", 105),
            new Helmet ("Sallet Helmet", 120),
            new Helmet ("Padded Nasal Helmet", 130),
            new Helmet ("Nasal Helmet with Rusty Mail", 140),
            new Helmet ("Closed Padded Flat Top Helmet", 180),
            new Helmet ("Nasal Helmet with Mail", 200),
            new Helmet ("Bascinet", 215),
            new Helmet ("Heavy Horned Helmet", 250),
            new Helmet ("Nordic Helmet with Closed Mail", 265),
            new Helmet ("Conic Helmet with Faceguard", 280),
            new Helmet ("Full Helm", 300),
           
        };
            /* задание картинок шлемам через цикл */
            string directoryPath = @"E:\Для VS\Ну рванули 1.2\Ну рванули\Helmets";
            /*существует ли директория?*/
            bool existsDir = Directory.Exists(directoryPath); 
            if (existsDir)
            {   /* создаем список всех этлементов в папке со шлемами */
                var pngs = Directory.EnumerateFiles(directoryPath, "*.png");
                int i = 1;
                foreach (var png in pngs)
                {
                    /* присвоение каждому шлему своей картинки через цикл */
                    h_ch[i].setHelmetImage(png);
                    i++;
                }
            }
                       
            /* записываем весь список в комбобокс
             * DisplayMember - отображение названия
             * ValueMember - запись значений брони в своё название */
            comboBoxHelmet.DataSource = h_ch;
            comboBoxHelmet.DisplayMember = "h_name";
            comboBoxHelmet.ValueMember = "h_armor";

            List<Armour> b_ch = new List<Armour>
        {
            new Armour ("empty", 0),
            new Armour ("Thick Tunic", 35),
            new Armour ("Padded Surcoat", 50),
            new Armour ("Gambeson", 65),
            new Armour ("Padded Leather", 80),
            new Armour ("Pathced Mail Shirt", 90),
            new Armour ("Basic Mail Shirt", 115),
            new Armour ("Mail Shirt", 130),
            new Armour ("Hauberk", 150),
            new Armour ("Footman`s Armor", 190),
            new Armour ("Reinforced Hauberk", 210),
            new Armour ("Lamellar Harness", 230),
            new Armour ("Barbarian Armor", 230),
            new Armour ("Scale Armor", 240),
            new Armour ("Sellsword`s Armor", 260),
            new Armour ("Heavy Lamellar Armor", 285),
            new Armour ("Coat of Scales", 300),
            new Armour ("Coat of Plates", 320),
        };
            
            directoryPath = @"E:\Для VS\Ну рванули 1.2\Ну рванули\Armour";
            existsDir = Directory.Exists(directoryPath);
            if (existsDir)
            {   
                var pngs = Directory.EnumerateFiles(directoryPath, "*.png");
                int i = 1;
                foreach (var png in pngs)
                {
                    
                    b_ch[i].setArmourImage(png);
                    i++;
                }
            }
            comboBoxArmour.DataSource = b_ch;
            comboBoxArmour.DisplayMember = "b_name";
            comboBoxArmour.ValueMember = "b_armor";

            List<Weapon> w_ch = new List<Weapon>
        {
            new Weapon ("empty", 0, 0, 0),
            new Weapon ("Dagger", 10, 20, 0.6),
            new Weapon ("Falchion", 20, 30, 0.8),
            new Weapon ("empty", 0, 0, 0),
            new Weapon ("empty", 0, 0, 0),
            new Weapon ("empty", 0, 0, 0),
            new Weapon ("empty", 0, 0, 0),
            new Weapon ("empty", 0, 0, 0),
            new Weapon ("empty", 0, 0, 0),
            new Weapon ("empty", 0, 0, 0),
            new Weapon ("empty", 0, 0, 0),
            new Weapon ("empty", 0, 0, 0),
            new Weapon ("empty", 0, 0, 0),
        };
            directoryPath = @"E:\Для VS\Ну рванули 1.2\Ну рванули\Weapons\OneHanded";
            existsDir = Directory.Exists(directoryPath);
            if (existsDir)
            {
                var pngs = Directory.EnumerateFiles(directoryPath, "*.png");
                int i = 1;
                foreach (var png in pngs)
                {

                    w_ch[i].setWeaponImage(png);
                    i++;
                }
            }
            comboBoxWeapon.DataSource = w_ch;
            comboBoxWeapon.DisplayMember = "w_name";
            comboBoxWeapon.ValueMember = "min_damage";
        }

        private void Form1_Load(object sender, EventArgs e)
        {   /* выводим информацию о броне первого шлема */
            TBHelmarmor.Text = comboBoxHelmet.SelectedValue.ToString();

            TBBodyarmor.Text = comboBoxArmour.SelectedValue.ToString();

            createchar.Enabled = false;
            comboBoxHelmet.Enabled = true;
            comboBoxArmour.Enabled = true;
            comboBoxWeapon.Enabled = true;
            comboBoxShield.Enabled = true;
            
        }
        
        private void comboBoxHelmet_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* выводим информацию о броне выбранного шлема */
            TBHelmarmor.Text = comboBoxHelmet.SelectedValue.ToString();
            /* создаем временную переменную chosen_helm типа Helmet, чтобы использовать
             * на ней функцию getHelmetImage() из класса*/
            Helmet chosen_helm = (Helmet)comboBoxHelmet.SelectedItem;
            /* выводим изображение выбранного элемента из перечня
             * заранее заданных*/
            if (comboBoxHelmet.SelectedText == "empty")
            {
                pictureHelmet.Visible = false;               
            }
            else
            {
                pictureHelmet.Visible = true;
                pictureHelmet.Image = Image.FromFile(chosen_helm.getHelmetImage());
            }     
        }
        private void comboBoxArmour_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBBodyarmor.Text = comboBoxArmour.SelectedValue.ToString();
            Armour chosen_arm = (Armour)comboBoxArmour.SelectedItem;
            if (comboBoxArmour.SelectedText == "empty")
                pictureArmour.Visible = false;
            pictureArmour.Visible = true;
            pictureArmour.Image = Image.FromFile(chosen_arm.getArmourImage());
        }
        private void comboBoxWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBWeapDamage.Text = comboBoxWeapon.SelectedValue.ToString();
            Weapon chosen_weap = (Weapon)comboBoxWeapon.SelectedItem;
            if (comboBoxWeapon.SelectedText == "empty")
                pictureWeapon.Visible = false;
            pictureWeapon.Visible = true;
            pictureWeapon.Image = Image.FromFile(chosen_weap.getWeaponImage());
        }
        
        private void comboBoxShield_SelectedIndexChanged(object sender, EventArgs e)
        {
            //////
        }
        private void confirmedbutt_Click(object sender, EventArgs e)
        {
            comboBoxHelmet.Enabled = false;
            comboBoxArmour.Enabled = false;
            comboBoxWeapon.Enabled = false;
            comboBoxShield.Enabled = false;
        }
        private void arena_Click(object sender, EventArgs e)
        {
            /* прячем окно создания перса */
            this.Hide();
            /* передаем данные в Форму2 */
            Form2 arena = new Form2();
            arena.helm_armor = TBHelmarmor.Text;
            //////
            arena.helm_image = pictureHelmet.ImageLocation;

            arena.Show();  
        }
        private void name_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
