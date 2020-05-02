namespace ProgramUI
{
    partial class AddHouse
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.addHouseButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите адрес дома";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(24, 61);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(193, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // addHouseButton
            // 
            this.addHouseButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addHouseButton.Location = new System.Drawing.Point(24, 108);
            this.addHouseButton.Name = "addHouseButton";
            this.addHouseButton.Size = new System.Drawing.Size(193, 35);
            this.addHouseButton.TabIndex = 2;
            this.addHouseButton.Text = "Добавить дом";
            this.addHouseButton.UseVisualStyleBackColor = true;
            this.addHouseButton.Click += new System.EventHandler(this.AddHouseButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.errorLabel.Location = new System.Drawing.Point(51, 157);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(143, 17);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.Text = "Введите адрес дома";
            this.errorLabel.Visible = false;
            // 
            // AddHouse
            // 
            this.AcceptButton = this.addHouseButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 191);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.addHouseButton);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "AddHouse";
            this.Text = "Добавить дом";
            this.Load += new System.EventHandler(this.AddHouse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button addHouseButton;
        private System.Windows.Forms.Label errorLabel;
    }
}