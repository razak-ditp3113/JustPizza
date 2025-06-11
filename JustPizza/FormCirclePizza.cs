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

namespace JustPizza
{
    public partial class FormCirclePizza : Form
    {
        public FormCirclePizza()
        {
            InitializeComponent();
        }

        private void FormCirclePizza_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadData()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\source\\repos\\JustPizza\\JustPizza\\JustPizzaDatabase.mdf;Integrated Security=True";
            string query = "SELECT * FROM Pizza WHERE PizzaID LIKE 'CP%'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Pizza");

                dataGridViewCirclePizza.DataSource = dataSet.Tables["Pizza"];
            }
        }


    }
}
