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
    public partial class Form2 : Form
    {
        /* переменная для обмена данными между Form1 и Form2 */
        public string helm_armor;
        public string helm_image;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /* переносим все показатели на арену */
            textBoxSmallHelm.Text = helm_armor;
            /* переносим фото */
            pictureHelmet.Image = Image.FromFile(helm_image);
        }
        private void fight_Click(object sender, EventArgs e)
        {
            Random h_armorenemy 
        }
    }
}
