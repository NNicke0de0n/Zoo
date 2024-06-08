namespace Zoo
{
    partial class Director
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
            this.addButton = new System.Windows.Forms.Button();
            this.animalListBox = new System.Windows.Forms.ListBox();
            this.editAnimal = new System.Windows.Forms.Button();
            this.removeAnimal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editEmployeeButton = new System.Windows.Forms.Button();
            this.removeEmployeeButton = new System.Windows.Forms.Button();
            this.choiceComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vistorsListBox = new System.Windows.Forms.ListBox();
            this.showAllVisitorsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(996, 495);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(260, 69);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // animalListBox
            // 
            this.animalListBox.FormattingEnabled = true;
            this.animalListBox.Location = new System.Drawing.Point(929, 31);
            this.animalListBox.Name = "animalListBox";
            this.animalListBox.Size = new System.Drawing.Size(358, 199);
            this.animalListBox.TabIndex = 1;
            // 
            // editAnimal
            // 
            this.editAnimal.Location = new System.Drawing.Point(1130, 236);
            this.editAnimal.Name = "editAnimal";
            this.editAnimal.Size = new System.Drawing.Size(75, 22);
            this.editAnimal.TabIndex = 2;
            this.editAnimal.Text = "Edit";
            this.editAnimal.UseVisualStyleBackColor = true;
            this.editAnimal.Click += new System.EventHandler(this.editAnimal_Click);
            // 
            // removeAnimal
            // 
            this.removeAnimal.Location = new System.Drawing.Point(1211, 236);
            this.removeAnimal.Name = "removeAnimal";
            this.removeAnimal.Size = new System.Drawing.Size(75, 22);
            this.removeAnimal.TabIndex = 2;
            this.removeAnimal.Text = "Remove";
            this.removeAnimal.UseVisualStyleBackColor = true;
            this.removeAnimal.Click += new System.EventHandler(this.removeAnimal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(926, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список животных";
            // 
            // employeeListBox
            // 
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.Location = new System.Drawing.Point(555, 31);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(358, 199);
            this.employeeListBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Список активных сотрудников";
            // 
            // editEmployeeButton
            // 
            this.editEmployeeButton.Location = new System.Drawing.Point(757, 236);
            this.editEmployeeButton.Name = "editEmployeeButton";
            this.editEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.editEmployeeButton.TabIndex = 5;
            this.editEmployeeButton.Text = "Edit";
            this.editEmployeeButton.UseVisualStyleBackColor = true;
            this.editEmployeeButton.Click += new System.EventHandler(this.editEmployeeButton_Click);
            // 
            // removeEmployeeButton
            // 
            this.removeEmployeeButton.Location = new System.Drawing.Point(838, 236);
            this.removeEmployeeButton.Name = "removeEmployeeButton";
            this.removeEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.removeEmployeeButton.TabIndex = 5;
            this.removeEmployeeButton.Text = "Remove";
            this.removeEmployeeButton.UseVisualStyleBackColor = true;
            this.removeEmployeeButton.Click += new System.EventHandler(this.removeEmployeeButton_Click);
            // 
            // choiceComboBox
            // 
            this.choiceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choiceComboBox.FormattingEnabled = true;
            this.choiceComboBox.Items.AddRange(new object[] {
            "Employee",
            "Animal",
            "Visitor"});
            this.choiceComboBox.Location = new System.Drawing.Point(996, 446);
            this.choiceComboBox.Name = "choiceComboBox";
            this.choiceComboBox.Size = new System.Drawing.Size(260, 21);
            this.choiceComboBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(993, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выберите для добавления";
            // 
            // vistorsListBox
            // 
            this.vistorsListBox.FormattingEnabled = true;
            this.vistorsListBox.Location = new System.Drawing.Point(555, 365);
            this.vistorsListBox.Name = "vistorsListBox";
            this.vistorsListBox.Size = new System.Drawing.Size(358, 199);
            this.vistorsListBox.TabIndex = 1;
            // 
            // showAllVisitorsButton
            // 
            this.showAllVisitorsButton.Location = new System.Drawing.Point(838, 570);
            this.showAllVisitorsButton.Name = "showAllVisitorsButton";
            this.showAllVisitorsButton.Size = new System.Drawing.Size(75, 23);
            this.showAllVisitorsButton.TabIndex = 8;
            this.showAllVisitorsButton.Text = "Show All Array";
            this.showAllVisitorsButton.UseVisualStyleBackColor = true;
            this.showAllVisitorsButton.Click += new System.EventHandler(this.showAllVisitorsButton_Click);
            // 
            // Director
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 607);
            this.Controls.Add(this.showAllVisitorsButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.choiceComboBox);
            this.Controls.Add(this.removeEmployeeButton);
            this.Controls.Add(this.editEmployeeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeAnimal);
            this.Controls.Add(this.editAnimal);
            this.Controls.Add(this.vistorsListBox);
            this.Controls.Add(this.employeeListBox);
            this.Controls.Add(this.animalListBox);
            this.Controls.Add(this.addButton);
            this.Name = "Director";
            this.Text = "Zoo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox animalListBox;
        private System.Windows.Forms.Button editAnimal;
        private System.Windows.Forms.Button removeAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox employeeListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editEmployeeButton;
        private System.Windows.Forms.Button removeEmployeeButton;
        private System.Windows.Forms.ComboBox choiceComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox vistorsListBox;
        private System.Windows.Forms.Button showAllVisitorsButton;
    }
}

