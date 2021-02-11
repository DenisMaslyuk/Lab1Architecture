namespace ViewWin
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.AddEmp = new System.Windows.Forms.Button();
            this.DeleteEmp = new System.Windows.Forms.Button();
            this.ChangePosition = new System.Windows.Forms.Button();
            this.GridEmp = new System.Windows.Forms.DataGridView();
            this.AvgAge = new System.Windows.Forms.Button();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddEmp
            // 
            this.AddEmp.Location = new System.Drawing.Point(11, 285);
            this.AddEmp.Margin = new System.Windows.Forms.Padding(2);
            this.AddEmp.Name = "AddEmp";
            this.AddEmp.Size = new System.Drawing.Size(134, 31);
            this.AddEmp.TabIndex = 1;
            this.AddEmp.Text = "Добавить";
            this.AddEmp.UseVisualStyleBackColor = true;
            this.AddEmp.Click += new System.EventHandler(this.AddEmp_Click);
            // 
            // DeleteEmp
            // 
            this.DeleteEmp.Location = new System.Drawing.Point(304, 285);
            this.DeleteEmp.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteEmp.Name = "DeleteEmp";
            this.DeleteEmp.Size = new System.Drawing.Size(118, 31);
            this.DeleteEmp.TabIndex = 2;
            this.DeleteEmp.Text = "Удалить";
            this.DeleteEmp.UseVisualStyleBackColor = true;
            this.DeleteEmp.Click += new System.EventHandler(this.DeleteEmp_Click);
            // 
            // ChangePosition
            // 
            this.ChangePosition.Location = new System.Drawing.Point(149, 285);
            this.ChangePosition.Margin = new System.Windows.Forms.Padding(2);
            this.ChangePosition.Name = "ChangePosition";
            this.ChangePosition.Size = new System.Drawing.Size(151, 31);
            this.ChangePosition.TabIndex = 4;
            this.ChangePosition.Text = "Изменить";
            this.ChangePosition.UseVisualStyleBackColor = true;
            this.ChangePosition.Click += new System.EventHandler(this.ChangePosition_Click);
            // 
            // GridEmp
            // 
            this.GridEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridEmp.Location = new System.Drawing.Point(0, 0);
            this.GridEmp.Margin = new System.Windows.Forms.Padding(2);
            this.GridEmp.Name = "GridEmp";
            this.GridEmp.RowTemplate.Height = 24;
            this.GridEmp.Size = new System.Drawing.Size(710, 281);
            this.GridEmp.TabIndex = 5;
            this.GridEmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AvgAge
            // 
            this.AvgAge.Location = new System.Drawing.Point(426, 285);
            this.AvgAge.Margin = new System.Windows.Forms.Padding(2);
            this.AvgAge.Name = "AvgAge";
            this.AvgAge.Size = new System.Drawing.Size(118, 31);
            this.AvgAge.TabIndex = 6;
            this.AvgAge.Text = "Средний возраст";
            this.AvgAge.UseVisualStyleBackColor = true;
            this.AvgAge.Click += new System.EventHandler(this.AvgAge_Click);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Model.Employee);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 337);
            this.Controls.Add(this.AvgAge);
            this.Controls.Add(this.GridEmp);
            this.Controls.Add(this.ChangePosition);
            this.Controls.Add(this.DeleteEmp);
            this.Controls.Add(this.AddEmp);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.GridEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddEmp;
        private System.Windows.Forms.DataGridView GridEmp;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        public System.Windows.Forms.Button DeleteEmp;
        public System.Windows.Forms.Button ChangePosition;
        public System.Windows.Forms.Button AvgAge;
    }
}

