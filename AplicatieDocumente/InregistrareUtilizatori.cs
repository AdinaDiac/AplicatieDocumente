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
    public partial class InregistrareUtilizatori : Form
    {
        public InregistrareUtilizatori()
        {
            InitializeComponent();
        }

        private void buttonSpreMeniu_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void buttonInregistrare_Click(object sender, EventArgs e)
        {
            try
            {
                string NumeUtilizator = textBoxNumeUtilizator.Text;
                string Parola = textBoxParola.Text;
                string Grup = ((KeyValuePair<string, string>)comboBoxGrup.SelectedItem).Value;
                string Acces = ((KeyValuePair<string, string>)comboBoxAcces.SelectedItem).Value;


                if (string.IsNullOrEmpty(NumeUtilizator) || string.IsNullOrEmpty(Parola) || string.IsNullOrEmpty(Grup))
                {
                    MessageBox.Show("Completati Campurile");
                }
                else
                {
                    Database databaseObject = new Database();

                    databaseObject.OpenConnection();
                    string queryselect = "SELECT IdUser,NumeUtilizator from Useri WHERE NumeUtilizator=@NumeUtilizator" +
                                            " AND Parola=@Parola ";


                    SqlCommand comanda = new SqlCommand(queryselect, databaseObject.myConnection);
                    comanda.Parameters.AddWithValue("@NumeUtilizator", NumeUtilizator);
                    comanda.Parameters.AddWithValue("@Parola", Parola);

                    var result = comanda.ExecuteScalar();

                    if (result is null)
                    {

                        string insert = "INSERT INTO Useri(NumeUtilizator,Parola,Grup,Acces) VALUES (@NumeUtilizator,@Parola,@Grup,@Acces)";

                        SqlCommand comandainsert = new SqlCommand(insert, databaseObject.myConnection);
                        comandainsert.Parameters.AddWithValue("@NumeUtilizator", NumeUtilizator);
                        comandainsert.Parameters.AddWithValue("@Parola", Parola);
                        comandainsert.Parameters.AddWithValue("@Grup", Grup);
                        comandainsert.Parameters.AddWithValue("@Acces", Acces);

                        var result2 = comandainsert.ExecuteNonQuery();

                        MessageBox.Show("Inregistrare Reusita");

                        textBoxNumeUtilizator.Text = "";
                        textBoxParola.Text = "";
                        comboBoxGrup.SelectedIndex = 0;
                        comboBoxAcces.SelectedIndex = 0;

                    }
                    else
                    {
                        MessageBox.Show("Utilizatorul exista deja");
                    }

                    databaseObject.CloseConnection();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare Inregistrare");
            }
    

        }

        private void InregistrareUtilizatori_Load(object sender, EventArgs e)
        {
            try
            {

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
                MessageBox.Show("Eroare Incarcare");
            }
        }
    }
}
