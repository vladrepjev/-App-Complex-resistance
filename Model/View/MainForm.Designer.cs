namespace View
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGridViewMainForm = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonRemoveElementMainForm = new System.Windows.Forms.Button();
            this.ButtonAddElementMainForm = new System.Windows.Forms.Button();
            this.SaveButtonMainForm = new System.Windows.Forms.Button();
            this.ButtonLoadMainForm = new System.Windows.Forms.Button();
            this.ButtonSearchMainForm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMainForm)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewMainForm
            // 
            this.DataGridViewMainForm.AllowUserToAddRows = false;
            this.DataGridViewMainForm.AllowUserToDeleteRows = false;
            this.DataGridViewMainForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMainForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DataGridViewMainForm.Location = new System.Drawing.Point(25, 35);
            this.DataGridViewMainForm.Name = "DataGridViewMainForm";
            this.DataGridViewMainForm.ReadOnly = true;
            this.DataGridViewMainForm.RowTemplate.Height = 28;
            this.DataGridViewMainForm.Size = new System.Drawing.Size(490, 280);
            this.DataGridViewMainForm.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "ElectricalElementName";
            this.Column1.HeaderText = "Название элемента";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "ElectricalElementValueComlex";
            this.Column2.HeaderText = "Комплексное значение";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ButtonRemoveElementMainForm
            // 
            this.ButtonRemoveElementMainForm.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonRemoveElementMainForm.Location = new System.Drawing.Point(25, 335);
            this.ButtonRemoveElementMainForm.Name = "ButtonRemoveElementMainForm";
            this.ButtonRemoveElementMainForm.Size = new System.Drawing.Size(170, 60);
            this.ButtonRemoveElementMainForm.TabIndex = 3;
            this.ButtonRemoveElementMainForm.Text = "Удалить элемент";
            this.ButtonRemoveElementMainForm.UseVisualStyleBackColor = false;
            this.ButtonRemoveElementMainForm.Click += new System.EventHandler(this.ButtonRemoveElementMainForm_Click);
            // 
            // ButtonAddElementMainForm
            // 
            this.ButtonAddElementMainForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonAddElementMainForm.Location = new System.Drawing.Point(215, 335);
            this.ButtonAddElementMainForm.Name = "ButtonAddElementMainForm";
            this.ButtonAddElementMainForm.Size = new System.Drawing.Size(300, 60);
            this.ButtonAddElementMainForm.TabIndex = 5;
            this.ButtonAddElementMainForm.Text = "Добавить элемент";
            this.ButtonAddElementMainForm.UseVisualStyleBackColor = false;
            this.ButtonAddElementMainForm.Click += new System.EventHandler(this.ButtonAddElementMainForm_Click);
            // 
            // SaveButtonMainForm
            // 
            this.SaveButtonMainForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SaveButtonMainForm.Location = new System.Drawing.Point(25, 25);
            this.SaveButtonMainForm.Name = "SaveButtonMainForm";
            this.SaveButtonMainForm.Size = new System.Drawing.Size(160, 40);
            this.SaveButtonMainForm.TabIndex = 6;
            this.SaveButtonMainForm.Text = "Сохранить";
            this.SaveButtonMainForm.UseVisualStyleBackColor = false;
            this.SaveButtonMainForm.Click += new System.EventHandler(this.SaveButtonMainForm_Click);
            // 
            // ButtonLoadMainForm
            // 
            this.ButtonLoadMainForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonLoadMainForm.Location = new System.Drawing.Point(195, 25);
            this.ButtonLoadMainForm.Name = "ButtonLoadMainForm";
            this.ButtonLoadMainForm.Size = new System.Drawing.Size(160, 40);
            this.ButtonLoadMainForm.TabIndex = 7;
            this.ButtonLoadMainForm.Text = "Загрузить";
            this.ButtonLoadMainForm.UseVisualStyleBackColor = false;
            this.ButtonLoadMainForm.Click += new System.EventHandler(this.ButtonLoadMainForm_Click);
            // 
            // ButtonSearchMainForm
            // 
            this.ButtonSearchMainForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonSearchMainForm.Location = new System.Drawing.Point(438, 25);
            this.ButtonSearchMainForm.Name = "ButtonSearchMainForm";
            this.ButtonSearchMainForm.Size = new System.Drawing.Size(127, 40);
            this.ButtonSearchMainForm.TabIndex = 8;
            this.ButtonSearchMainForm.Text = "Найти";
            this.ButtonSearchMainForm.UseVisualStyleBackColor = false;
            this.ButtonSearchMainForm.Click += new System.EventHandler(this.ButtonSearchMainForm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonAddElementMainForm);
            this.groupBox1.Controls.Add(this.ButtonRemoveElementMainForm);
            this.groupBox1.Controls.Add(this.DataGridViewMainForm);
            this.groupBox1.Location = new System.Drawing.Point(25, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 420);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonSearchMainForm);
            this.Controls.Add(this.ButtonLoadMainForm);
            this.Controls.Add(this.SaveButtonMainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вариант 7";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMainForm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewMainForm;
        private System.Windows.Forms.Button ButtonRemoveElementMainForm;
        private System.Windows.Forms.Button ButtonAddElementMainForm;
        private System.Windows.Forms.Button SaveButtonMainForm;
        private System.Windows.Forms.Button ButtonLoadMainForm;
        private System.Windows.Forms.Button ButtonSearchMainForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;

    }
}

