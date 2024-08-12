namespace Chronometer
{
    partial class Results
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Results));
            this.label1 = new System.Windows.Forms.Label();
            this.chronometerDBDataSet = new Chronometer.ChronometerDBDataSet();
            this.operationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operationsTableAdapter = new Chronometer.ChronometerDBDataSetTableAdapters.OperationsTableAdapter();
            this.tableAdapterManager = new Chronometer.ChronometerDBDataSetTableAdapters.TableAdapterManager();
            this.наименованиеОперацииComboBox = new System.Windows.Forms.ComboBox();
            this.Time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            наименованиеОперацииLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chronometerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // наименованиеОперацииLabel
            // 
            наименованиеОперацииLabel.AutoSize = true;
            наименованиеОперацииLabel.Location = new System.Drawing.Point(8, 15);
            наименованиеОперацииLabel.Name = "наименованиеОперацииLabel";
            наименованиеОперацииLabel.Size = new System.Drawing.Size(139, 13);
            наименованиеОперацииLabel.TabIndex = 2;
            наименованиеОперацииLabel.Text = "Наименование Операции:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Результат:";
            // 
            // chronometerDBDataSet
            // 
            this.chronometerDBDataSet.DataSetName = "ChronometerDBDataSet";
            this.chronometerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operationsBindingSource
            // 
            this.operationsBindingSource.DataMember = "Operations";
            this.operationsBindingSource.DataSource = this.chronometerDBDataSet;
            // 
            // operationsTableAdapter
            // 
            this.operationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OperationsTableAdapter = this.operationsTableAdapter;
            this.tableAdapterManager.ResultsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Chronometer.ChronometerDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // наименованиеОперацииComboBox
            // 
            this.наименованиеОперацииComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operationsBindingSource, "НаименованиеОперации", true));
            this.наименованиеОперацииComboBox.DataSource = this.operationsBindingSource;
            this.наименованиеОперацииComboBox.DisplayMember = "НаименованиеОперации";
            this.наименованиеОперацииComboBox.FormattingEnabled = true;
            this.наименованиеОперацииComboBox.Location = new System.Drawing.Point(154, 12);
            this.наименованиеОперацииComboBox.Name = "наименованиеОперацииComboBox";
            this.наименованиеОперацииComboBox.Size = new System.Drawing.Size(182, 21);
            this.наименованиеОперацииComboBox.TabIndex = 3;
            this.наименованиеОперацииComboBox.ValueMember = "Id";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(70, 44);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(0, 13);
            this.Time.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пользователь:";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(92, 70);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(0, 13);
            this.User.TabIndex = 6;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(180, 86);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton.TabIndex = 7;
            this.ReturnButton.Text = "Вернуться";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(261, 86);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 119);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Time);
            this.Controls.Add(наименованиеОперацииLabel);
            this.Controls.Add(this.наименованиеОперацииComboBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Results";
            this.Text = "Сохранение результата";
            this.Load += new System.EventHandler(this.Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chronometerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ChronometerDBDataSet chronometerDBDataSet;
        private System.Windows.Forms.BindingSource operationsBindingSource;
        private ChronometerDBDataSetTableAdapters.OperationsTableAdapter operationsTableAdapter;
        private ChronometerDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox наименованиеОперацииComboBox;
        public System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label User;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button SaveButton;
    }
}