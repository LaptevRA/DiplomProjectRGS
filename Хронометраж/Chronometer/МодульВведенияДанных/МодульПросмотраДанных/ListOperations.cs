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
    public partial class ListOperations : Form
    {
        public ListOperations()
        {
            InitializeComponent();
        }

        private void OperationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.operationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chronometerDBDataSet);

        }

        private void ListOperations_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chronometerDBDataSet.Operations". При необходимости она может быть перемещена или удалена.
            this.operationsTableAdapter.Fill(this.chronometerDBDataSet.Operations);

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddOperations add = new AddOperations();
            add.ShowDialog();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            this.operationsTableAdapter.Fill(this.chronometerDBDataSet.Operations);
        }
    }
}
