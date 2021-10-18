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
			string directoryPath = @"E:\Для VS\Ну рванули 1.3\Helmets";
			/*существует ли директория?*/
			bool existsDir = Directory.Exists(directoryPath); 
			if (existsDir)
			{   /* создаем список всех этлементов в папке со шлемами */
				var pngs = Directory.EnumerateFiles(directoryPath, "*.png");
				int i = 0;
				foreach (var png in pngs)
				{
					/* присвоение каждому шлему своей картинки через цикл */
					h_ch[i].setItemImage(png);
					i++;
				}
			}
					   
			/* записываем весь список в комбобокс
			 * DisplayMember - отображение названия
			 * ValueMember - запись значений брони в своё название */
			comboBoxHelmet.DataSource = h_ch;
			comboBoxHelmet.DisplayMember = "Name";
			comboBoxHelmet.ValueMember = "Armor";

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
			
			directoryPath = @"E:\Для VS\Ну рванули 1.3\Armour";
			existsDir = Directory.Exists(directoryPath);
			if (existsDir)
			{   
				var pngs = Directory.EnumerateFiles(directoryPath, "*.png");
				int i = 0;
				foreach (var png in pngs)
				{
					
					b_ch[i].setItemImage(png);
					i++;
				}
			}
			comboBoxArmour.DataSource = b_ch;
			comboBoxArmour.DisplayMember = "Name";
			comboBoxArmour.ValueMember = "Armor";

			List<Weapon> w_ch = new List<Weapon>
			{
				new Weapon ("empty", 5, 10, 0, 0),
				new Weapon ("Dagger", 15, 35, 0.6, 0),
				new Weapon ("Falchion", 35, 45, 0.7, 0),
				new Weapon ("Arming Sword", 40, 45, 0.8, 0),
				new Weapon ("Morning Star", 30, 45, 1, 0),
				new Weapon ("Winged Mace", 35, 55, 1.1, 0),
				new Weapon ("Boar Spear", 30, 35, 0.95, 0),
				new Weapon ("Handaxe", 30, 45, 1.2, 0),
				new Weapon ("Fighting Axe", 35, 55, 1.3, 0),
				new Weapon ("Flail", 25, 55, 1, 0.1),
				new Weapon ("Scramasax", 30, 45, 0.8, 0),
				new Weapon ("Military Cleaver", 40, 60, 0.9, 0),
				new Weapon ("Warhammer", 30, 40, 2.25, 0),

				new TwoWeapon ("Longsword", 65, 85, 1, 0.05),
				new TwoWeapon ("Zweihander", 85, 100, 1, 0.05),
				new TwoWeapon ("Two-Handed Flanged Mace", 75, 95, 1.25, 0),
				new TwoWeapon ("Woodcutter`s Axe", 35, 70, 1.25, 0),
				new TwoWeapon ("Bardiche", 75, 95, 1.3, 0.05),
				new TwoWeapon ("Greataxe", 80, 100, 1.5, 0),
				new TwoWeapon ("Two-Handed Flail", 40, 80, 1.1, 0.15),
				new TwoWeapon ("Two-Handed", 60, 90, 2.0, 0),
				new TwoWeapon ("Pike", 60, 80, 1, 0.05),
				new TwoWeapon ("Billhook", 55, 85, 1.4, 0.05),
			};
			directoryPath = @"E:\Для VS\Ну рванули 1.3\Weapons";
			existsDir = Directory.Exists(directoryPath);
			if (existsDir)
			{
				var pngs = Directory.EnumerateFiles(directoryPath, "*.png", SearchOption.AllDirectories);
				int i = 0;
				foreach (var png in pngs)
				{

					w_ch[i].setItemImage(png);
					i++;
				}
			}
			comboBoxWeapon.DataSource = w_ch;
			comboBoxWeapon.DisplayMember = "Name";
			comboBoxWeapon.ValueMember = "min_damage";
		

			List<Shield> sh_ch = new List<Shield>
			{
				new Shield ("empty", 0),
				new Shield ("Buckler", 65),
				new Shield ("HeaterShield", 85),
				new Shield ("KiteShield", 100),
				new Shield ("WoodenShield", 50),
			};

				directoryPath = @"E:\Для VS\Ну рванули 1.3\Shields";
				existsDir = Directory.Exists(directoryPath);
				if (existsDir)
				{
					var pngs = Directory.EnumerateFiles(directoryPath, "*.png");
					int i = 0;
					foreach (var png in pngs)
					{

						sh_ch[i].setItemImage(png);
						i++;
					}
				}
			comboBoxShield.DataSource = sh_ch;
			comboBoxShield.DisplayMember = "Name";
			comboBoxShield.ValueMember = "m_def";


				
		}
		private void Form1_Load(object sender, EventArgs e)
		{   /* выводим информацию о броне первого шлема */
			TBHelmarmor.Text = comboBoxHelmet.SelectedValue.ToString();

			TBBodyarmor.Text = comboBoxArmour.SelectedValue.ToString();
			TBWeapDamage.Text = comboBoxWeapon.SelectedValue.ToString() +
			"--" + "10";
			TBMDef.Text = comboBoxShield.SelectedValue.ToString();
			TBHealth.Text = "100/100";

			confirmedbutt.Enabled = false;
			createchar.Enabled = false;
			arena.Enabled = false;


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
			Helmet chosen = (Helmet)comboBoxHelmet.SelectedItem;
			/* выводим изображение выбранного элемента из перечня
				* заранее заданных*/                 
			pictureHelmet.Image = Image.FromFile(chosen.getItemImage());     
		}
		private void comboBoxArmour_SelectedIndexChanged(object sender, EventArgs e)
		{
			TBBodyarmor.Text = comboBoxArmour.SelectedValue.ToString();
			Armour chosen = (Armour)comboBoxArmour.SelectedItem;
			pictureArmour.Image = Image.FromFile(chosen.getItemImage());
		}
		private void comboBoxWeapon_SelectedIndexChanged(object sender, EventArgs e)
		{
			string mindamage = comboBoxWeapon.SelectedValue.ToString();
			Weapon chosen = (Weapon)comboBoxWeapon.SelectedItem;
			// не знаю как разделить оружие на двойное и одиночное
			/* формируем нормальную запись дамага вытягивая max damage*/
			TBWeapDamage.Text = mindamage + "--" + chosen.max_damage.ToString();
			pictureWeapon.Image = Image.FromFile(chosen.getItemImage());
			if (chosen != (Weapon)comboBoxWeapon.SelectedItem)
            {
				comboBoxShield.Enabled = false;
			}
			//else if (chosen == (TwoWeapon)comboBoxWeapon.SelectedItem)
   //         {
			//	comboBoxShield.Enabled = false;
			//}
		}

		private void comboBoxShield_SelectedIndexChanged(object sender, EventArgs e)
		{
			TBMDef.Text = comboBoxShield.SelectedValue.ToString();
			Shield chosen = (Shield)comboBoxShield.SelectedItem;
			pictureShield.Image = Image.FromFile(chosen.getItemImage());
		}
		private void confirmedbutt_Click(object sender, EventArgs e)
		{
			comboBoxHelmet.Enabled = false;
			comboBoxArmour.Enabled = false;
			comboBoxWeapon.Enabled = false;
			comboBoxShield.Enabled = false;
			arena.Enabled = true;
			confirmedbutt.Enabled = false;
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
			arena.inthelm_armor = Convert.ToInt32(comboBoxHelmet.SelectedValue);
			arena.Show();  
		}
		private void name_TextChanged(object sender, EventArgs e)
		{
			if (name.Text == "")
				confirmedbutt.Enabled = false;
			else
				confirmedbutt.Enabled = true;
		}
	}
}