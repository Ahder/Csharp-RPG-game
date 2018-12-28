namespace RPG_Graphique
{
    partial class CreaPerso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbHuman = new System.Windows.Forms.RadioButton();
            this.rbElfe = new System.Windows.Forms.RadioButton();
            this.rbDevil = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rbEpee = new System.Windows.Forms.RadioButton();
            this.rbBaguette = new System.Windows.Forms.RadioButton();
            this.rbHache = new System.Windows.Forms.RadioButton();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.gbRace = new System.Windows.Forms.GroupBox();
            this.gbArme = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbRace.SuspendLayout();
            this.gbArme.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Dungeon !";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tout d\'abord, il faut créer ton perso :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Le nom de ton perso :";
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(128, 73);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(161, 20);
            this.textNom.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "La race de ton perso :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rbHuman
            // 
            this.rbHuman.AutoSize = true;
            this.rbHuman.Location = new System.Drawing.Point(123, 28);
            this.rbHuman.Name = "rbHuman";
            this.rbHuman.Size = new System.Drawing.Size(61, 17);
            this.rbHuman.TabIndex = 5;
            this.rbHuman.TabStop = true;
            this.rbHuman.Text = "Humain";
            this.rbHuman.UseVisualStyleBackColor = true;
            this.rbHuman.CheckedChanged += new System.EventHandler(this.rbHuman_CheckedChanged);
            // 
            // rbElfe
            // 
            this.rbElfe.AutoSize = true;
            this.rbElfe.Location = new System.Drawing.Point(122, 58);
            this.rbElfe.Name = "rbElfe";
            this.rbElfe.Size = new System.Drawing.Size(101, 17);
            this.rbElfe.TabIndex = 6;
            this.rbElfe.TabStop = true;
            this.rbElfe.Text = "Elfe du Rizomm ";
            this.rbElfe.UseVisualStyleBackColor = true;
            this.rbElfe.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbDevil
            // 
            this.rbDevil.AutoSize = true;
            this.rbDevil.Location = new System.Drawing.Point(122, 89);
            this.rbDevil.Name = "rbDevil";
            this.rbDevil.Size = new System.Drawing.Size(49, 17);
            this.rbDevil.TabIndex = 7;
            this.rbDevil.TabStop = true;
            this.rbDevil.Text = "Devil";
            this.rbDevil.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "L\'arme de ton perso :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // rbEpee
            // 
            this.rbEpee.AutoSize = true;
            this.rbEpee.Location = new System.Drawing.Point(122, 92);
            this.rbEpee.Name = "rbEpee";
            this.rbEpee.Size = new System.Drawing.Size(104, 17);
            this.rbEpee.TabIndex = 9;
            this.rbEpee.TabStop = true;
            this.rbEpee.Text = "Epée en mousse";
            this.rbEpee.UseVisualStyleBackColor = true;
            // 
            // rbBaguette
            // 
            this.rbBaguette.AutoSize = true;
            this.rbBaguette.Location = new System.Drawing.Point(120, 59);
            this.rbBaguette.Name = "rbBaguette";
            this.rbBaguette.Size = new System.Drawing.Size(111, 17);
            this.rbBaguette.TabIndex = 10;
            this.rbBaguette.TabStop = true;
            this.rbBaguette.Text = "Baguette magique";
            this.rbBaguette.UseVisualStyleBackColor = true;
            this.rbBaguette.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rbHache
            // 
            this.rbHache.AutoSize = true;
            this.rbHache.Location = new System.Drawing.Point(122, 24);
            this.rbHache.Name = "rbHache";
            this.rbHache.Size = new System.Drawing.Size(55, 18);
            this.rbHache.TabIndex = 11;
            this.rbHache.TabStop = true;
            this.rbHache.Text = "Hache";
            this.rbHache.UseCompatibleTextRendering = true;
            this.rbHache.UseVisualStyleBackColor = true;
            this.rbHache.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(121, 398);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 12;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(121, 369);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 13;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // gbRace
            // 
            this.gbRace.Controls.Add(this.label4);
            this.gbRace.Controls.Add(this.rbHuman);
            this.gbRace.Controls.Add(this.rbElfe);
            this.gbRace.Controls.Add(this.rbDevil);
            this.gbRace.Location = new System.Drawing.Point(12, 99);
            this.gbRace.Name = "gbRace";
            this.gbRace.Size = new System.Drawing.Size(295, 125);
            this.gbRace.TabIndex = 14;
            this.gbRace.TabStop = false;
            this.gbRace.Text = "Race";
            // 
            // gbArme
            // 
            this.gbArme.Controls.Add(this.label8);
            this.gbArme.Controls.Add(this.label7);
            this.gbArme.Controls.Add(this.label6);
            this.gbArme.Controls.Add(this.label5);
            this.gbArme.Controls.Add(this.rbEpee);
            this.gbArme.Controls.Add(this.rbBaguette);
            this.gbArme.Controls.Add(this.rbHache);
            this.gbArme.Location = new System.Drawing.Point(15, 230);
            this.gbArme.Name = "gbArme";
            this.gbArme.Size = new System.Drawing.Size(292, 133);
            this.gbArme.TabIndex = 15;
            this.gbArme.TabStop = false;
            this.gbArme.Text = "Arme";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "(+2 dégats)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "(-2 dégats)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "(+0 dégat)";
            // 
            // CreaPerso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 431);
            this.Controls.Add(this.gbArme);
            this.Controls.Add(this.gbRace);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreaPerso";
            this.Text = "Creation Perso !";
            this.Load += new System.EventHandler(this.CreaPerso_Load);
            this.gbRace.ResumeLayout(false);
            this.gbRace.PerformLayout();
            this.gbArme.ResumeLayout(false);
            this.gbArme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbHuman;
        private System.Windows.Forms.RadioButton rbElfe;
        private System.Windows.Forms.RadioButton rbDevil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbEpee;
        private System.Windows.Forms.RadioButton rbBaguette;
        private System.Windows.Forms.RadioButton rbHache;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox gbRace;
        private System.Windows.Forms.GroupBox gbArme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}