namespace Bank
{
    partial class MoveDepartmentForm
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
            this.moveDepartmentTownTextBox = new System.Windows.Forms.TextBox();
            this.moveDepartmentButton = new System.Windows.Forms.Button();
            this.moveDepartmentFormLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // moveDepartmentTownTextBox
            // 
            this.moveDepartmentTownTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.8F);
            this.moveDepartmentTownTextBox.Location = new System.Drawing.Point(24, 128);
            this.moveDepartmentTownTextBox.Name = "moveDepartmentTownTextBox";
            this.moveDepartmentTownTextBox.Size = new System.Drawing.Size(352, 42);
            this.moveDepartmentTownTextBox.TabIndex = 11;
            // 
            // moveDepartmentButton
            // 
            this.moveDepartmentButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.moveDepartmentButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.moveDepartmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveDepartmentButton.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moveDepartmentButton.ForeColor = System.Drawing.Color.Black;
            this.moveDepartmentButton.Location = new System.Drawing.Point(96, 192);
            this.moveDepartmentButton.Margin = new System.Windows.Forms.Padding(4);
            this.moveDepartmentButton.Name = "moveDepartmentButton";
            this.moveDepartmentButton.Size = new System.Drawing.Size(200, 56);
            this.moveDepartmentButton.TabIndex = 10;
            this.moveDepartmentButton.Text = "Переместить";
            this.moveDepartmentButton.UseVisualStyleBackColor = false;
            this.moveDepartmentButton.Click += new System.EventHandler(this.moveDepartmentButton_Click);
            // 
            // moveDepartmentFormLabel
            // 
            this.moveDepartmentFormLabel.BackColor = System.Drawing.Color.MintCream;
            this.moveDepartmentFormLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.moveDepartmentFormLabel.ForeColor = System.Drawing.Color.Black;
            this.moveDepartmentFormLabel.Location = new System.Drawing.Point(0, 0);
            this.moveDepartmentFormLabel.Margin = new System.Windows.Forms.Padding(0);
            this.moveDepartmentFormLabel.Name = "moveDepartmentFormLabel";
            this.moveDepartmentFormLabel.Size = new System.Drawing.Size(400, 104);
            this.moveDepartmentFormLabel.TabIndex = 9;
            this.moveDepartmentFormLabel.Text = "Введите город, в который хотите переместить отделение";
            this.moveDepartmentFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoveDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(398, 264);
            this.Controls.Add(this.moveDepartmentTownTextBox);
            this.Controls.Add(this.moveDepartmentButton);
            this.Controls.Add(this.moveDepartmentFormLabel);
            this.Name = "MoveDepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoveDepartmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox moveDepartmentTownTextBox;
        private System.Windows.Forms.Button moveDepartmentButton;
        private System.Windows.Forms.Label moveDepartmentFormLabel;
    }
}