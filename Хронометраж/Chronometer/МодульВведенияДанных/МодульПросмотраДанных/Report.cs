using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace МодульПросмотраДанных
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Operations_Click(object sender, EventArgs e)
        {
            ListOperations ListOperations = new ListOperations();
            ListOperations.ShowDialog();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (OperationSort.Checked==true)
            {
                WorkersSort.Checked = false;
                FilterByOperations byOperations = new FilterByOperations();
                byOperations.ShowDialog();
            }
            if (WorkersSort.Checked==true)
            {
                OperationSort.Checked = false;
                FilterByWorkers byWorkers = new FilterByWorkers();
                byWorkers.ShowDialog();
            }
        }
    }
}
