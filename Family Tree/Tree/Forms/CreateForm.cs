using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void CreateClanButtin_Click(object sender, EventArgs e)
        {
            string clanname = ClanNameBox.Text, code1 = CodeBox1.Text, code2 = CodeBox2.Text;
            if (code1 == code2)
            {
                try { Generic_Form.humandb = new HumanDB(clanname, code1); }
                catch (FormatException ex) { MessageBox.Show(ex.Message, "Ошибка"); return; }
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "Text |*.txt";
                dlg.FileName = "DB_" + clanname;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Generic_Form.humandb.WtiteToTxt(dlg.FileName);
                    Close();
                }
            }
            else
            {
                MessageBox.Show(Properties.Resources.Error_Different_Code, "Ошибка");
            }
        }

        private void CodeBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) CreateClanButtin.PerformClick();
        }

    }
}
