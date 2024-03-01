namespace View
{
    partial class AddForm
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
            this.ComboBoxNameAddForm = new System.Windows.Forms.ComboBox();
            this.LabelNameAddForm = new System.Windows.Forms.Label();
            this.LableValueAddForm = new System.Windows.Forms.Label();
            this.TextBoxValueAddForm = new System.Windows.Forms.TextBox();
            this.ButtonCancelAddForm = new System.Windows.Forms.Button();
            this.ButtonAddElementAddForm = new System.Windows.Forms.Button();
            this.ButtonRandomValueAddForm = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxNameAddForm
            // 
            this.ComboBoxNameAddForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxNameAddForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxNameAddForm.FormattingEnabled = true;
            this.ComboBoxNameAddForm.Items.AddRange(new object[] {
            "Резистор",
            "Кондесатор",
            "Катушка идуктивности"});
            this.ComboBoxNameAddForm.Location = new System.Drawing.Point(130, 25);
            this.ComboBoxNameAddForm.Name = "ComboBoxNameAddForm";
            this.ComboBoxNameAddForm.Size = new System.Drawing.Size(343, 37);
            this.ComboBoxNameAddForm.TabIndex = 0;
            this.ComboBoxNameAddForm.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNameAddForm_SelectedIndexChanged);
            // 
            // LabelNameAddForm
            // 
            this.LabelNameAddForm.AutoSize = true;
            this.LabelNameAddForm.Location = new System.Drawing.Point(25, 33);
            this.LabelNameAddForm.Name = "LabelNameAddForm";
            this.LabelNameAddForm.Size = new System.Drawing.Size(83, 20);
            this.LabelNameAddForm.TabIndex = 2;
            this.LabelNameAddForm.Text = "Название";
            // 
            // LableValueAddForm
            // 
            this.LableValueAddForm.AutoSize = true;
            this.LableValueAddForm.Location = new System.Drawing.Point(25, 90);
            this.LableValueAddForm.Name = "LableValueAddForm";
            this.LableValueAddForm.Size = new System.Drawing.Size(83, 20);
            this.LableValueAddForm.TabIndex = 3;
            this.LableValueAddForm.Text = "Значение";
            // 
            // TextBoxValueAddForm
            // 
            this.TextBoxValueAddForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxValueAddForm.Location = new System.Drawing.Point(130, 80);
            this.TextBoxValueAddForm.Name = "TextBoxValueAddForm";
            this.TextBoxValueAddForm.Size = new System.Drawing.Size(343, 35);
            this.TextBoxValueAddForm.TabIndex = 4;
            this.TextBoxValueAddForm.TextChanged += new System.EventHandler(this.TextBoxValueAddForm_TextChanged);
            // 
            // ButtonCancelAddForm
            // 
            this.ButtonCancelAddForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonCancelAddForm.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonCancelAddForm.Location = new System.Drawing.Point(25, 280);
            this.ButtonCancelAddForm.Name = "ButtonCancelAddForm";
            this.ButtonCancelAddForm.Size = new System.Drawing.Size(170, 60);
            this.ButtonCancelAddForm.TabIndex = 6;
            this.ButtonCancelAddForm.Text = "Отменить";
            this.ButtonCancelAddForm.UseVisualStyleBackColor = false;
            this.ButtonCancelAddForm.Click += new System.EventHandler(this.ButtonCancelAddForm_Click);
            // 
            // ButtonAddElementAddForm
            // 
            this.ButtonAddElementAddForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAddElementAddForm.Enabled = false;
            this.ButtonAddElementAddForm.Location = new System.Drawing.Point(213, 280);
            this.ButtonAddElementAddForm.Name = "ButtonAddElementAddForm";
            this.ButtonAddElementAddForm.Size = new System.Drawing.Size(260, 60);
            this.ButtonAddElementAddForm.TabIndex = 7;
            this.ButtonAddElementAddForm.Text = "Добавить";
            this.ButtonAddElementAddForm.UseVisualStyleBackColor = true;
            this.ButtonAddElementAddForm.Click += new System.EventHandler(this.ButtonAddElementAddForm_Click);
            // 
            // ButtonRandomValueAddForm
            // 
            this.ButtonRandomValueAddForm.Location = new System.Drawing.Point(25, 210);
            this.ButtonRandomValueAddForm.Name = "ButtonRandomValueAddForm";
            this.ButtonRandomValueAddForm.Size = new System.Drawing.Size(448, 60);
            this.ButtonRandomValueAddForm.TabIndex = 8;
            this.ButtonRandomValueAddForm.Text = "Случайный элемент";
            this.ButtonRandomValueAddForm.UseVisualStyleBackColor = true;
            this.ButtonRandomValueAddForm.Click += new System.EventHandler(this.ButtonRandomValueAddForm_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(36, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 24);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(185, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(126, 24);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(333, 25);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(126, 24);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(29, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 63);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 364);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonRandomValueAddForm);
            this.Controls.Add(this.ButtonAddElementAddForm);
            this.Controls.Add(this.ButtonCancelAddForm);
            this.Controls.Add(this.TextBoxValueAddForm);
            this.Controls.Add(this.LableValueAddForm);
            this.Controls.Add(this.LabelNameAddForm);
            this.Controls.Add(this.ComboBoxNameAddForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление элемента";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxNameAddForm;
        private System.Windows.Forms.Label LabelNameAddForm;
        private System.Windows.Forms.Label LableValueAddForm;
        private System.Windows.Forms.TextBox TextBoxValueAddForm;
        private System.Windows.Forms.Button ButtonCancelAddForm;
        private System.Windows.Forms.Button ButtonAddElementAddForm;
        private System.Windows.Forms.Button ButtonRandomValueAddForm;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}