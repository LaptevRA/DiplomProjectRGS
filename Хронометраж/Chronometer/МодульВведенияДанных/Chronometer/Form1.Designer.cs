namespace Chronometer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label направлениеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chronometerDBDataSet = new Chronometer.ChronometerDBDataSet();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new Chronometer.ChronometerDBDataSetTableAdapters.WorkersTableAdapter();
            this.tableAdapterManager = new Chronometer.ChronometerDBDataSetTableAdapters.TableAdapterManager();
            this.фИОComboBox = new System.Windows.Forms.ComboBox();
            this.направлениеTextBox = new System.Windows.Forms.TextBox();
            this.Авторизация = new System.Windows.Forms.Button();
            фИОLabel = new System.Windows.Forms.Label();
            направлениеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chronometerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(12, 9);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 1;
            фИОLabel.Text = "ФИО:";
            // 
            // направлениеLabel
            // 
            направлениеLabel.AutoSize = true;
            направлениеLabel.Location = new System.Drawing.Point(12, 36);
            направлениеLabel.Name = "направлениеLabel";
            направлениеLabel.Size = new System.Drawing.Size(78, 13);
            направлениеLabel.TabIndex = 2;
            направлениеLabel.Text = "Направление:";
            // 
            // chronometerDBDataSet
            // 
            this.chronometerDBDataSet.DataSetName = "ChronometerDBDataSet";
            this.chronometerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.chronometerDBDataSet;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Chronometer.ChronometerDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = this.workersTableAdapter;
            // 
            // фИОComboBox
            // 
            this.фИОComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "ФИО", true));
            this.фИОComboBox.DataSource = this.workersBindingSource;
            this.фИОComboBox.DisplayMember = "ФИО";
            this.фИОComboBox.FormattingEnabled = true;
            this.фИОComboBox.Location = new System.Drawing.Point(55, 6);
            this.фИОComboBox.MaxLength = 50;
            this.фИОComboBox.Name = "фИОComboBox";
            this.фИОComboBox.Size = new System.Drawing.Size(177, 21);
            this.фИОComboBox.TabIndex = 2;
            this.фИОComboBox.ValueMember = "Id";
            // 
            // направлениеTextBox
            // 
            this.направлениеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Направление", true));
            this.направлениеTextBox.Enabled = false;
            this.направлениеTextBox.Location = new System.Drawing.Point(96, 33);
            this.направлениеTextBox.Name = "направлениеTextBox";
            this.направлениеTextBox.Size = new System.Drawing.Size(136, 20);
            this.направлениеTextBox.TabIndex = 3;
            // 
            // Авторизация
            // 
            this.Авторизация.Location = new System.Drawing.Point(157, 59);
            this.Авторизация.Name = "Авторизация";
            this.Авторизация.Size = new System.Drawing.Size(75, 23);
            this.Авторизация.TabIndex = 4;
            this.Авторизация.Text = "Войти";
            this.Авторизация.UseVisualStyleBackColor = true;
            this.Авторизация.Click += new System.EventHandler(this.Авторизация_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 90);
            this.Controls.Add(this.Авторизация);
            this.Controls.Add(направлениеLabel);
            this.Controls.Add(this.направлениеTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chronometerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChronometerDBDataSet chronometerDBDataSet;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private ChronometerDBDataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private ChronometerDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox фИОComboBox;
        private System.Windows.Forms.TextBox направлениеTextBox;
        private System.Windows.Forms.Button Авторизация;
    }
}

