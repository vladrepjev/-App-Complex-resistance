namespace View
{
    partial class SearchFrom
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
            this.ButtonSearchElementSearchForm = new System.Windows.Forms.Button();
            this.ButtonCancelSearchForm = new System.Windows.Forms.Button();
            this.TextBoxValueSearchForm = new System.Windows.Forms.TextBox();
            this.LableValueSearchForm = new System.Windows.Forms.Label();
            this.LabelNameSearchForm = new System.Windows.Forms.Label();
            this.ComboBoxNameSearchForm = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ButtonSearchElementSearchForm
            // 
            this.ButtonSearchElementSearchForm.Location = new System.Drawing.Point(213, 160);
            this.ButtonSearchElementSearchForm.Name = "ButtonSearchElementSearchForm";
            this.ButtonSearchElementSearchForm.Size = new System.Drawing.Size(260, 60);
            this.ButtonSearchElementSearchForm.TabIndex = 13;
            this.ButtonSearchElementSearchForm.Text = "Найти";
            this.ButtonSearchElementSearchForm.UseVisualStyleBackColor = true;
            this.ButtonSearchElementSearchForm.Click += new System.EventHandler(this.ButtonSearchElementSearchForm_Click);
            // 
            // ButtonCancelSearchForm
            // 
            this.ButtonCancelSearchForm.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonCancelSearchForm.Location = new System.Drawing.Point(29, 160);
            this.ButtonCancelSearchForm.Name = "ButtonCancelSearchForm";
            this.ButtonCancelSearchForm.Size = new System.Drawing.Size(170, 60);
            this.ButtonCancelSearchForm.TabIndex = 12;
            this.ButtonCancelSearchForm.Text = "Отменить";
            this.ButtonCancelSearchForm.UseVisualStyleBackColor = false;
            this.ButtonCancelSearchForm.Click += new System.EventHandler(this.ButtonCancelSearchForm_Click);
            // 
            // TextBoxValueSearchForm
            // 
            this.TextBoxValueSearchForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxValueSearchForm.Location = new System.Drawing.Point(130, 80);
            this.TextBoxValueSearchForm.Name = "TextBoxValueSearchForm";
            this.TextBoxValueSearchForm.Size = new System.Drawing.Size(343, 35);
            this.TextBoxValueSearchForm.TabIndex = 11;
            // 
            // LableValueSearchForm
            // 
            this.LableValueSearchForm.AutoSize = true;
            this.LableValueSearchForm.Location = new System.Drawing.Point(25, 90);
            this.LableValueSearchForm.Name = "LableValueSearchForm";
            this.LableValueSearchForm.Size = new System.Drawing.Size(83, 20);
            this.LableValueSearchForm.TabIndex = 10;
            this.LableValueSearchForm.Text = "Значение";
            // 
            // LabelNameSearchForm
            // 
            this.LabelNameSearchForm.AutoSize = true;
            this.LabelNameSearchForm.Location = new System.Drawing.Point(25, 33);
            this.LabelNameSearchForm.Name = "LabelNameSearchForm";
            this.LabelNameSearchForm.Size = new System.Drawing.Size(83, 20);
            this.LabelNameSearchForm.TabIndex = 9;
            this.LabelNameSearchForm.Text = "Название";
            // 
            // ComboBoxNameSearchForm
            // 
            this.ComboBoxNameSearchForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxNameSearchForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxNameSearchForm.FormattingEnabled = true;
            this.ComboBoxNameSearchForm.Items.AddRange(new object[] {
            "Резистор",
            "Кондесатор",
            "Катушка идуктивности"});
            this.ComboBoxNameSearchForm.Location = new System.Drawing.Point(130, 25);
            this.ComboBoxNameSearchForm.Name = "ComboBoxNameSearchForm";
            this.ComboBoxNameSearchForm.Size = new System.Drawing.Size(343, 37);
            this.ComboBoxNameSearchForm.TabIndex = 8;
            // 
            // SearchFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 244);
            this.Controls.Add(this.ButtonSearchElementSearchForm);
            this.Controls.Add(this.ButtonCancelSearchForm);
            this.Controls.Add(this.TextBoxValueSearchForm);
            this.Controls.Add(this.LableValueSearchForm);
            this.Controls.Add(this.LabelNameSearchForm);
            this.Controls.Add(this.ComboBoxNameSearchForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск элемента";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchFrom_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSearchElementSearchForm;
        private System.Windows.Forms.Button ButtonCancelSearchForm;
        private System.Windows.Forms.TextBox TextBoxValueSearchForm;
        private System.Windows.Forms.Label LableValueSearchForm;
        private System.Windows.Forms.Label LabelNameSearchForm;
        private System.Windows.Forms.ComboBox ComboBoxNameSearchForm;
    }
}