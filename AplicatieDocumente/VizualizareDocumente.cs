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
    public partial class VizualizareDocumente : Form
    {
        public VizualizareDocumente()
        {
            InitializeComponent();
        }

        private void buttonSpreMeniu_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void VizualizareDocumente_Load(object sender, EventArgs e)
        {
            try
            {
                IncarcareGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare Incarcare grid");
            }
        }

        public void IncarcareGrid()
        {
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            Database databaseObject= new Database();
            databaseObject.OpenConnection();
            string query = "SELECT * from Inregistrari";
            SqlCommand sel = new SqlCommand(query, databaseObject.myConnection);
           

            SqlDataAdapter daquery = new SqlDataAdapter(sel);
            DataTable dttab = new DataTable();
            daquery.Fill(dttab);
            dataGridView1.DataSource = dttab;
            

            databaseObject.CloseConnection();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                IncarcareGrid();
                MessageBox.Show("Refresh grid reusit");
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare Incarcare grid");
            }
        }
    }
}
