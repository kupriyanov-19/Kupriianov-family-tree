namespace Tree
{
    partial class Generic_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generic_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RedButton = new System.Windows.Forms.Button();
            this.AllDescBox = new System.Windows.Forms.ListBox();
            this.AllAncBox = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.MainChildrenBox = new System.Windows.Forms.ListBox();
            this.MainParentsBox = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.codeButton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.AllHumansBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.aboutMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenu,
            this.createMenu,
            this.saveMenu,
            this.closeMenu});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // openMenu
            // 
            this.openMenu.Name = "openMenu";
            this.openMenu.Size = new System.Drawing.Size(132, 22);
            this.openMenu.Text = "Открыть";
            this.openMenu.Click += new System.EventHandler(this.openMenu_Click);
            // 
            // createMenu
            // 
            this.createMenu.Name = "createMenu";
            this.createMenu.Size = new System.Drawing.Size(132, 22);
            this.createMenu.Text = "Создать";
            this.createMenu.Click += new System.EventHandler(this.createMenu_Click);
            // 
            // saveMenu
            // 
            this.saveMenu.Enabled = false;
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.Size = new System.Drawing.Size(132, 22);
            this.saveMenu.Text = "Сохранить";
            this.saveMenu.Click += new System.EventHandler(this.saveMenu_Click);
            // 
            // closeMenu
            // 
            this.closeMenu.Enabled = false;
            this.closeMenu.Name = "closeMenu";
            this.closeMenu.Size = new System.Drawing.Size(132, 22);
            this.closeMenu.Text = "Закрыть";
            this.closeMenu.Click += new System.EventHandler(this.closeMenu_Click);
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(94, 20);
            this.aboutMenu.Text = "О программе";
            this.aboutMenu.Click += new System.EventHandler(this.aboutMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.RedButton);
            this.panel1.Controls.Add(this.AllDescBox);
            this.panel1.Controls.Add(this.AllAncBox);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.MainChildrenBox);
            this.panel1.Controls.Add(this.MainParentsBox);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 358);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(366, 307);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(139, 43);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Visible = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RedButton
            // 
            this.RedButton.Enabled = false;
            this.RedButton.Location = new System.Drawing.Point(20, 307);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(340, 43);
            this.RedButton.TabIndex = 3;
            this.RedButton.Text = "Редактировать";
            this.RedButton.UseVisualStyleBackColor = true;
            this.RedButton.Visible = false;
            this.RedButton.Click += new System.EventHandler(this.RedButton_Click);
            // 
            // AllDescBox
            // 
            this.AllDescBox.FormattingEnabled = true;
            this.AllDescBox.Location = new System.Drawing.Point(275, 180);
            this.AllDescBox.Name = "AllDescBox";
            this.AllDescBox.Size = new System.Drawing.Size(230, 121);
            this.AllDescBox.TabIndex = 14;
            this.AllDescBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AllDescBox_KeyDown);
            this.AllDescBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AllDescBox_MouseDoubleClick);
            // 
            // AllAncBox
            // 
            this.AllAncBox.FormattingEnabled = true;
            this.AllAncBox.Location = new System.Drawing.Point(20, 180);
            this.AllAncBox.Name = "AllAncBox";
            this.AllAncBox.Size = new System.Drawing.Size(230, 121);
            this.AllAncBox.TabIndex = 13;
            this.AllAncBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AllAncBox_KeyDown);
            this.AllAncBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AllAncBox_MouseDoubleClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(375, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Потомки";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(113, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Предки";
            // 
            // MainChildrenBox
            // 
            this.MainChildrenBox.FormattingEnabled = true;
            this.MainChildrenBox.Location = new System.Drawing.Point(275, 102);
            this.MainChildrenBox.Name = "MainChildrenBox";
            this.MainChildrenBox.Size = new System.Drawing.Size(230, 56);
            this.MainChildrenBox.TabIndex = 10;
            this.MainChildrenBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainChildrenBox_KeyDown);
            this.MainChildrenBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainChildrenBox_MouseDoubleClick);
            // 
            // MainParentsBox
            // 
            this.MainParentsBox.FormattingEnabled = true;
            this.MainParentsBox.Location = new System.Drawing.Point(20, 102);
            this.MainParentsBox.Name = "MainParentsBox";
            this.MainParentsBox.Size = new System.Drawing.Size(230, 30);
            this.MainParentsBox.TabIndex = 9;
            this.MainParentsBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainParentBox_KeyDown);
            this.MainParentsBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainParentBox_MouseDoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(375, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Дети";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(113, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Родители";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(72, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Годы жизни";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(375, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Отчество";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(236, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Имя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(88, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Фамилия";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.SearchBox);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.codeButton);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.AllHumansBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Controls.Add(this.exitButton);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.codeBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(544, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 358);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(81, 135);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(128, 20);
            this.SearchBox.TabIndex = 18;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 138);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Поиск";
            // 
            // codeButton
            // 
            this.codeButton.Location = new System.Drawing.Point(254, 61);
            this.codeButton.Name = "codeButton";
            this.codeButton.Size = new System.Drawing.Size(58, 23);
            this.codeButton.TabIndex = 16;
            this.codeButton.Text = "Ok";
            this.codeButton.UseVisualStyleBackColor = true;
            this.codeButton.Click += new System.EventHandler(this.codeButton_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(267, 41);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "label18";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(267, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "label17";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(136, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Дата посл. изменения:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(174, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Дата создания:";
            // 
            // AllHumansBox
            // 
            this.AllHumansBox.FormattingEnabled = true;
            this.AllHumansBox.Location = new System.Drawing.Point(16, 164);
            this.AllHumansBox.Name = "AllHumansBox";
            this.AllHumansBox.Size = new System.Drawing.Size(296, 186);
            this.AllHumansBox.TabIndex = 12;
            this.AllHumansBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AllHumansBox_KeyDown);
            this.AllHumansBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AllHumansBox_MouseDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(81, 109);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(149, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Добавить человека";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Button_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(233, 86);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.65F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "РЕДАКТИРОВАНИЕ ЗАПРЕЩЕНО";
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(125, 63);
            this.codeBox.Name = "codeBox";
            this.codeBox.PasswordChar = '°';
            this.codeBox.Size = new System.Drawing.Size(123, 20);
            this.codeBox.TabIndex = 6;
            this.codeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codeBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите код доступа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Кол-во. человек:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Клан:";
            // 
            // Generic_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 397);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Generic_Form";
            this.Text = "ClanViewer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenu;
        private System.Windows.Forms.ToolStripMenuItem createMenu;
        private System.Windows.Forms.ToolStripMenuItem saveMenu;
        private System.Windows.Forms.ToolStripMenuItem closeMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox AllHumansBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox AllDescBox;
        private System.Windows.Forms.ListBox AllAncBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox MainChildrenBox;
        private System.Windows.Forms.ListBox MainParentsBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button codeButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button RedButton;
    }
}