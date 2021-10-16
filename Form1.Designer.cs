
namespace Ну_рванули
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxHelmet = new System.Windows.Forms.ComboBox();
            this.comboBoxWeapon = new System.Windows.Forms.ComboBox();
            this.comboBoxArmour = new System.Windows.Forms.ComboBox();
            this.comboBoxShield = new System.Windows.Forms.ComboBox();
            this.TBBodyarmor = new System.Windows.Forms.TextBox();
            this.TBMSkill = new System.Windows.Forms.TextBox();
            this.TBMDef = new System.Windows.Forms.TextBox();
            this.TBHelmarmor = new System.Windows.Forms.TextBox();
            this.TBHealth = new System.Windows.Forms.TextBox();
            this.TBWeapDamage = new System.Windows.Forms.TextBox();
            this.createchar = new System.Windows.Forms.Button();
            this.arena = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.confirmedbutt = new System.Windows.Forms.Button();
            this.pictureBoxWeapDamage = new System.Windows.Forms.PictureBox();
            this.pictureBoxHealth = new System.Windows.Forms.PictureBox();
            this.pictureBoxSmallArmour = new System.Windows.Forms.PictureBox();
            this.pictureBoxSmallHelm = new System.Windows.Forms.PictureBox();
            this.pictureBoxMdef = new System.Windows.Forms.PictureBox();
            this.pictureBoxMSkill = new System.Windows.Forms.PictureBox();
            this.pictureShield = new System.Windows.Forms.PictureBox();
            this.pictureWeapon = new System.Windows.Forms.PictureBox();
            this.pictureArmour = new System.Windows.Forms.PictureBox();
            this.pictureHelmet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeapDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmallArmour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmallHelm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMdef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArmour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHelmet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxHelmet
            // 
            this.comboBoxHelmet.BackColor = System.Drawing.Color.White;
            this.comboBoxHelmet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxHelmet.DisplayMember = "1";
            this.comboBoxHelmet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxHelmet.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHelmet.FormattingEnabled = true;
            this.comboBoxHelmet.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBoxHelmet.Location = new System.Drawing.Point(148, 193);
            this.comboBoxHelmet.Name = "comboBoxHelmet";
            this.comboBoxHelmet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxHelmet.Size = new System.Drawing.Size(132, 27);
            this.comboBoxHelmet.TabIndex = 4;
            this.comboBoxHelmet.SelectedIndexChanged += new System.EventHandler(this.comboBoxHelmet_SelectedIndexChanged);
            // 
            // comboBoxWeapon
            // 
            this.comboBoxWeapon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxWeapon.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWeapon.FormattingEnabled = true;
            this.comboBoxWeapon.Location = new System.Drawing.Point(0, 385);
            this.comboBoxWeapon.Name = "comboBoxWeapon";
            this.comboBoxWeapon.Size = new System.Drawing.Size(132, 27);
            this.comboBoxWeapon.TabIndex = 5;
            this.comboBoxWeapon.SelectedIndexChanged += new System.EventHandler(this.comboBoxWeapon_SelectedIndexChanged);
            // 
            // comboBoxArmour
            // 
            this.comboBoxArmour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxArmour.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxArmour.FormattingEnabled = true;
            this.comboBoxArmour.Location = new System.Drawing.Point(148, 385);
            this.comboBoxArmour.Name = "comboBoxArmour";
            this.comboBoxArmour.Size = new System.Drawing.Size(132, 27);
            this.comboBoxArmour.TabIndex = 6;
            this.comboBoxArmour.SelectedIndexChanged += new System.EventHandler(this.comboBoxArmour_SelectedIndexChanged);
            // 
            // comboBoxShield
            // 
            this.comboBoxShield.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxShield.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxShield.FormattingEnabled = true;
            this.comboBoxShield.Location = new System.Drawing.Point(296, 385);
            this.comboBoxShield.Name = "comboBoxShield";
            this.comboBoxShield.Size = new System.Drawing.Size(132, 27);
            this.comboBoxShield.TabIndex = 7;
            this.comboBoxShield.SelectedIndexChanged += new System.EventHandler(this.comboBoxShield_SelectedIndexChanged);
            // 
            // TBBodyarmor
            // 
            this.TBBodyarmor.BackColor = System.Drawing.Color.LightSlateGray;
            this.TBBodyarmor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBBodyarmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBBodyarmor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TBBodyarmor.Location = new System.Drawing.Point(120, 466);
            this.TBBodyarmor.Multiline = true;
            this.TBBodyarmor.Name = "TBBodyarmor";
            this.TBBodyarmor.ReadOnly = true;
            this.TBBodyarmor.Size = new System.Drawing.Size(89, 35);
            this.TBBodyarmor.TabIndex = 8;
            // 
            // TBMSkill
            // 
            this.TBMSkill.BackColor = System.Drawing.Color.Sienna;
            this.TBMSkill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBMSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBMSkill.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TBMSkill.Location = new System.Drawing.Point(266, 421);
            this.TBMSkill.Multiline = true;
            this.TBMSkill.Name = "TBMSkill";
            this.TBMSkill.ReadOnly = true;
            this.TBMSkill.Size = new System.Drawing.Size(89, 39);
            this.TBMSkill.TabIndex = 9;
            // 
            // TBMDef
            // 
            this.TBMDef.BackColor = System.Drawing.Color.Sienna;
            this.TBMDef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBMDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBMDef.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TBMDef.Location = new System.Drawing.Point(268, 466);
            this.TBMDef.Multiline = true;
            this.TBMDef.Name = "TBMDef";
            this.TBMDef.ReadOnly = true;
            this.TBMDef.Size = new System.Drawing.Size(87, 35);
            this.TBMDef.TabIndex = 10;
            // 
            // TBHelmarmor
            // 
            this.TBHelmarmor.BackColor = System.Drawing.Color.LightSlateGray;
            this.TBHelmarmor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBHelmarmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBHelmarmor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TBHelmarmor.Location = new System.Drawing.Point(120, 421);
            this.TBHelmarmor.Multiline = true;
            this.TBHelmarmor.Name = "TBHelmarmor";
            this.TBHelmarmor.ReadOnly = true;
            this.TBHelmarmor.Size = new System.Drawing.Size(89, 39);
            this.TBHelmarmor.TabIndex = 14;
            // 
            // TBHealth
            // 
            this.TBHealth.BackColor = System.Drawing.Color.DarkRed;
            this.TBHealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBHealth.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TBHealth.Location = new System.Drawing.Point(120, 507);
            this.TBHealth.Multiline = true;
            this.TBHealth.Name = "TBHealth";
            this.TBHealth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TBHealth.Size = new System.Drawing.Size(89, 39);
            this.TBHealth.TabIndex = 15;
            // 
            // TBWeapDamage
            // 
            this.TBWeapDamage.BackColor = System.Drawing.Color.Crimson;
            this.TBWeapDamage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBWeapDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBWeapDamage.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TBWeapDamage.Location = new System.Drawing.Point(268, 507);
            this.TBWeapDamage.Multiline = true;
            this.TBWeapDamage.Name = "TBWeapDamage";
            this.TBWeapDamage.ReadOnly = true;
            this.TBWeapDamage.Size = new System.Drawing.Size(87, 39);
            this.TBWeapDamage.TabIndex = 19;
            // 
            // createchar
            // 
            this.createchar.BackColor = System.Drawing.Color.Transparent;
            this.createchar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createchar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createchar.Location = new System.Drawing.Point(12, 12);
            this.createchar.Name = "createchar";
            this.createchar.Size = new System.Drawing.Size(130, 26);
            this.createchar.TabIndex = 20;
            this.createchar.Text = "Создание Персонажа";
            this.createchar.UseVisualStyleBackColor = false;
            // 
            // arena
            // 
            this.arena.BackColor = System.Drawing.Color.Transparent;
            this.arena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arena.Location = new System.Drawing.Point(148, 12);
            this.arena.Name = "arena";
            this.arena.Size = new System.Drawing.Size(75, 26);
            this.arena.TabIndex = 21;
            this.arena.Text = "Арена";
            this.arena.UseVisualStyleBackColor = false;
            this.arena.Click += new System.EventHandler(this.arena_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Имя персонажа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Прозвище:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(120, 44);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(167, 20);
            this.name.TabIndex = 24;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 25;
            // 
            // confirmedbutt
            // 
            this.confirmedbutt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmedbutt.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmedbutt.Location = new System.Drawing.Point(130, 549);
            this.confirmedbutt.Name = "confirmedbutt";
            this.confirmedbutt.Size = new System.Drawing.Size(173, 72);
            this.confirmedbutt.TabIndex = 26;
            this.confirmedbutt.Text = "Подтвердить персонажа";
            this.confirmedbutt.UseVisualStyleBackColor = true;
            this.confirmedbutt.Click += new System.EventHandler(this.confirmedbutt_Click);
            // 
            // pictureBoxWeapDamage
            // 
            this.pictureBoxWeapDamage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWeapDamage.Image = global::Ну_рванули.Properties.Resources.SwordHitHeart111;
            this.pictureBoxWeapDamage.Location = new System.Drawing.Point(222, 507);
            this.pictureBoxWeapDamage.Name = "pictureBoxWeapDamage";
            this.pictureBoxWeapDamage.Size = new System.Drawing.Size(40, 39);
            this.pictureBoxWeapDamage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWeapDamage.TabIndex = 18;
            this.pictureBoxWeapDamage.TabStop = false;
            // 
            // pictureBoxHealth
            // 
            this.pictureBoxHealth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHealth.Image = global::Ну_рванули.Properties.Resources.HP;
            this.pictureBoxHealth.Location = new System.Drawing.Point(75, 507);
            this.pictureBoxHealth.Name = "pictureBoxHealth";
            this.pictureBoxHealth.Size = new System.Drawing.Size(39, 39);
            this.pictureBoxHealth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHealth.TabIndex = 17;
            this.pictureBoxHealth.TabStop = false;
            // 
            // pictureBoxSmallArmour
            // 
            this.pictureBoxSmallArmour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSmallArmour.Image = global::Ну_рванули.Properties.Resources.Screenshot_1;
            this.pictureBoxSmallArmour.Location = new System.Drawing.Point(75, 466);
            this.pictureBoxSmallArmour.Name = "pictureBoxSmallArmour";
            this.pictureBoxSmallArmour.Size = new System.Drawing.Size(39, 35);
            this.pictureBoxSmallArmour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSmallArmour.TabIndex = 16;
            this.pictureBoxSmallArmour.TabStop = false;
            // 
            // pictureBoxSmallHelm
            // 
            this.pictureBoxSmallHelm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSmallHelm.Image = global::Ну_рванули.Properties.Resources.HelmetSiluette1;
            this.pictureBoxSmallHelm.Location = new System.Drawing.Point(75, 421);
            this.pictureBoxSmallHelm.Name = "pictureBoxSmallHelm";
            this.pictureBoxSmallHelm.Size = new System.Drawing.Size(39, 39);
            this.pictureBoxSmallHelm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSmallHelm.TabIndex = 13;
            this.pictureBoxSmallHelm.TabStop = false;
            // 
            // pictureBoxMdef
            // 
            this.pictureBoxMdef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMdef.Image = global::Ну_рванули.Properties.Resources.ShieldSiluette;
            this.pictureBoxMdef.Location = new System.Drawing.Point(222, 466);
            this.pictureBoxMdef.Name = "pictureBoxMdef";
            this.pictureBoxMdef.Size = new System.Drawing.Size(39, 35);
            this.pictureBoxMdef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMdef.TabIndex = 12;
            this.pictureBoxMdef.TabStop = false;
            // 
            // pictureBoxMSkill
            // 
            this.pictureBoxMSkill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMSkill.Image = global::Ну_рванули.Properties.Resources.png_transparent_sword_computer_icons_ice_axe_angle_black_desktop_wallpaper2;
            this.pictureBoxMSkill.Location = new System.Drawing.Point(222, 421);
            this.pictureBoxMSkill.Name = "pictureBoxMSkill";
            this.pictureBoxMSkill.Size = new System.Drawing.Size(39, 39);
            this.pictureBoxMSkill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMSkill.TabIndex = 11;
            this.pictureBoxMSkill.TabStop = false;
            // 
            // pictureShield
            // 
            this.pictureShield.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureShield.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureShield.BackgroundImage")));
            this.pictureShield.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureShield.Location = new System.Drawing.Point(317, 229);
            this.pictureShield.Name = "pictureShield";
            this.pictureShield.Size = new System.Drawing.Size(100, 150);
            this.pictureShield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureShield.TabIndex = 3;
            this.pictureShield.TabStop = false;
            // 
            // pictureWeapon
            // 
            this.pictureWeapon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureWeapon.Image = global::Ну_рванули.Properties.Resources.Grey;
            this.pictureWeapon.Location = new System.Drawing.Point(14, 229);
            this.pictureWeapon.Name = "pictureWeapon";
            this.pictureWeapon.Size = new System.Drawing.Size(100, 150);
            this.pictureWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureWeapon.TabIndex = 2;
            this.pictureWeapon.TabStop = false;
            // 
            // pictureArmour
            // 
            this.pictureArmour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureArmour.Image = global::Ну_рванули.Properties.Resources.Grey;
            this.pictureArmour.Location = new System.Drawing.Point(164, 229);
            this.pictureArmour.Name = "pictureArmour";
            this.pictureArmour.Size = new System.Drawing.Size(100, 150);
            this.pictureArmour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureArmour.TabIndex = 1;
            this.pictureArmour.TabStop = false;
            // 
            // pictureHelmet
            // 
            this.pictureHelmet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureHelmet.Image = global::Ну_рванули.Properties.Resources.Grey;
            this.pictureHelmet.Location = new System.Drawing.Point(164, 96);
            this.pictureHelmet.Name = "pictureHelmet";
            this.pictureHelmet.Size = new System.Drawing.Size(100, 91);
            this.pictureHelmet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHelmet.TabIndex = 0;
            this.pictureHelmet.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(440, 633);
            this.Controls.Add(this.confirmedbutt);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arena);
            this.Controls.Add(this.createchar);
            this.Controls.Add(this.TBWeapDamage);
            this.Controls.Add(this.pictureBoxWeapDamage);
            this.Controls.Add(this.pictureBoxHealth);
            this.Controls.Add(this.pictureBoxSmallArmour);
            this.Controls.Add(this.TBHealth);
            this.Controls.Add(this.TBHelmarmor);
            this.Controls.Add(this.pictureBoxSmallHelm);
            this.Controls.Add(this.pictureBoxMdef);
            this.Controls.Add(this.pictureBoxMSkill);
            this.Controls.Add(this.TBMDef);
            this.Controls.Add(this.TBMSkill);
            this.Controls.Add(this.TBBodyarmor);
            this.Controls.Add(this.comboBoxShield);
            this.Controls.Add(this.comboBoxArmour);
            this.Controls.Add(this.comboBoxWeapon);
            this.Controls.Add(this.comboBoxHelmet);
            this.Controls.Add(this.pictureShield);
            this.Controls.Add(this.pictureWeapon);
            this.Controls.Add(this.pictureArmour);
            this.Controls.Add(this.pictureHelmet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeapDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmallArmour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmallHelm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMdef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArmour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHelmet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureHelmet;
        private System.Windows.Forms.PictureBox pictureArmour;
        private System.Windows.Forms.PictureBox pictureWeapon;
        private System.Windows.Forms.PictureBox pictureShield;
        private System.Windows.Forms.ComboBox comboBoxHelmet;
        private System.Windows.Forms.ComboBox comboBoxWeapon;
        private System.Windows.Forms.ComboBox comboBoxArmour;
        private System.Windows.Forms.ComboBox comboBoxShield;
        private System.Windows.Forms.TextBox TBBodyarmor;
        private System.Windows.Forms.TextBox TBMSkill;
        private System.Windows.Forms.TextBox TBMDef;
        private System.Windows.Forms.PictureBox pictureBoxMSkill;
        private System.Windows.Forms.PictureBox pictureBoxMdef;
        private System.Windows.Forms.PictureBox pictureBoxSmallHelm;
        private System.Windows.Forms.TextBox TBHelmarmor;
        private System.Windows.Forms.TextBox TBHealth;
        private System.Windows.Forms.PictureBox pictureBoxSmallArmour;
        private System.Windows.Forms.PictureBox pictureBoxHealth;
        private System.Windows.Forms.PictureBox pictureBoxWeapDamage;
        private System.Windows.Forms.TextBox TBWeapDamage;
        private System.Windows.Forms.Button createchar;
        private System.Windows.Forms.Button arena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button confirmedbutt;
    }
}

