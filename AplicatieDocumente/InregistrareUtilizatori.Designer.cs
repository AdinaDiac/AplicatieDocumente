namespace AplicatieDocumente
{
    partial class InregistrareUtilizatori
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
            this.buttonSpreMeniu = new System.Windows.Forms.Button();
            this.comboBoxGrup = new System.Windows.Forms.ComboBox();
            this.buttonInregistrare = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.textBoxNumeUtilizator = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAcces = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSpreMeniu
            // 
            this.buttonSpreMeniu.Location = new System.Drawing.Point(24, 363);
            this.buttonSpreMeniu.Name = "buttonSpreMeniu";
            this.buttonSpreMeniu.Size = new System.Drawing.Size(250, 78);
            this.buttonSpreMeniu.TabIndex = 13;
            this.buttonSpreMeniu.Text = "Spre Meniu";
            this.buttonSpreMeniu.UseVisualStyleBackColor = true;
            this.buttonSpreMeniu.Click += new System.EventHandler(this.buttonSpreMeniu_Click);
            // 
            // comboBoxGrup
            // 
            this.comboBoxGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrup.FormattingEnabled = true;
            this.comboBoxGrup.Location = new System.Drawing.Point(423, 192);
            this.comboBoxGrup.Name = "comboBoxGrup";
            this.comboBoxGrup.Size = new System.Drawing.Size(166, 33);
            this.comboBoxGrup.TabIndex = 22;
            // 
            // buttonInregistrare
            // 
            this.buttonInregistrare.Location = new System.Drawing.Point(423, 326);
            this.buttonInregistrare.Name = "buttonInregistrare";
            this.buttonInregistrare.Size = new System.Drawing.Size(184, 62);
            this.buttonInregistrare.TabIndex = 21;
            this.buttonInregistrare.Text = "Inregistrare";
            this.buttonInregistrare.UseVisualStyleBackColor = true;
            this.buttonInregistrare.Click += new System.EventHandler(this.buttonInregistrare_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Grup :";
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(423, 113);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(291, 30);
            this.textBoxParola.TabIndex = 19;
            this.textBoxParola.UseSystemPasswordChar = true;
            // 
            // textBoxNumeUtilizator
            // 
            this.textBoxNumeUtilizator.Location = new System.Drawing.Point(423, 37);
            this.textBoxNumeUtilizator.Name = "textBoxNumeUtilizator";
            this.textBoxNumeUtilizator.Size = new System.Drawing.Size(291, 30);
            this.textBoxNumeUtilizator.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nume Utilizator :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Parola :";
            // 
            // comboBoxAcces
            // 
            this.comboBoxAcces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAcces.FormattingEnabled = true;
            this.comboBoxAcces.Location = new System.Drawing.Point(423, 258);
            this.comboBoxAcces.Name = "comboBoxAcces";
            this.comboBoxAcces.Size = new System.Drawing.Size(166, 33);
            this.comboBoxAcces.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Acces :";
            // 
            // InregistrareUtilizatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.comboBoxAcces);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxGrup);
            this.Controls.Add(this.buttonInregistrare);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxNumeUtilizator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSpreMeniu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InregistrareUtilizatori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inregistrare Utilizatori";
            this.Load += new System.EventHandler(this.InregistrareUtilizatori_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSpreMeniu;
        private System.Windows.Forms.ComboBox comboBoxGrup;
        private System.Windows.Forms.Button buttonInregistrare;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.TextBox textBoxNumeUtilizator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxAcces;
        private System.Windows.Forms.Label label1;
    }
}