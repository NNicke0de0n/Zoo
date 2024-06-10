namespace Zoo
{
    partial class FormVisitor
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
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ageMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.countriesComboBox = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(343, 35);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 21);
            this.genderComboBox.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(372, 328);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(291, 328);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 5;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите пол";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(33, 35);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(217, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите имя";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // ageMaskedTextBox
            // 
            this.ageMaskedTextBox.Culture = new System.Globalization.CultureInfo("ru-BY");
            this.ageMaskedTextBox.Location = new System.Drawing.Point(33, 87);
            this.ageMaskedTextBox.Mask = "000";
            this.ageMaskedTextBox.Name = "ageMaskedTextBox";
            this.ageMaskedTextBox.PromptChar = '*';
            this.ageMaskedTextBox.Size = new System.Drawing.Size(69, 20);
            this.ageMaskedTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите возраст";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Введите страну";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Выберите дату посещения";
            // 
            // countriesComboBox
            // 
            this.countriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countriesComboBox.FormattingEnabled = true;
            this.countriesComboBox.Location = new System.Drawing.Point(343, 87);
            this.countriesComboBox.Name = "countriesComboBox";
            this.countriesComboBox.Size = new System.Drawing.Size(121, 21);
            this.countriesComboBox.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(33, 195);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = '*';
            this.maskedTextBox1.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBox1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Введите стоимость билета";
            // 
            // FormVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ageMaskedTextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.countriesComboBox);
            this.Controls.Add(this.genderComboBox);
            this.Name = "FormVisitor";
            this.Text = "Visitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox ageMaskedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox countriesComboBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label6;
    }
}