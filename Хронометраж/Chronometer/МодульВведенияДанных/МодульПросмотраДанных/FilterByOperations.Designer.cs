namespace МодульПросмотраДанных
{
    partial class FilterByOperations
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
            System.Windows.Forms.Label наименованиеОперацииLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterByOperations));
            this.chronometerDBDataSet = new МодульПросмотраДанных.ChronometerDBDataSet();
            this.resultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultsTableAdapter = new МодульПросмотраДанных.ChronometerDBDataSetTableAdapters.ResultsTableAdapter();
            this.tableAdapterManager = new МодульПросмотраДанных.ChronometerDBDataSetTableAdapters.TableAdapterManager();
            this.operationsTableAdapter = new МодульПросмотраДанных.ChronometerDBDataSetTableAdapters.OperationsTableAdapter();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.наименованиеОперацииComboBox = new System.Windows.Forms.ComboBox();
            this.SortOperation = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            наименованиеОперацииLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chronometerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // наименованиеОперацииLabel
            // 
            наименованиеОперацииLabel.AutoSize = true;
            наименованиеОперацииLabel.Location = new System.Drawing.Point(12, 9);
            наименованиеОперацииLabel.Name = "наименованиеОперацииLabel";
            наименованиеОперацииLabel.Size = new System.Drawing.Size(139, 13);
            наименованиеОперацииLabel.TabIndex = 1;
            наименованиеОперацииLabel.Text = "Наименование Операции:";
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
            this.tableAdapterManager.OperationsTableAdapter = this.operationsTableAdapter;
            this.tableAdapterManager.ResultsTableAdapter = this.resultsTableAdapter;
            this.tableAdapterManager.UpdateOrder = МодульПросмотраДанных.ChronometerDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // operationsTableAdapter
            // 
            this.operationsTableAdapter.ClearBeforeFill = true;
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
            // operationsBindingSource
            // 
            this.operationsBindingSource.DataMember = "Operations";
            this.operationsBindingSource.DataSource = this.chronometerDBDataSet;
            // 
            // наименованиеОперацииComboBox
            // 
            this.наименованиеОперацииComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operationsBindingSource, "НаименованиеОперации", true));
            this.наименованиеОперацииComboBox.DataSource = this.operationsBindingSource;
            this.наименованиеОперацииComboBox.DisplayMember = "НаименованиеОперации";
            this.наименованиеОперацииComboBox.FormattingEnabled = true;
            this.наименованиеОперацииComboBox.Location = new System.Drawing.Point(157, 6);
            this.наименованиеОперацииComboBox.Name = "наименованиеОперацииComboBox";
            this.наименованиеОперацииComboBox.Size = new System.Drawing.Size(506, 21);
            this.наименованиеОперацииComboBox.TabIndex = 2;
            this.наименованиеОперацииComboBox.ValueMember = "Id";
            // 
            // SortOperation
            // 
            this.SortOperation.Location = new System.Drawing.Point(571, 417);
            this.SortOperation.Name = "SortOperation";
            this.SortOperation.Size = new System.Drawing.Size(84, 23);
            this.SortOperation.TabIndex = 3;
            this.SortOperation.Text = "Фильтровать";
            this.SortOperation.UseVisualStyleBackColor = true;
            this.SortOperation.Click += new System.EventHandler(this.SortOperation_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(490, 417);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Вернуться";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // FilterByOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 451);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SortOperation);
            this.Controls.Add(наименованиеОперацииLabel);
            this.Controls.Add(this.наименованиеОперацииComboBox);
            this.Controls.Add(this.resultsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FilterByOperations";
            this.Text = "Фильтр по операциям";
            this.Load += new System.EventHandler(this.SortByOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chronometerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChronometerDBDataSet chronometerDBDataSet;
        private System.Windows.Forms.BindingSource resultsBindingSource;
        private ChronometerDBDataSetTableAdapters.ResultsTableAdapter resultsTableAdapter;
        private ChronometerDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ChronometerDBDataSetTableAdapters.OperationsTableAdapter operationsTableAdapter;
        private System.Windows.Forms.DataGridView resultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource operationsBindingSource;
        private System.Windows.Forms.ComboBox наименованиеОперацииComboBox;
        private System.Windows.Forms.Button SortOperation;
        private System.Windows.Forms.Button BackButton;
    }
}