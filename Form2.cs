﻿using System;
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
        public int tempHP;
        public string strtempHP;
        /* переменная для обмена данными между Form1 и Form2 */
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
            Random h_armorenemy = new Random();
            string[] ways = new string[16];
            int i = 1;
            string directoryPath = @"E:\Для VS\Ну рванули 1.3\Helmets";
            var pngshelm = Directory.EnumerateFiles(directoryPath, "*.png");
            foreach (var png in pngshelm)
            {
                ways[i-1] = png;
                i++;
            }
            pictureHelmetenemy.Image = Image.FromFile(ways[h_armorenemy.Next(1, 16)]);


            TBHelmarmorenemy.Text = h_armorenemy.Next(30, 250).ToString();
            Random b_armorenemy = new Random();
            TBBodyarmorenemy.Text = b_armorenemy.Next(35, 300).ToString();
            Random mskill = new Random();
            TBMSkillenemy.Text = mskill.Next(30, 100).ToString();
            Random mdef = new Random();
            TBMDefenemy.Text = mdef.Next(0, 70).ToString();
            strtempHP = "100";
            TBHealthenemy.Text = strtempHP + "/100";
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
