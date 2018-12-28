namespace RPG_Graphique
{
    partial class QuizWindow
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
            this.btnGauche = new System.Windows.Forms.Button();
            this.btnDroite = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.confirm = new System.Windows.Forms.Button();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.question = new System.Windows.Forms.Label();
            this.pvPerso = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGauche
            // 
            this.btnGauche.Location = new System.Drawing.Point(318, 12);
            this.btnGauche.Name = "btnGauche";
            this.btnGauche.Size = new System.Drawing.Size(89, 77);
            this.btnGauche.TabIndex = 0;
            this.btnGauche.Text = "Gauche";
            this.btnGauche.UseVisualStyleBackColor = true;
            this.btnGauche.Click += new System.EventHandler(this.btnGauche_Click);
            // 
            // btnDroite
            // 
            this.btnDroite.Location = new System.Drawing.Point(118, 12);
            this.btnDroite.Name = "btnDroite";
            this.btnDroite.Size = new System.Drawing.Size(89, 77);
            this.btnDroite.TabIndex = 1;
            this.btnDroite.Text = "Droite";
            this.btnDroite.UseVisualStyleBackColor = true;
            this.btnDroite.Click += new System.EventHandler(this.btnDroite_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.confirm);
            this.groupBox1.Controls.Add(this.rb4);
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Controls.Add(this.question);
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 198);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quiz Time !";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(213, 167);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(85, 23);
            this.confirm.TabIndex = 3;
            this.confirm.Text = "Confirmer";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(213, 127);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(85, 17);
            this.rb4.TabIndex = 4;
            this.rb4.TabStop = true;
            this.rb4.Text = "radioButton4";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(213, 104);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(85, 17);
            this.rb3.TabIndex = 3;
            this.rb3.TabStop = true;
            this.rb3.Text = "radioButton3";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(213, 81);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(85, 17);
            this.rb2.TabIndex = 2;
            this.rb2.TabStop = true;
            this.rb2.Text = "radioButton2";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(213, 58);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(85, 17);
            this.rb1.TabIndex = 1;
            this.rb1.TabStop = true;
            this.rb1.Text = "radioButton1";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Location = new System.Drawing.Point(6, 32);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(35, 13);
            this.question.TabIndex = 0;
            this.question.Text = "label1";
            // 
            // pvPerso
            // 
            this.pvPerso.AutoSize = true;
            this.pvPerso.Location = new System.Drawing.Point(250, 44);
            this.pvPerso.Name = "pvPerso";
            this.pvPerso.Size = new System.Drawing.Size(27, 13);
            this.pvPerso.TabIndex = 5;
            this.pvPerso.Text = "PV :";
            // 
            // QuizWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 297);
            this.Controls.Add(this.pvPerso);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDroite);
            this.Controls.Add(this.btnGauche);
            this.Name = "QuizWindow";
            this.Text = "QuizWindow";
            this.Load += new System.EventHandler(this.QuizWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGauche;
        private System.Windows.Forms.Button btnDroite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label pvPerso;
    }
}