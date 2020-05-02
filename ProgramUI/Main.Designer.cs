namespace ProgramUI
{
    partial class Main
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
            this.labelHouse = new System.Windows.Forms.Label();
            this.listHouses = new System.Windows.Forms.ComboBox();
            this.houseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelRoom = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.rateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CalculateButton = new System.Windows.Forms.Button();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.addHouseButton = new System.Windows.Forms.Button();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.addRateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHouse
            // 
            this.labelHouse.AutoSize = true;
            this.labelHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHouse.Location = new System.Drawing.Point(12, 26);
            this.labelHouse.Name = "labelHouse";
            this.labelHouse.Size = new System.Drawing.Size(36, 17);
            this.labelHouse.TabIndex = 0;
            this.labelHouse.Text = "Дом";
            // 
            // listHouses
            // 
            this.listHouses.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.houseBindingSource, "Name", true));
            this.listHouses.DataSource = this.houseBindingSource;
            this.listHouses.DisplayMember = "Name";
            this.listHouses.FormattingEnabled = true;
            this.listHouses.Location = new System.Drawing.Point(95, 22);
            this.listHouses.Name = "listHouses";
            this.listHouses.Size = new System.Drawing.Size(121, 21);
            this.listHouses.TabIndex = 1;
            this.listHouses.ValueMember = "Id";
            // 
            // houseBindingSource
            // 
            this.houseBindingSource.DataSource = typeof(ProgramLogic.Model.House);
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoom.Location = new System.Drawing.Point(12, 66);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(71, 17);
            this.labelRoom.TabIndex = 2;
            this.labelRoom.Text = "Квартира";
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRate.Location = new System.Drawing.Point(12, 110);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(52, 17);
            this.labelRate.TabIndex = 3;
            this.labelRate.Text = "Тариф";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.roomBindingSource;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(95, 66);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.ValueMember = "Id";
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(ProgramLogic.Model.Room);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.rateBindingSource;
            this.comboBox3.DisplayMember = "Value";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(95, 110);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.ValueMember = "Value";
            // 
            // rateBindingSource
            // 
            this.rateBindingSource.DataSource = typeof(ProgramLogic.Model.Rate);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateButton.Location = new System.Drawing.Point(15, 262);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(231, 34);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxResult.Location = new System.Drawing.Point(281, 12);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.ReadOnly = true;
            this.richTextBoxResult.Size = new System.Drawing.Size(391, 337);
            this.richTextBoxResult.TabIndex = 7;
            this.richTextBoxResult.Text = "";
            // 
            // startDatePicker
            // 
            this.startDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDatePicker.Location = new System.Drawing.Point(15, 153);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(231, 20);
            this.startDatePicker.TabIndex = 8;
            this.startDatePicker.Value = new System.DateTime(2020, 4, 1, 0, 0, 0, 0);
            // 
            // endDatePicker
            // 
            this.endDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDatePicker.Location = new System.Drawing.Point(15, 201);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(231, 20);
            this.endDatePicker.TabIndex = 9;
            this.endDatePicker.Value = new System.DateTime(2020, 4, 27, 21, 14, 13, 0);
            // 
            // addHouseButton
            // 
            this.addHouseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addHouseButton.Location = new System.Drawing.Point(231, 20);
            this.addHouseButton.Name = "addHouseButton";
            this.addHouseButton.Size = new System.Drawing.Size(39, 23);
            this.addHouseButton.TabIndex = 10;
            this.addHouseButton.Text = "+";
            this.addHouseButton.UseVisualStyleBackColor = true;
            this.addHouseButton.Click += new System.EventHandler(this.AddHouseButton_Click);
            // 
            // addRoomButton
            // 
            this.addRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRoomButton.Location = new System.Drawing.Point(231, 66);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(39, 23);
            this.addRoomButton.TabIndex = 10;
            this.addRoomButton.Text = "+";
            this.addRoomButton.UseVisualStyleBackColor = true;
            // 
            // addRateButton
            // 
            this.addRateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRateButton.Location = new System.Drawing.Point(231, 110);
            this.addRateButton.Name = "addRateButton";
            this.addRateButton.Size = new System.Drawing.Size(39, 23);
            this.addRateButton.TabIndex = 10;
            this.addRateButton.Text = "+";
            this.addRateButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.addRateButton);
            this.Controls.Add(this.addRoomButton);
            this.Controls.Add(this.addHouseButton);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.listHouses);
            this.Controls.Add(this.labelHouse);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Main";
            this.Text = "Калькулятор коммунальных платежей";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHouse;
        private System.Windows.Forms.ComboBox listHouses;
        private System.Windows.Forms.BindingSource houseBindingSource;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource rateBindingSource;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Button addHouseButton;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.Button addRateButton;
    }
}

