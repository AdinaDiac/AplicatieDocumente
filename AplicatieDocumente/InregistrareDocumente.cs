using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieDocumente
{
    public partial class InregistrareDocumente : Form
    {
        public InregistrareDocumente()
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
                string DenDocu = textBoxDenDocu.Text;
                string ProDocu = textProDocu.Text;
                string DestiDocu = textBoxDestiDocu.Text;
                string TipDocu = ((KeyValuePair<string, string>)comboBoxTip.SelectedItem).Value;
                DateTime datacure = DateTime.Now;
                string InregistratDe = Useri.UserName;

                if (string.IsNullOrEmpty(DenDocu) || string.IsNullOrEmpty(ProDocu) || string.IsNullOrEmpty(DestiDocu) || string.IsNullOrEmpty(TipDocu))
                {
                    MessageBox.Show("Completati Campurile");
                }
                else
                {
                    Database databaseObject = new Database();
                    databaseObject.OpenConnection();

                    string insert = "INSERT INTO Inregistrari (DataInregistrarii,DenumireDocument,ProvenientaDocument,DestinatieDocument,TipDocument,InregistratDe)" +
                        " VALUES (@DataInregistrarii,@DenumireDocument,@ProvenientaDocument,@DestinatieDocument,@TipDocument,@InregistratDe)";

                    SqlCommand comin = new SqlCommand(insert, databaseObject.myConnection);
                    comin.Parameters.AddWithValue("@DataInregistrarii",datacure);
                    comin.Parameters.AddWithValue("@DenumireDocument", DenDocu);
                    comin.Parameters.AddWithValue("@ProvenientaDocument", ProDocu);
                    comin.Parameters.AddWithValue("@DestinatieDocument", DestiDocu);
                    comin.Parameters.AddWithValue("@TipDocument", TipDocu);
                    comin.Parameters.AddWithValue("@InregistratDe", InregistratDe);

                    var result=comin.ExecuteNonQuery();

                   
                    

                    string NumarDocument = "";

                    string sel = "SELECT IdDocument from Inregistrari WHERE DenumireDocument=@DenumireDocument AND ProvenientaDocument=@ProvenientaDocument" +
                        " AND DestinatieDocument=@DestinatieDocument";

                    SqlCommand comsel = new SqlCommand(sel, databaseObject.myConnection);
                    comsel.Parameters.AddWithValue("@DestinatieDocument", DestiDocu);
                    comsel.Parameters.AddWithValue("@DenumireDocument", DenDocu);
                    comsel.Parameters.AddWithValue("@ProvenientaDocument", ProDocu);

                    var resultsel = comsel.ExecuteScalar();

                    NumarDocument=resultsel.ToString();


                    MessageBox.Show("Numar documentului inregistrat este : " + NumarDocument);

                    textBoxDenDocu.Text = "";
                    textBoxDestiDocu.Text = "";
                    textProDocu.Text = "";
                    comboBoxTip.SelectedIndex = 0;

                    labelTemp.Text = NumarDocument;




                    databaseObject.CloseConnection();
                }

               

            }
            catch (Exception)
            {
                MessageBox.Show("Eroare Inregistrare Document");
            }
        }

        private void InregistrareDocumente_Load(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> tip = new Dictionary<string, string>();
                tip.Add("1", "Intrare");
                tip.Add("2", "Iesire");

                comboBoxTip.DataSource = new BindingSource(tip, null);
                comboBoxTip.DisplayMember = "Value";
                comboBoxTip.ValueMember = "Key";

                
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare Page Load Documente");
            }
            
        }
    }
}
