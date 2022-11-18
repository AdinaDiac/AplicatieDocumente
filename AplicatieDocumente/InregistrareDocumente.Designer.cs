namespace AplicatieDocumente
{
    partial class InregistrareDocumente
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
            this.comboBoxTip = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInregistrare = new System.Windows.Forms.Button();
            this.textProDocu = new System.Windows.Forms.TextBox();
            this.textBoxDenDocu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDestiDocu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSpreMeniu
            // 
            this.buttonSpreMeniu.Location = new System.Drawing.Point(26, 434);
            this.buttonSpreMeniu.Name = "buttonSpreMeniu";
            this.buttonSpreMeniu.Size = new System.Drawing.Size(250, 78);
            this.buttonSpreMeniu.TabIndex = 12;
            this.buttonSpreMeniu.Text = "Spre Meniu";
            this.buttonSpreMeniu.UseVisualStyleBackColor = true;
            this.buttonSpreMeniu.Click += new System.EventHandler(this.buttonSpreMeniu_Click);
            // 
            // comboBoxTip
            // 
            this.comboBoxTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTip.FormattingEnabled = true;
            this.comboBoxTip.Location = new System.Drawing.Point(522, 262);
            this.comboBoxTip.Name = "comboBoxTip";
            this.comboBoxTip.Size = new System.Drawing.Size(166, 33);
            this.comboBoxTip.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tip Document :";
            // 
            // buttonInregistrare
            // 
            this.buttonInregistrare.Location = new System.Drawing.Point(522, 384);
            this.buttonInregistrare.Name = "buttonInregistrare";
            this.buttonInregistrare.Size = new System.Drawing.Size(184, 62);
            this.buttonInregistrare.TabIndex = 30;
            this.buttonInregistrare.Text = "Inregistrare";
            this.buttonInregistrare.UseVisualStyleBackColor = true;
            this.buttonInregistrare.Click += new System.EventHandler(this.buttonInregistrare_Click);
            // 
            // textProDocu
            // 
            this.textProDocu.Location = new System.Drawing.Point(522, 124);
            this.textProDocu.Name = "textProDocu";
            this.textProDocu.Size = new System.Drawing.Size(291, 30);
            this.textProDocu.TabIndex = 28;
            // 
            // textBoxDenDocu
            // 
            this.textBoxDenDocu.Location = new System.Drawing.Point(522, 53);
            this.textBoxDenDocu.Name = "textBoxDenDocu";
            this.textBoxDenDocu.Size = new System.Drawing.Size(291, 30);
            this.textBoxDenDocu.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Denumire Document :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Provenienta Document :";
            // 
            // textBoxDestiDocu
            // 
            this.textBoxDestiDocu.Location = new System.Drawing.Point(522, 194);
            this.textBoxDestiDocu.Name = "textBoxDestiDocu";
            this.textBoxDestiDocu.Size = new System.Drawing.Size(291, 30);
            this.textBoxDestiDocu.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Destinatie Document :";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Location = new System.Drawing.Point(517, 333);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(63, 25);
            this.labelTemp.TabIndex = 36;
            this.labelTemp.Text = "Temp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Document inregistrat anterior:";
            // 
            // InregistrareDocumente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 524);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.textBoxDestiDocu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInregistrare);
            this.Controls.Add(this.textProDocu);
            this.Controls.Add(this.textBoxDenDocu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSpreMeniu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InregistrareDocumente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inregistrare Documente";
            this.Load += new System.EventHandler(this.InregistrareDocumente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSpreMeniu;
        private System.Windows.Forms.ComboBox comboBoxTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInregistrare;
        private System.Windows.Forms.TextBox textProDocu;
        private System.Windows.Forms.TextBox textBoxDenDocu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDestiDocu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label label6;
    }
}