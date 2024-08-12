namespace МодульПросмотраДанных
{
    partial class Report
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.Operations = new System.Windows.Forms.Button();
            this.OperationSort = new System.Windows.Forms.RadioButton();
            this.WorkersSort = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Operations
            // 
            this.Operations.Location = new System.Drawing.Point(12, 12);
            this.Operations.Name = "Operations";
            this.Operations.Size = new System.Drawing.Size(75, 40);
            this.Operations.TabIndex = 0;
            this.Operations.Text = "Справочник операции";
            this.Operations.UseVisualStyleBackColor = true;
            this.Operations.Click += new System.EventHandler(this.Operations_Click);
            // 
            // OperationSort
            // 
            this.OperationSort.AutoSize = true;
            this.OperationSort.Checked = true;
            this.OperationSort.Location = new System.Drawing.Point(164, 12);
            this.OperationSort.Name = "OperationSort";
            this.OperationSort.Size = new System.Drawing.Size(98, 17);
            this.OperationSort.TabIndex = 1;
            this.OperationSort.TabStop = true;
            this.OperationSort.Text = "По операциям";
            this.OperationSort.UseVisualStyleBackColor = true;
            // 
            // WorkersSort
            // 
            this.WorkersSort.AutoSize = true;
            this.WorkersSort.Location = new System.Drawing.Point(164, 35);
            this.WorkersSort.Name = "WorkersSort";
            this.WorkersSort.Size = new System.Drawing.Size(108, 17);
            this.WorkersSort.TabIndex = 2;
            this.WorkersSort.Text = "По сотрудникам";
            this.WorkersSort.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Отчетность";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Сортировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 93);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WorkersSort);
            this.Controls.Add(this.OperationSort);
            this.Controls.Add(this.Operations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.Text = "Отчетность";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Operations;
        private System.Windows.Forms.RadioButton OperationSort;
        private System.Windows.Forms.RadioButton WorkersSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

