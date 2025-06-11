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
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;

        public FormCirclePizza()
        {
            InitializeComponent();

            // Initialize the connection object
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\source\\repos\\JustPizza\\JustPizza\\JustPizzaDatabase.mdf;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void FormCirclePizza_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadData()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\source\\repos\\JustPizza\\JustPizza\\JustPizzaDatabase.mdf;Integrated Security=True";
            string query = "SELECT * FROM Pizza WHERE PizzaID LIKE 'CP%' ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Pizza");

                dataGridViewCirclePizza.DataSource = dataSet.Tables["Pizza"];
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string query = "INSERT INTO Pizza (PizzaID, Description, Dimension, Price) VALUES (@PizzaID, @Description, @Dimension, @Price)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PizzaID", textBoxCPizzaID.Text);
                    command.Parameters.AddWithValue("@Description", textBoxCPDescription.Text);
                    command.Parameters.AddWithValue("@Dimension", textBoxCPDimension.Text);
                    command.Parameters.AddWithValue("@Price", textBoxCPPrice.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadData();
                ClearInputs();
            }

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string query = "UPDATE Pizza SET Description = @Description, Dimension = @Dimension, Price = @Price WHERE PizzaID = @PizzaID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PizzaID", textBoxCPizzaID.Text);
                    command.Parameters.AddWithValue("@Description", textBoxCPDescription.Text);
                    command.Parameters.AddWithValue("@Dimension", textBoxCPDimension.Text);
                    command.Parameters.AddWithValue("@Price", textBoxCPPrice.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadData();
                ClearInputs();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(textBoxCPizzaID.Text) || string.IsNullOrEmpty(textBoxCPDescription.Text) ||
                string.IsNullOrEmpty(textBoxCPDimension.Text) || string.IsNullOrEmpty(textBoxCPPrice.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            return true;
        }

        private void ClearInputs()
        {
            textBoxCPizzaID.Clear();
            textBoxCPDescription.Clear();
            textBoxCPDimension.Clear();
            textBoxCPPrice.Clear();
        }

    }
}
