namespace Tree
{
    partial class RedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedForm));
            this.nameBox = new System.Windows.Forms.TextBox();
            this.SnameBox = new System.Windows.Forms.TextBox();
            this.FnameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BornDateBox = new System.Windows.Forms.DateTimePicker();
            this.DeathDateBox = new System.Windows.Forms.DateTimePicker();
            this.LifeBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ParentBox = new System.Windows.Forms.ListBox();
            this.ParentAddBox = new System.Windows.Forms.ComboBox();
            this.ChildrenBox = new System.Windows.Forms.ListBox();
            this.ChildrenAddBox = new System.Windows.Forms.ComboBox();
            this.HumanAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(119, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(133, 20);
            this.nameBox.TabIndex = 0;
            // 
            // SnameBox
            // 
            this.SnameBox.Location = new System.Drawing.Point(119, 38);
            this.SnameBox.Name = "SnameBox";
            this.SnameBox.Size = new System.Drawing.Size(133, 20);
            this.SnameBox.TabIndex = 1;
            // 
            // FnameBox
            // 
            this.FnameBox.Location = new System.Drawing.Point(119, 64);
            this.FnameBox.Name = "FnameBox";
            this.FnameBox.Size = new System.Drawing.Size(133, 20);
            this.FnameBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отчество:";
            // 
            // BornDateBox
            // 
            this.BornDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BornDateBox.Location = new System.Drawing.Point(473, 12);
            this.BornDateBox.Name = "BornDateBox";
            this.BornDateBox.Size = new System.Drawing.Size(133, 20);
            this.BornDateBox.TabIndex = 4;
            this.BornDateBox.ValueChanged += new System.EventHandler(this.BornDateBox_ValueChanged);
            // 
            // DeathDateBox
            // 
            this.DeathDateBox.Enabled = false;
            this.DeathDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DeathDateBox.Location = new System.Drawing.Point(473, 64);
            this.DeathDateBox.Name = "DeathDateBox";
            this.DeathDateBox.Size = new System.Drawing.Size(133, 20);
            this.DeathDateBox.TabIndex = 5;
            this.DeathDateBox.Value = new System.DateTime(9998, 5, 3, 17, 33, 0, 0);
            this.DeathDateBox.Visible = false;
            // 
            // LifeBox
            // 
            this.LifeBox.AutoSize = true;
            this.LifeBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LifeBox.Checked = true;
            this.LifeBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LifeBox.Location = new System.Drawing.Point(330, 40);
            this.LifeBox.Name = "LifeBox";
            this.LifeBox.Size = new System.Drawing.Size(117, 17);
            this.LifeBox.TabIndex = 6;
            this.LifeBox.Text = "Человек еще жив";
            this.LifeBox.UseVisualStyleBackColor = true;
            this.LifeBox.CheckedChanged += new System.EventHandler(this.LifeBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Родители:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дети:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Дата рождения:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Дата смерти:";
            this.label7.Visible = false;
            // 
            // ParentBox
            // 
            this.ParentBox.FormattingEnabled = true;
            this.ParentBox.Location = new System.Drawing.Point(13, 132);
            this.ParentBox.Name = "ParentBox";
            this.ParentBox.Size = new System.Drawing.Size(146, 30);
            this.ParentBox.TabIndex = 11;
            this.ParentBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ParentBox_KeyDown);
            // 
            // ParentAddBox
            // 
            this.ParentAddBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParentAddBox.FormattingEnabled = true;
            this.ParentAddBox.Location = new System.Drawing.Point(165, 132);
            this.ParentAddBox.Name = "ParentAddBox";
            this.ParentAddBox.Size = new System.Drawing.Size(148, 21);
            this.ParentAddBox.TabIndex = 12;
            this.ParentAddBox.SelectedIndexChanged += new System.EventHandler(this.ParentAddBox_SelectedIndexChanged);
            // 
            // ChildrenBox
            // 
            this.ChildrenBox.FormattingEnabled = true;
            this.ChildrenBox.Location = new System.Drawing.Point(337, 132);
            this.ChildrenBox.Name = "ChildrenBox";
            this.ChildrenBox.Size = new System.Drawing.Size(146, 56);
            this.ChildrenBox.TabIndex = 13;
            this.ChildrenBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChildrenBox_KeyDown);
            // 
            // ChildrenAddBox
            // 
            this.ChildrenAddBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChildrenAddBox.FormattingEnabled = true;
            this.ChildrenAddBox.Location = new System.Drawing.Point(489, 132);
            this.ChildrenAddBox.Name = "ChildrenAddBox";
            this.ChildrenAddBox.Size = new System.Drawing.Size(148, 21);
            this.ChildrenAddBox.TabIndex = 14;
            this.ChildrenAddBox.SelectedIndexChanged += new System.EventHandler(this.ChildrenAddBox_SelectedIndexChanged);
            // 
            // HumanAddButton
            // 
            this.HumanAddButton.Location = new System.Drawing.Point(12, 195);
            this.HumanAddButton.Name = "HumanAddButton";
            this.HumanAddButton.Size = new System.Drawing.Size(627, 31);
            this.HumanAddButton.TabIndex = 15;
            this.HumanAddButton.Text = "Сохранить изменения";
            this.HumanAddButton.UseVisualStyleBackColor = true;
            this.HumanAddButton.Click += new System.EventHandler(this.HumanAddButton_Click);
            // 
            // RedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 238);
            this.Controls.Add(this.HumanAddButton);
            this.Controls.Add(this.ChildrenAddBox);
            this.Controls.Add(this.ChildrenBox);
            this.Controls.Add(this.ParentAddBox);
            this.Controls.Add(this.ParentBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LifeBox);
            this.Controls.Add(this.DeathDateBox);
            this.Controls.Add(this.BornDateBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FnameBox);
            this.Controls.Add(this.SnameBox);
            this.Controls.Add(this.nameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RedForm";
            this.Text = "Форма редактирования человека";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox SnameBox;
        private System.Windows.Forms.TextBox FnameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker BornDateBox;
        private System.Windows.Forms.DateTimePicker DeathDateBox;
        private System.Windows.Forms.CheckBox LifeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ParentBox;
        private System.Windows.Forms.ComboBox ParentAddBox;
        private System.Windows.Forms.ListBox ChildrenBox;
        private System.Windows.Forms.ComboBox ChildrenAddBox;
        private System.Windows.Forms.Button HumanAddButton;
    }
}