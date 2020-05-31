namespace Tree
{
    partial class CreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            this.ClanNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CodeBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CodeBox2 = new System.Windows.Forms.TextBox();
            this.CreateClanButtin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClanNameBox
            // 
            this.ClanNameBox.Location = new System.Drawing.Point(12, 25);
            this.ClanNameBox.Name = "ClanNameBox";
            this.ClanNameBox.Size = new System.Drawing.Size(200, 20);
            this.ClanNameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите название клана";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите код редактирования";
            // 
            // CodeBox1
            // 
            this.CodeBox1.Location = new System.Drawing.Point(12, 64);
            this.CodeBox1.Name = "CodeBox1";
            this.CodeBox1.Size = new System.Drawing.Size(200, 20);
            this.CodeBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Повторите код редактирования";
            // 
            // CodeBox2
            // 
            this.CodeBox2.Location = new System.Drawing.Point(12, 103);
            this.CodeBox2.Name = "CodeBox2";
            this.CodeBox2.Size = new System.Drawing.Size(200, 20);
            this.CodeBox2.TabIndex = 5;
            this.CodeBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodeBox2_KeyDown);
            // 
            // CreateClanButtin
            // 
            this.CreateClanButtin.Location = new System.Drawing.Point(12, 129);
            this.CreateClanButtin.Name = "CreateClanButtin";
            this.CreateClanButtin.Size = new System.Drawing.Size(200, 30);
            this.CreateClanButtin.TabIndex = 6;
            this.CreateClanButtin.Text = "Создать клан";
            this.CreateClanButtin.UseVisualStyleBackColor = true;
            this.CreateClanButtin.Click += new System.EventHandler(this.CreateClanButtin_Click);
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 171);
            this.Controls.Add(this.CreateClanButtin);
            this.Controls.Add(this.CodeBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CodeBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClanNameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateForm";
            this.Text = "Создание клана";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClanNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodeBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CodeBox2;
        private System.Windows.Forms.Button CreateClanButtin;
    }
}