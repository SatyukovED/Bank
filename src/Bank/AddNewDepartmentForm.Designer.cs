namespace Bank
{
    partial class AddNewDepartmentForm
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
            this.addNewDepartmentFormLabel = new System.Windows.Forms.Label();
            this.openNewDepartmentButton = new System.Windows.Forms.Button();
            this.newDepartmentTownTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addNewDepartmentFormLabel
            // 
            this.addNewDepartmentFormLabel.BackColor = System.Drawing.Color.MintCream;
            this.addNewDepartmentFormLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.addNewDepartmentFormLabel.ForeColor = System.Drawing.Color.Black;
            this.addNewDepartmentFormLabel.Location = new System.Drawing.Point(0, 0);
            this.addNewDepartmentFormLabel.Margin = new System.Windows.Forms.Padding(0);
            this.addNewDepartmentFormLabel.Name = "addNewDepartmentFormLabel";
            this.addNewDepartmentFormLabel.Size = new System.Drawing.Size(400, 88);
            this.addNewDepartmentFormLabel.TabIndex = 2;
            this.addNewDepartmentFormLabel.Text = "Введите город, в котором хотите открыть отделение";
            this.addNewDepartmentFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openNewDepartmentButton
            // 
            this.openNewDepartmentButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.openNewDepartmentButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.openNewDepartmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openNewDepartmentButton.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openNewDepartmentButton.ForeColor = System.Drawing.Color.Black;
            this.openNewDepartmentButton.Location = new System.Drawing.Point(112, 192);
            this.openNewDepartmentButton.Margin = new System.Windows.Forms.Padding(4);
            this.openNewDepartmentButton.Name = "openNewDepartmentButton";
            this.openNewDepartmentButton.Size = new System.Drawing.Size(168, 56);
            this.openNewDepartmentButton.TabIndex = 3;
            this.openNewDepartmentButton.Text = "Открыть";
            this.openNewDepartmentButton.UseVisualStyleBackColor = false;
            this.openNewDepartmentButton.Click += new System.EventHandler(this.openNewDepartmentButton_Click);
            // 
            // newDepartmentTownTextBox
            // 
            this.newDepartmentTownTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.8F);
            this.newDepartmentTownTextBox.Location = new System.Drawing.Point(40, 112);
            this.newDepartmentTownTextBox.Name = "newDepartmentTownTextBox";
            this.newDepartmentTownTextBox.Size = new System.Drawing.Size(312, 42);
            this.newDepartmentTownTextBox.TabIndex = 8;
            // 
            // AddNewDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(398, 264);
            this.Controls.Add(this.newDepartmentTownTextBox);
            this.Controls.Add(this.openNewDepartmentButton);
            this.Controls.Add(this.addNewDepartmentFormLabel);
            this.Name = "AddNewDepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить новое отделение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addNewDepartmentFormLabel;
        private System.Windows.Forms.Button openNewDepartmentButton;
        private System.Windows.Forms.TextBox newDepartmentTownTextBox;
    }
}