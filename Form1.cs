using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            /* задаем изображения для каждого шлема */
           /* h_ch[0].setHelmetImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Helmets\Helmets_Hood.png");
            h_ch[1].setHelmetImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Helmets\Helmets_AketonCap.png");
            h_ch[2].setHelmetImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Helmets\Helmets_DuelistHat.png");
            h_ch[3].setHelmetImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Helmets\Helmets_MailCoif.png");
            h_ch[4].setHelmetImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Helmets\Helmets_NasalHelmet.png");
            h_ch[5].setHelmetImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Helmets\Helmets_SalletHelm.png");
            h_ch[6].setHelmetImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Helmets\Helmets_PaddedNasalHelm.png");
            h_ch[7].setHelmetImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Helmets\Helmets_NasalHelmRustMail.png");
            h_ch[8].setHelmetImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Helmets\Helmets_ClosedPaddedFlatTop.png");
            h_ch[9].setHelmetImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Helmets\Helmets_NasalHelmMail.png");
            h_ch[10].setHelmetImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Helmets\Helmets_BascinetMail.png");
            h_ch[11].setHelmetImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Helmets\Helmets_HeavyHornedPlateHelm.png");
            h_ch[12].setHelmetImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Helmets\Helmets_NordicHelmClosedMail.png");
            h_ch[13].setHelmetImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Helmets\Helmets_ConicHelmFaceguard.png");
            h_ch[14].setHelmetImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Helmets\Helmets_FullHelm.png");*/
            /* записываем весь список в комбобокс
             * DisplayMember - отображение названия
             * ValueMember - запись значений брони в своё название */
            comboBoxHelmet.DataSource = h_ch;
            comboBoxHelmet.DisplayMember = "h_name";
            comboBoxHelmet.ValueMember = "h_armor";

            List<Armour> b_ch = new List<Armour>
        {
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
           /* b_ch[0].setArmourImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Armour\BodyArmor_ThickTunic.png");
            b_ch[1].setArmourImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Armour\BodyArmor_PaddedSurcoat.png");
            b_ch[2].setArmourImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Armour\BodyArmor_Gambeson.png");
            b_ch[3].setArmourImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Armour\BodyArmor_PaddedLeather.png");
            b_ch[4].setArmourImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Armour\BodyArmor_PatchedMailShirt.png");
            b_ch[5].setArmourImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Armour\BodyArmor_BasicMailShirt.png");
            b_ch[6].setArmourImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Armour\BodyArmor_MailShirt.png");
            b_ch[7].setArmourImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Armour\BodyArmor_Hauberk.png");
            b_ch[8].setArmourImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Armour\BodyArmor_Footman.png");
            b_ch[9].setArmourImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Armour\BodyArmor_ReinforcedHauberk.png");
            b_ch[10].setArmourImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Armour\BodyArmor_Lamellar.png");
            b_ch[11].setArmourImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Armour\BodyArmor_Barbarian.png");
            b_ch[12].setArmourImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Armour\BodyArmor_ScaleArmor.png");
            b_ch[13].setArmourImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Armour\BodyArmor_Sellsword.png");
            b_ch[14].setArmourImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Armour\BodyArmor_HeavyLamellar.png");
            b_ch[15].setArmourImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Armour\BodyArmor_CoatOfScales.png");
            b_ch[16].setArmourImage(@"E:\Для visual studio\Ну рванули\Ну рванули\Armour\BodyArmor_CoatOfPlates.png");*/
            comboBoxArmour.DataSource = b_ch;
            comboBoxArmour.DisplayMember = "b_name";
            comboBoxArmour.ValueMember = "b_armor";
        }
        private void Form1_Load(object sender, EventArgs e)
        {   /* выводим информацию о броне первого шлема */
            textBoxSmallHelm.Text = comboBoxHelmet.SelectedValue.ToString();

            textBoxSmallArmour.Text = comboBoxArmour.SelectedValue.ToString();

            createchar.Enabled = false;
            comboBoxHelmet.Enabled = true;
            comboBoxArmour.Enabled = true;
            comboBoxWeapon.Enabled = true;
            comboBoxShield.Enabled = true;
        }
        
        private void comboBoxHelmet_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* выводим информацию о броне выбранного шлема */
            textBoxSmallHelm.Text = comboBoxHelmet.SelectedValue.ToString();
            /* создаем временную переменную chosen_helm типа Helmet, чтобы использовать
             * на ней функцию getHelmetImage() из класса*/
            Helmet chosen_helm = (Helmet)comboBoxHelmet.SelectedItem;
            /* выводим изображение выбранного элемента из перечня
             * заранее заданных*/
            //pictureHelmet.Image = Image.FromFile(chosen_helm.getHelmetImage());
        }
        private void comboBoxArmour_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSmallArmour.Text = comboBoxArmour.SelectedValue.ToString();
            Armour chosen_arm = (Armour)comboBoxArmour.SelectedItem;
            //pictureArmour.Image = Image.FromFile(chosen_arm.getArmourImage());
        }
        private void comboBoxWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            /////
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
            arena.helm_armor = textBoxSmallHelm.Text;
            //////
            arena.helm_image = pictureHelmet.ImageLocation;

            arena.Show();  
        }
        
    }
}
