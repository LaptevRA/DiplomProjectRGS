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

namespace Chronometer
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ChronometerDB.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void WorkersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chronometerDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chronometerDBDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.chronometerDBDataSet.Workers);
        }

        public void Авторизация_Click(object sender, EventArgs e)
        {
            
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                string query = "SELECT COUNT(1) FROM Workers WHERE ФИО=@ФИО";
                SqlCommand sqlCmd = new SqlCommand(query, con);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@ФИО", фИОComboBox.Text);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    this.Hide();
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Show();
                    stopwatch.User.Text = фИОComboBox.Text;
                }
            }
        }
    }
}
