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
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }

        private void OperationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.operationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chronometerDBDataSet);

        }

        private void Results_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chronometerDBDataSet.Operations". При необходимости она может быть перемещена или удалена.
            this.operationsTableAdapter.Fill(this.chronometerDBDataSet.Operations);

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Show();
            stopwatch.User.Text = User.Text;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string time = Time.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ChronometerDB.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                con.Open();
                string query = "SELECT COUNT(1) FROM Operations WHERE НаименованиеОперации=@Operations";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Operations", наименованиеОперацииComboBox.Text);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    string queryIns = "Insert into Results (ДатаВыполнения,ВремяВыполнения,НаименованиеОперации,ФИООператора)" +
                         "values (@Date,@Time,@Operations,@Operator)";
                    SqlCommand command = new SqlCommand(queryIns, con);
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@Date", DateTime.Now);
                    command.Parameters.AddWithValue("@Time", Time.Text);
                    command.Parameters.AddWithValue("@Operator", User.Text);
                    command.Parameters.AddWithValue("@Operations", наименованиеОперацииComboBox.Text);
                    count = Convert.ToInt32(command.ExecuteScalar());
                    MessageBox.Show("Результат сохранен");
                    this.Hide();
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
