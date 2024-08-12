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
    public partial class FilterByOperations : Form
    {
        public FilterByOperations()
        {
            InitializeComponent();
        }

        private void ResultsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.resultsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chronometerDBDataSet);

        }

        private void SortByOperations_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chronometerDBDataSet.Operations". При необходимости она может быть перемещена или удалена.
            this.operationsTableAdapter.Fill(this.chronometerDBDataSet.Operations);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chronometerDBDataSet.Results". При необходимости она может быть перемещена или удалена.
            this.resultsTableAdapter.Fill(this.chronometerDBDataSet.Results);

        }

        private void SortOperation_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ChronometerDB.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                con.Open();

                string queryIns = "Select * From Results where НаименованиеОперации=@Operations";
                SqlCommand command = new SqlCommand(queryIns, con);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@Operations",наименованиеОперацииComboBox.Text);
                int count = Convert.ToInt32(command.ExecuteScalar());
                this.resultsTableAdapter.FillBy1(this.chronometerDBDataSet.Results, наименованиеОперацииComboBox.Text);
                MessageBox.Show("Отсортировано");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
