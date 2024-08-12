using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chronometer
{
    public partial class Stopwatch : Form
    {
        bool paused;
        DateTime start;

        public bool Paused { get => paused; set => paused = value; }

        public Stopwatch()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e) //Кнопка старта секундомера
        {
            start = DateTime.Now;
            TimeLabel.Text = "00:00:00";
            timer1.Enabled = true;
            StartButton.Enabled = false;
            PauseButton.Enabled = true;
            

        }

        private void Timer1_Tick(object sender, EventArgs e) //Функция работы секундомера
        {
            if (Paused) return;
            TimeSpan timer = (DateTime.Now - start).Duration();
            TimeLabel.Text = timer.ToString(@"hh\:mm\:ss");
        }

        private void StopButton_Click(object sender, EventArgs e) //Кнопка остановки работы секундомера
        {
            timer1.Enabled = false;
            StartButton.Enabled = true;
            PauseButton.Enabled = false;
            SaveButton.Enabled = true;
        }

        private void SaveButton_Click(object sender, EventArgs e) //Кнопка сохранения результата
        {
            DialogResult result = MessageBox.Show("Сохранить результат?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Results results = new Results();
                results.Time.Text = TimeLabel.Text;
                results.User.Text = User.Text;
                results.ShowDialog();
                this.Hide();
            }
            else
            {
                this.Show();
                SaveButton.Enabled = false;
            }

        }
    }

}
