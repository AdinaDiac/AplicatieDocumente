using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieDocumente
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Restart();
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare Logout");
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                string Acces = Useri.Acces;

                if (Acces == "User")
                {
                    buttonSpreModif.Visible = false;
                    buttonSpreUserInre.Visible = false;
                    buttonVizualizareUtil.Visible = false;
                }
             

                labelPlaceholder.Text = Useri.UserName;
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare Incarcare Meniu");
            }
        }

        private void buttonSpreDocumenteInre_Click(object sender, EventArgs e)
        {
            this.Close();
            InregistrareDocumente inre = new InregistrareDocumente();
            inre.Show();

        }

        private void buttonSpreDocumenteViz_Click(object sender, EventArgs e)
        {
            this.Close();
            VizualizareDocumente viz = new VizualizareDocumente();
            viz.Show();
        }

        private void buttonSpreUserInre_Click(object sender, EventArgs e)
        {
            this.Close();
            InregistrareUtilizatori inregis = new InregistrareUtilizatori();
            inregis.Show();
        }

        private void buttonSpreModif_Click(object sender, EventArgs e)
        {
            this.Close();
            ModifUtil_Docu modi = new ModifUtil_Docu();
            modi.Show();
        }

        private void buttonVizualizareUtil_Click(object sender, EventArgs e)
        {
            this.Close();
            VizualizareUtilizatori viz = new VizualizareUtilizatori();
            viz.Show();
        }
    }
}
