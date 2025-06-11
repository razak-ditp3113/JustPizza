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
    public partial class FormHexagonPizza : Form
    {
        public FormHexagonPizza()
        {
            InitializeComponent();
        }

        private void FormHexagonPizza_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\source\\repos\\JustPizza\\JustPizza\\JustPizzaDatabase.mdf;Integrated Security=True";
            string query = "SELECT * FROM Pizza WHERE PizzaID LIKE 'HP%'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Pizza");

                dataGridViewHexagonPizza.DataSource = dataSet.Tables["Pizza"];
            }
        }
    }
}
