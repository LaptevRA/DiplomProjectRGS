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
    public partial class FilterByWorkers : Form
    {
        public FilterByWorkers()
        {
            InitializeComponent();
        }

        private void ResultsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.resultsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chronometerDBDataSet);

        }

        private void SortByWorkers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chronometerDBDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.chronometerDBDataSet.Workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chronometerDBDataSet.Results". При необходимости она может быть перемещена или удалена.
            this.resultsTableAdapter.Fill(this.chronometerDBDataSet.Results);

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ChronometerDB.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                con.Open();
                string queryIns = "Select * From Results where ФИООператора=@Operators";
                SqlCommand command = new SqlCommand(queryIns, con);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@Operators",фИОComboBox.Text);
                int count = Convert.ToInt32(command.ExecuteScalar());
                this.resultsTableAdapter.FillBy(this.chronometerDBDataSet.Results, фИОComboBox.Text);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
