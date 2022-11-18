namespace AplicatieDocumente
{
    partial class Menu
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
            this.buttonSpreDocumenteInre = new System.Windows.Forms.Button();
            this.buttonSpreModif = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonSpreUserInre = new System.Windows.Forms.Button();
            this.buttonSpreDocumenteViz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPlaceholder = new System.Windows.Forms.Label();
            this.buttonVizualizareUtil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSpreDocumenteInre
            // 
            this.buttonSpreDocumenteInre.Location = new System.Drawing.Point(90, 83);
            this.buttonSpreDocumenteInre.Name = "buttonSpreDocumenteInre";
            this.buttonSpreDocumenteInre.Size = new System.Drawing.Size(282, 119);
            this.buttonSpreDocumenteInre.TabIndex = 11;
            this.buttonSpreDocumenteInre.Text = "Inregistrare Documente";
            this.buttonSpreDocumenteInre.UseVisualStyleBackColor = true;
            this.buttonSpreDocumenteInre.Click += new System.EventHandler(this.buttonSpreDocumenteInre_Click);
            // 
            // buttonSpreModif
            // 
            this.buttonSpreModif.Location = new System.Drawing.Point(668, 288);
            this.buttonSpreModif.Name = "buttonSpreModif";
            this.buttonSpreModif.Size = new System.Drawing.Size(276, 78);
            this.buttonSpreModif.TabIndex = 12;
            this.buttonSpreModif.Text = "Modificare Docum/ Util";
            this.buttonSpreModif.UseVisualStyleBackColor = true;
            this.buttonSpreModif.Click += new System.EventHandler(this.buttonSpreModif_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(12, 433);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(180, 78);
            this.buttonLogout.TabIndex = 13;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonSpreUserInre
            // 
            this.buttonSpreUserInre.Location = new System.Drawing.Point(90, 288);
            this.buttonSpreUserInre.Name = "buttonSpreUserInre";
            this.buttonSpreUserInre.Size = new System.Drawing.Size(282, 78);
            this.buttonSpreUserInre.TabIndex = 14;
            this.buttonSpreUserInre.Text = "Inregistrare Utilizatori";
            this.buttonSpreUserInre.UseVisualStyleBackColor = true;
            this.buttonSpreUserInre.Click += new System.EventHandler(this.buttonSpreUserInre_Click);
            // 
            // buttonSpreDocumenteViz
            // 
            this.buttonSpreDocumenteViz.Location = new System.Drawing.Point(668, 83);
            this.buttonSpreDocumenteViz.Name = "buttonSpreDocumenteViz";
            this.buttonSpreDocumenteViz.Size = new System.Drawing.Size(276, 113);
            this.buttonSpreDocumenteViz.TabIndex = 15;
            this.buttonSpreDocumenteViz.Text = "Vizualizare Documente";
            this.buttonSpreDocumenteViz.UseVisualStyleBackColor = true;
            this.buttonSpreDocumenteViz.Click += new System.EventHandler(this.buttonSpreDocumenteViz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Bun venit, ";
            // 
            // labelPlaceholder
            // 
            this.labelPlaceholder.AutoSize = true;
            this.labelPlaceholder.Location = new System.Drawing.Point(182, 9);
            this.labelPlaceholder.Name = "labelPlaceholder";
            this.labelPlaceholder.Size = new System.Drawing.Size(115, 25);
            this.labelPlaceholder.TabIndex = 17;
            this.labelPlaceholder.Text = "Placeholder";
            // 
            // buttonVizualizareUtil
            // 
            this.buttonVizualizareUtil.Location = new System.Drawing.Point(411, 288);
            this.buttonVizualizareUtil.Name = "buttonVizualizareUtil";
            this.buttonVizualizareUtil.Size = new System.Drawing.Size(225, 78);
            this.buttonVizualizareUtil.TabIndex = 18;
            this.buttonVizualizareUtil.Text = "Vizualizare Utilizatori";
            this.buttonVizualizareUtil.UseVisualStyleBackColor = true;
            this.buttonVizualizareUtil.Click += new System.EventHandler(this.buttonVizualizareUtil_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 523);
            this.Controls.Add(this.buttonVizualizareUtil);
            this.Controls.Add(this.labelPlaceholder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSpreDocumenteViz);
            this.Controls.Add(this.buttonSpreUserInre);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonSpreModif);
            this.Controls.Add(this.buttonSpreDocumenteInre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSpreDocumenteInre;
        private System.Windows.Forms.Button buttonSpreModif;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonSpreUserInre;
        private System.Windows.Forms.Button buttonSpreDocumenteViz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPlaceholder;
        private System.Windows.Forms.Button buttonVizualizareUtil;
    }
}