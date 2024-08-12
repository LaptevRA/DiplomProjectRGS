namespace МодульПросмотраДанных
{
    partial class FilterByWorkers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label фИОLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterByWorkers));
            this.chronometerDBDataSet = new МодульПросмотраДанных.ChronometerDBDataSet();
            this.resultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultsTableAdapter = new МодульПросмотраДанных.ChronometerDBDataSetTableAdapters.ResultsTableAdapter();
            this.tableAdapterManager = new МодульПросмотраДанных.ChronometerDBDataSetTableAdapters.TableAdapterManager();
            this.workersTableAdapter = new МодульПросмотраДанных.ChronometerDBDataSetTableAdapters.WorkersTableAdapter();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фИОComboBox = new System.Windows.Forms.ComboBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            фИОLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chronometerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
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
            // chronometerDBDataSet
            // 
            this.chronometerDBDataSet.DataSetName = "ChronometerDBDataSet";
            this.chronometerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultsBindingSource
            // 
            this.resultsBindingSource.DataMember = "Results";
            this.resultsBindingSource.DataSource = this.chronometerDBDataSet;
            // 
            // resultsTableAdapter
            // 
            this.resultsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OperationsTableAdapter = null;
            this.tableAdapterManager.ResultsTableAdapter = this.resultsTableAdapter;
            this.tableAdapterManager.UpdateOrder = МодульПросмотраДанных.ChronometerDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = this.workersTableAdapter;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.AllowUserToAddRows = false;
            this.resultsDataGridView.AllowUserToDeleteRows = false;
            this.resultsDataGridView.AutoGenerateColumns = false;
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.resultsDataGridView.DataSource = this.resultsBindingSource;
            this.resultsDataGridView.Location = new System.Drawing.Point(12, 30);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.ReadOnly = true;
            this.resultsDataGridView.Size = new System.Drawing.Size(644, 381);
            this.resultsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ДатаВыполнения";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата Выполнения";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ВремяВыполнения";
            this.dataGridViewTextBoxColumn3.HeaderText = "Время Выполнения";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "НаименованиеОперации";
            this.dataGridViewTextBoxColumn4.HeaderText = "Наименование Операции";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 300;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ФИООператора";
            this.dataGridViewTextBoxColumn5.HeaderText = "ФИО Оператора";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.chronometerDBDataSet;
            // 
            // фИОComboBox
            // 
            this.фИОComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "ФИО", true));
            this.фИОComboBox.DataSource = this.workersBindingSource;
            this.фИОComboBox.DisplayMember = "ФИО";
            this.фИОComboBox.FormattingEnabled = true;
            this.фИОComboBox.Location = new System.Drawing.Point(55, 6);
            this.фИОComboBox.Name = "фИОComboBox";
            this.фИОComboBox.Size = new System.Drawing.Size(151, 21);
            this.фИОComboBox.TabIndex = 2;
            this.фИОComboBox.ValueMember = "Id";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(490, 417);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Вернуться";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(571, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Фильтровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // FilterByWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 451);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОComboBox);
            this.Controls.Add(this.resultsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FilterByWorkers";
            this.Text = "Фильтр по сотрудникам";
            this.Load += new System.EventHandler(this.SortByWorkers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chronometerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChronometerDBDataSet chronometerDBDataSet;
        private System.Windows.Forms.BindingSource resultsBindingSource;
        private ChronometerDBDataSetTableAdapters.ResultsTableAdapter resultsTableAdapter;
        private ChronometerDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView resultsDataGridView;
        private ChronometerDBDataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private System.Windows.Forms.ComboBox фИОComboBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button button2;
    }
}