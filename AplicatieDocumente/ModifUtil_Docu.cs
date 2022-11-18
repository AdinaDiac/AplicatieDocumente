using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieDocumente
{
    public partial class ModifUtil_Docu : Form
    {
        public ModifUtil_Docu()
        {
            InitializeComponent();
        }

        private void buttonSpreMeniu_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void ModifUtil_Docu_Load(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> tip = new Dictionary<string, string>();
                tip.Add("1", "Intrare");
                tip.Add("2", "Iesire");

                comboBoxTip.DataSource = new BindingSource(tip, null);
                comboBoxTip.DisplayMember = "Value";
                comboBoxTip.ValueMember = "Key";

                Dictionary<string, string> grup = new Dictionary<string, string>();
                grup.Add("1", "HR");
                grup.Add("2", "HSE");
                grup.Add("3", "IT");

                grup.Add("4", "PURCHASING");
                grup.Add("5", "FINANCIAL");
                comboBoxGrup.DataSource = new BindingSource(grup, null);
                comboBoxGrup.DisplayMember = "Value";
                comboBoxGrup.ValueMember = "Key";

                Dictionary<string, string> acces = new Dictionary<string, string>();
                acces.Add("1", "User");
                acces.Add("2", "Admin");

                comboBoxAcces.DataSource = new BindingSource(acces, null);
                comboBoxAcces.DisplayMember = "Value";
                comboBoxAcces.ValueMember = "Key";
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare Page Load Documente");
            }
        }

        private void buttonModifUser_Click(object sender, EventArgs e)
        {
            try
            {
                string IdUser=textBoxIdUser.Text;
                string NumeUtilizator = textBoxNumeUtilizator.Text;
                string Parola = textBoxParola.Text;
                string Grup = ((KeyValuePair<string, string>)comboBoxGrup.SelectedItem).Value;
                string Acces = ((KeyValuePair<string, string>)comboBoxAcces.SelectedItem).Value;


                if (string.IsNullOrEmpty(NumeUtilizator) || string.IsNullOrEmpty(Parola) || string.IsNullOrEmpty(Grup) || string.IsNullOrEmpty(IdUser))
                {
                    MessageBox.Show("Completati Campurile");
                }
                else
                {
                    if (IdUser != Useri.UserId)
                    {
                        Database databaseObject = new Database();
                        databaseObject.OpenConnection();

                        string updateuse = "UPDATE Useri SET NumeUtilizator=@NumeUtilizator, Parola=@Parola, Grup=@Grup, Acces=@Acces WHERE IdUser=@IdUser";

                        SqlCommand cup = new SqlCommand(updateuse, databaseObject.myConnection);
                        cup.Parameters.AddWithValue("@NumeUtilizator", NumeUtilizator);
                        cup.Parameters.AddWithValue("@Parola", Parola);
                        cup.Parameters.AddWithValue("@Grup", Grup);
                        cup.Parameters.AddWithValue("@Acces", Acces);
                        cup.Parameters.AddWithValue("@IdUser", IdUser);

                        var result = cup.ExecuteNonQuery();

                        if(result != 0)
                        {
                            MessageBox.Show("Modificare Utilizator reusita");
                            textBoxNumeUtilizator.Text = "";
                            textBoxParola.Text = "";
                            comboBoxGrup.SelectedIndex = 0;
                            comboBoxAcces.SelectedIndex = 0;
                            textBoxIdUser.Text = "";
                        }

                        databaseObject.CloseConnection();
                    }
                    else
                    {
                        MessageBox.Show("Nu puteti modifica userul logat");
                    }
                    
                }

                
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare Modificare User");
            }
        }

        private void buttonModifDocu_Click(object sender, EventArgs e)
        {
            try
            {
                string IdDocument = textBoxIdDocu.Text;
                string DenDocu = textBoxDenDocu.Text;
                string ProDocu = textProDocu.Text;
                string DestiDocu = textBoxDestiDocu.Text;
                string TipDocu = ((KeyValuePair<string, string>)comboBoxTip.SelectedItem).Value;
               

                if (string.IsNullOrEmpty(DenDocu) || string.IsNullOrEmpty(ProDocu) || string.IsNullOrEmpty(DestiDocu) || string.IsNullOrEmpty(TipDocu))
                {
                    MessageBox.Show("Completati Campurile");
                }
                else
                {
                    Database databaseObject = new Database();
                    databaseObject.OpenConnection();
                    string updatedoc = "UPDATE Inregistrari SET DenumireDocument=@DenumireDocument, ProvenientaDocument=@ProvenientaDocument, DestinatieDocument=@DestinatieDocument, TipDocument=@TipDocument " +
                        "WHERE IdDocument=@IdDocument ";

                    SqlCommand comup = new SqlCommand(updatedoc, databaseObject.myConnection);
                   
                    comup.Parameters.AddWithValue("@DenumireDocument", DenDocu);
                    comup.Parameters.AddWithValue("@ProvenientaDocument", ProDocu);
                    comup.Parameters.AddWithValue("@DestinatieDocument", DestiDocu);
                    comup.Parameters.AddWithValue("@TipDocument", TipDocu);
                    comup.Parameters.AddWithValue("@IdDocument", IdDocument);

                    var result = comup.ExecuteNonQuery();

                    if (result != 0)
                    {
                        MessageBox.Show("Modificare Document reusita");

                        textBoxDenDocu.Text = "";
                        textBoxDestiDocu.Text = "";
                        textProDocu.Text = "";
                        comboBoxTip.SelectedIndex = 0;
                        textBoxIdDocu.Text = "";
                    }

                    databaseObject.CloseConnection();
                }

                
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare Modificare Document");
            }
        }
    }
}
