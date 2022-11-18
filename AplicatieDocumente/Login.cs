using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AplicatieDocumente
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string NumeUtilizator=textBoxNumeUtilizator.Text;   
                string Parola = textBoxParola.Text;

                if(string.IsNullOrEmpty(NumeUtilizator) || string.IsNullOrEmpty(Parola))
                {
                    MessageBox.Show("Completati Campurile");
                }
                else
                {
                    Database databaseObject = new Database();

                    databaseObject.OpenConnection();

                    string queryselect = "SELECT IdUser from Useri WHERE NumeUtilizator=@NumeUtilizator" +
                        " AND Parola=@Parola ";

                   
                    SqlCommand comanda = new SqlCommand(queryselect,databaseObject.myConnection);
                    comanda.Parameters.AddWithValue("@NumeUtilizator",NumeUtilizator);
                    comanda.Parameters.AddWithValue("@Parola", Parola);

                    var result = comanda.ExecuteScalar();

                    if(result is null)
                    {
                        MessageBox.Show("Utilizatorul nu exista / Parola este Gresita");
                    }
                    else
                    {
                        string queryacces = "SELECT Acces from Useri WHERE IdUser=@IdUser";
                        SqlCommand comandaacces = new SqlCommand(queryacces, databaseObject.myConnection);
                        comandaacces.Parameters.AddWithValue("@IdUser", result.ToString());

                        var resultacces=comandaacces.ExecuteScalar();

                        string querygrup = "SELECT Grup from Useri WHERE IdUser=@IdUser";
                        SqlCommand comandagrup = new SqlCommand(querygrup, databaseObject.myConnection);
                        comandagrup.Parameters.AddWithValue("@IdUser", result.ToString());

                        var resultgrup = comandagrup.ExecuteScalar();
                        
                        Useri.UserId=result.ToString();
                        Useri.UserName = NumeUtilizator;
                        Useri.Acces = resultacces.ToString();
                        Useri.Grup = resultgrup.ToString();

                        MessageBox.Show("Bun venit : " + NumeUtilizator);
                        Menu menu = new Menu();
                        this.Hide();
                        menu.Show();
                    }

                    databaseObject.CloseConnection();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Eroare Login");
            }
        }

        private void buttonInregistrare_Click(object sender, EventArgs e)
        {
            try
            {
                Inregistrare inregistrare = new Inregistrare();
                inregistrare.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare Incarcare Formular Inregistrare");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare Exit");
            }
        }
    }
}
