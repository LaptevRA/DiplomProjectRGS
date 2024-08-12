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

namespace МодульПросмотраДанных
{
    public partial class AddOperations : Form
    {
        public AddOperations()
        {
            InitializeComponent();
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ChronometerDB.mdf;Integrated Security=True;Connect Timeout=30");
                sql.Open();
                string query = "Insert into Operations (НаименованиеОперации) values (@NameOperation)";
                SqlCommand command = new SqlCommand(query, sql);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@NameOperation", NameOperation.Text);
                int count = Convert.ToInt32(command.ExecuteScalar());
                MessageBox.Show("Операция добавлена");
                sql.Close();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
