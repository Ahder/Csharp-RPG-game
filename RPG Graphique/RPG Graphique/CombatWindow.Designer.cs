namespace RPG_Graphique
{
    partial class CombatWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CombatWindow));
            this.b1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pvMonstre = new System.Windows.Forms.Label();
            this.degatsMonstre = new System.Windows.Forms.Label();
            this.degatsPerso = new System.Windows.Forms.Label();
            this.pvPerso = new System.Windows.Forms.Label();
            this.nameMonstre = new System.Windows.Forms.Label();
            this.Vous = new System.Windows.Forms.Label();
            this.pictureMonstre = new System.Windows.Forms.PictureBox();
            this.picturePerso = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMonstre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerso)).BeginInit();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(289, 212);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(135, 35);
            this.b1.TabIndex = 0;
            this.b1.Text = "Attaquer";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "VS";
            // 
            // pvMonstre
            // 
            this.pvMonstre.AutoSize = true;
            this.pvMonstre.Location = new System.Drawing.Point(458, 36);
            this.pvMonstre.Name = "pvMonstre";
            this.pvMonstre.Size = new System.Drawing.Size(27, 13);
            this.pvMonstre.TabIndex = 4;
            this.pvMonstre.Text = "PV :";
            // 
            // degatsMonstre
            // 
            this.degatsMonstre.AutoSize = true;
            this.degatsMonstre.Location = new System.Drawing.Point(458, 64);
            this.degatsMonstre.Name = "degatsMonstre";
            this.degatsMonstre.Size = new System.Drawing.Size(47, 13);
            this.degatsMonstre.TabIndex = 5;
            this.degatsMonstre.Text = "Degats :";
            // 
            // degatsPerso
            // 
            this.degatsPerso.AutoSize = true;
            this.degatsPerso.Location = new System.Drawing.Point(8, 223);
            this.degatsPerso.Name = "degatsPerso";
            this.degatsPerso.Size = new System.Drawing.Size(47, 13);
            this.degatsPerso.TabIndex = 7;
            this.degatsPerso.Text = "Degats :";
            // 
            // pvPerso
            // 
            this.pvPerso.AutoSize = true;
            this.pvPerso.Location = new System.Drawing.Point(8, 200);
            this.pvPerso.Name = "pvPerso";
            this.pvPerso.Size = new System.Drawing.Size(27, 13);
            this.pvPerso.TabIndex = 6;
            this.pvPerso.Text = "PV :";
            // 
            // nameMonstre
            // 
            this.nameMonstre.AutoSize = true;
            this.nameMonstre.Location = new System.Drawing.Point(458, 12);
            this.nameMonstre.Name = "nameMonstre";
            this.nameMonstre.Size = new System.Drawing.Size(71, 13);
            this.nameMonstre.TabIndex = 8;
            this.nameMonstre.Text = "nameMonstre";
            // 
            // Vous
            // 
            this.Vous.AutoSize = true;
            this.Vous.Location = new System.Drawing.Point(8, 173);
            this.Vous.Name = "Vous";
            this.Vous.Size = new System.Drawing.Size(37, 13);
            this.Vous.TabIndex = 9;
            this.Vous.Text = "Vous !";
            // 
            // pictureMonstre
            // 
            this.pictureMonstre.Image = ((System.Drawing.Image)(resources.GetObject("pictureMonstre.Image")));
            this.pictureMonstre.Location = new System.Drawing.Point(266, 1);
            this.pictureMonstre.Name = "pictureMonstre";
            this.pictureMonstre.Size = new System.Drawing.Size(186, 156);
            this.pictureMonstre.TabIndex = 2;
            this.pictureMonstre.TabStop = false;
            // 
            // picturePerso
            // 
            this.picturePerso.Image = global::RPG_Graphique.Properties.Resources.toi;
            this.picturePerso.Location = new System.Drawing.Point(71, 154);
            this.picturePerso.Name = "picturePerso";
            this.picturePerso.Size = new System.Drawing.Size(146, 95);
            this.picturePerso.TabIndex = 1;
            this.picturePerso.TabStop = false;
            this.picturePerso.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CombatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 290);
            this.Controls.Add(this.Vous);
            this.Controls.Add(this.nameMonstre);
            this.Controls.Add(this.degatsPerso);
            this.Controls.Add(this.pvPerso);
            this.Controls.Add(this.degatsMonstre);
            this.Controls.Add(this.pvMonstre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureMonstre);
            this.Controls.Add(this.picturePerso);
            this.Controls.Add(this.b1);
            this.Name = "CombatWindow";
            this.Text = "CombatWindow";
            this.Load += new System.EventHandler(this.CombatWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMonstre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.PictureBox picturePerso;
        private System.Windows.Forms.PictureBox pictureMonstre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pvMonstre;
        private System.Windows.Forms.Label degatsMonstre;
        private System.Windows.Forms.Label degatsPerso;
        private System.Windows.Forms.Label pvPerso;
        private System.Windows.Forms.Label nameMonstre;
        private System.Windows.Forms.Label Vous;
    }
}