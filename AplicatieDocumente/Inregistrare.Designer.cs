namespace AplicatieDocumente
{
    partial class Inregistrare
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
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.textBoxNumeUtilizator = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonInregistrare = new System.Windows.Forms.Button();
            this.buttonSpre = new System.Windows.Forms.Button();
            this.comboBoxGrup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(416, 179);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(291, 30);
            this.textBoxParola.TabIndex = 9;
            this.textBoxParola.UseSystemPasswordChar = true;
            // 
            // textBoxNumeUtilizator
            // 
            this.textBoxNumeUtilizator.Location = new System.Drawing.Point(416, 103);
            this.textBoxNumeUtilizator.Name = "textBoxNumeUtilizator";
            this.textBoxNumeUtilizator.Size = new System.Drawing.Size(291, 30);
            this.textBoxNumeUtilizator.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nume Utilizator :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parola :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Grup :";
            // 
            // buttonInregistrare
            // 
            this.buttonInregistrare.Location = new System.Drawing.Point(416, 332);
            this.buttonInregistrare.Name = "buttonInregistrare";
            this.buttonInregistrare.Size = new System.Drawing.Size(184, 62);
            this.buttonInregistrare.TabIndex = 13;
            this.buttonInregistrare.Text = "Inregistrare";
            this.buttonInregistrare.UseVisualStyleBackColor = true;
            this.buttonInregistrare.Click += new System.EventHandler(this.buttonInregistrare_Click);
            // 
            // buttonSpre
            // 
            this.buttonSpre.Location = new System.Drawing.Point(52, 361);
            this.buttonSpre.Name = "buttonSpre";
            this.buttonSpre.Size = new System.Drawing.Size(184, 62);
            this.buttonSpre.TabIndex = 14;
            this.buttonSpre.Text = "Spre Login";
            this.buttonSpre.UseVisualStyleBackColor = true;
            this.buttonSpre.Click += new System.EventHandler(this.buttonSpre_Click);
            // 
            // comboBoxGrup
            // 
            this.comboBoxGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrup.FormattingEnabled = true;
            this.comboBoxGrup.Location = new System.Drawing.Point(416, 258);
            this.comboBoxGrup.Name = "comboBoxGrup";
            this.comboBoxGrup.Size = new System.Drawing.Size(166, 33);
            this.comboBoxGrup.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sectiune Inregistrare Utilizator";
            // 
            // Inregistrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxGrup);
            this.Controls.Add(this.buttonSpre);
            this.Controls.Add(this.buttonInregistrare);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxNumeUtilizator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Inregistrare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inregistrare";
            this.Load += new System.EventHandler(this.Inregistrare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.TextBox textBoxNumeUtilizator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonInregistrare;
        private System.Windows.Forms.Button buttonSpre;
        private System.Windows.Forms.ComboBox comboBoxGrup;
        private System.Windows.Forms.Label label1;
    }
}