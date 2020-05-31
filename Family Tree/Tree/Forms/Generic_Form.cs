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
    public partial class Generic_Form : Form
    {
        public Generic_Form()
        {
            InitializeComponent();
        }

        

        public static HumanDB humandb = null;  
        OpenFileDialog open_dlg = null;
        public static Human chosenhuman = null;
        static public List<Human> humanlist = null;
        public List<Human> parentlist = null;
        public List<Human> childrenlist = null;
        public List<Human> allpar = null;
        public List<Human> allchil = null;


       
        public static Human SearchByID(string id, List<Human> hums)
        {
            for (int i = 0; i < hums.Count; i++)
            {
                if (hums[i].ID == id) return hums[i];
            }
            return null;
        }

        public static List<Human> SearchAllByID(string[] id, List<Human> hums)
        {
            List<Human> newl = new List<Human>();
            for (int i = 0; i < id.Length; i++)
            {
                if (SearchByID(id[i], hums) != null)
                    newl.Add(SearchByID(id[i], hums));
            }
            return newl;
        }


        public void UpdateAllHumanBox(List<Human> hum)
        {
            AllHumansBox.Items.Clear();
            if (hum != null)
            {
                foreach (Human h in hum)
                {
                    AllHumansBox.Items.Add(h.humaninf);
                }
            }
        }
        public void UpdateMainChilrenBox(List<Human> hum)
        {
            MainChildrenBox.Items.Clear();
            foreach (Human h in hum)
            {
                MainChildrenBox.Items.Add(h.humaninf);
            }
        }
        public void UpdateMainParentsBox(List<Human> hum)
        {
            MainParentsBox.Items.Clear();
            foreach (Human h in hum)
            {
                MainParentsBox.Items.Add(h.humaninf);
            }
        }
        public  void Update(HumanDB humandb) 
        {
            label5.Text = humandb.Clan_Name;            
            label17.Text = humandb.Date_Create.ToShortDateString();
            label18.Text = humandb.Date_Last_Edit.ToShortDateString();
            if (humandb.dblist != null)
            {
                label6.Text = humandb.dblist.Count.ToString();
            }
            else label6.Text = "0";
            humanlist = humandb.dblist;
            UpdateAllHumanBox(humanlist);
        }

        public void ChosenUpdate()
        {
            if (chosenhuman != null)
            {
                label7.Text = chosenhuman.SName;
                label8.Text = chosenhuman.Name;
                label9.Text = chosenhuman.FName;                
                if (chosenhuman.Life) label10.Text = chosenhuman.BornDate.ToShortDateString();
                else label10.Text = chosenhuman.BornDate.ToShortDateString() + " — " + chosenhuman.DeathDate.ToShortDateString();
                parentlist = SearchAllByID(chosenhuman.Parents, humanlist);
                childrenlist = SearchAllByID(chosenhuman.Children, humanlist);
                UpdateMainParentsBox(parentlist);
                UpdateMainChilrenBox(childrenlist);
                AllparUpd();
                AllchilUpd();
                RedButton.Enabled = true;
                DeleteButton.Enabled = true;
            }
             else
            {
                label7.Text = "Фамилия";
                label8.Text = "Имя";
                label9.Text = "Отчество";
                label10.Text = "Годы Жизни";
                parentlist = null;
                childrenlist = null;
                MainParentsBox.Items.Clear();
                MainChildrenBox.Items.Clear();
                allchil = null;
                allpar = null;
                AllAncBox.Items.Clear();
                AllDescBox.Items.Clear();
                RedButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
        }

        public void AllparUpd()
        {
            allpar = new List<Human>();
            var temp = new List<Human>();
            AllAncBox.Items.Clear();
            temp.AddRange(parentlist);

            for (int i = 0; i < humanlist.Count; i++)
            {
                allpar = temp;
                for (int h = 0; h < allpar.Count; h++)
                {
                    foreach (string t in allpar[h].Parents)
                    {
                        if (t != null) 
                        {
                            if (AddForm.IDCheck(allpar, SearchByID(t, humanlist).ID))
                            {
                                temp.Add(SearchByID(t, humanlist));
                            }
                        }
                    }
                }
            }
            foreach (Human h in allpar)
            {
                AllAncBox.Items.Add(h.humaninf);
            }
        }
        public void AllchilUpd()
        {
            allchil = new List<Human>();
            var temp = new List<Human>();           
            AllDescBox.Items.Clear();
            temp.AddRange(childrenlist);

            for (int i = 0; i < humanlist.Count; i++)
            {
                allchil = temp;
                for (int h = 0; h < allchil.Count; h++)
                {
                    foreach (string t in allchil[h].Children)
                    {
                        if (t != null)
                        {
                            if (AddForm.IDCheck(allchil, SearchByID(t, humanlist).ID))
                            { 
                                temp.Add(SearchByID(t, humanlist));
                            }
                        }
                    }
                }
            }
            foreach (Human h in allchil)
            {
                AllDescBox.Items.Add(h.humaninf);
            }
        }


        private void createMenu_Click(object sender, EventArgs e)
        {
            exitButton.PerformClick();
            CreateForm create_form = new CreateForm();
            create_form.ShowDialog();
            if (humandb != null)
            {
               
                closeMenu.Enabled = true;
                saveMenu.Enabled = true;      
                panel1.Visible = true;
                panel2.Visible = true;
                Update(humandb);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            codeBox.Visible = true;
            codeButton.Visible = true;
            exitButton.Visible = false;
            addButton.Visible = false;
            RedButton.Visible = false;
            DeleteButton.Visible = false;
            label4.Text = "РЕДАКТИРОВАНИЕ ЗАПРЕЩЕНО";
            label4.ForeColor = Color.Red;
         }
    

        private void saveMenu_Click(object sender, EventArgs e)
        {
            if (humandb.dblist.Count != 0)
            {
                if (open_dlg != null && humandb != null)
                {
                    humandb.WtiteToTxt(open_dlg.FileName);
                }
            }
        }

        private void codeBox_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Enter) codeButton.PerformClick();
        }
        private void codeButton_Click(object sender, EventArgs e)
        {
            if (HumanDB.GetHashCode(codeBox.Text) == humandb.Code)
            {
                codeBox.Text = "";
                label3.Visible = false;
                codeBox.Visible = false;
                codeButton.Visible = false;
                exitButton.Visible = true;
                addButton.Visible = true;
                RedButton.Visible = true;
                DeleteButton.Visible = true;                
                label4.Text = "РЕДАКТИРОВАНИЕ РАЗРЕШЕНО";
                label4.ForeColor = Color.Green;
                
            }
            else { MessageBox.Show(Properties.Resources.Error_Not_True_Code, "Ошибка"); }
        }
        private void closeMenu_Click(object sender, EventArgs e)
        {
            exitButton.PerformClick();
            humandb = null;
            open_dlg = null;            
            closeMenu.Enabled = false;
            saveMenu.Enabled = false;
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void aboutMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия 1.0\nАвтор: Куприянов Михаил Александрович", "О программе");
        }

        private void Generic_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (open_dlg != null && humandb != null)
            {
                humandb.WtiteToTxt(open_dlg.FileName);
            }
        }

        private void AddButton_Button_Click(object sender, EventArgs e) 
        {
            AddForm addform = new AddForm();
            addform.ShowDialog();
            Update(humandb);    
        }
        

        private void RedButton_Click(object sender, EventArgs e)
        {
            RedForm addform = new RedForm();
            addform.ShowDialog();
            Update(humandb);
        }


        // // // // // // // //

        private void AllHumansBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (AllHumansBox.SelectedIndex != -1)
            {
                chosenhuman = humanlist[AllHumansBox.SelectedIndex];
                ChosenUpdate();
            }
        }
        private void AllHumansBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (AllHumansBox.SelectedIndex != -1)
                {
                    chosenhuman = humanlist[AllHumansBox.SelectedIndex];
                    ChosenUpdate();
                }
        }

        private void MainParentBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (MainParentsBox.SelectedIndex != -1)
            {
                chosenhuman = parentlist[MainParentsBox.SelectedIndex];
                ChosenUpdate();
            }
        }
        private void MainParentBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (MainParentsBox.SelectedIndex != -1)
                {
                    chosenhuman = parentlist[MainParentsBox.SelectedIndex];
                    ChosenUpdate();
                }
        }

        private void MainChildrenBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (MainChildrenBox.SelectedIndex != -1)
            {
                chosenhuman = childrenlist[MainChildrenBox.SelectedIndex];
                ChosenUpdate();
            }
        }
        private void MainChildrenBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (MainChildrenBox.SelectedIndex != -1)
                {
                    chosenhuman = childrenlist[MainChildrenBox.SelectedIndex];
                    ChosenUpdate();
                }
        }

        private void AllAncBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (AllAncBox.SelectedIndex != -1)
            {
                chosenhuman = allpar[AllAncBox.SelectedIndex];
                ChosenUpdate();
            }
        }
        private void AllAncBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (AllAncBox.SelectedIndex != -1)
                {
                    chosenhuman = allpar[AllAncBox.SelectedIndex];
                    ChosenUpdate();
                }
        }
        private void AllDescBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (AllDescBox.SelectedIndex != -1)
            {
                chosenhuman = allchil[AllDescBox.SelectedIndex];
                ChosenUpdate();
            }
        }
        private void AllDescBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (AllDescBox.SelectedIndex != -1)
                {
                    chosenhuman = allchil[AllDescBox.SelectedIndex];
                    ChosenUpdate();
                }
        }

        // // // // // // // //
        public int HumanSearchByInfo(string info, List<Human> hums)
        {
            for (int i = 0; i < hums.Count; i++)
            {
                if (hums[i].humaninf.Contains(info))
                    return i;
            }
            return -1;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            int index = HumanSearchByInfo(SearchBox.Text, humanlist);
            if (index != -1)
                AllHumansBox.SelectedIndex = index;
        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            
        
            exitButton.PerformClick();
            open_dlg = new OpenFileDialog();
            open_dlg.FileName = "";
            open_dlg.Filter = "Text |*.txt";
            if (open_dlg.ShowDialog() == DialogResult.OK)
            {
                try { humandb = HumanDB.ReadFromTxt(open_dlg.FileName); }
                catch (FormatException ex) { MessageBox.Show(ex.Message, "Ошибка"); open_dlg = null; return; }
                Update(humandb);
                closeMenu.Enabled = true;
                saveMenu.Enabled = true;
                panel1.Visible = true;
                panel2.Visible = true;


            }
            else
            {
                open_dlg = null;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (Human hh in SearchAllByID(chosenhuman.Parents, humandb.dblist))
            {
                for (int p = 0; p < hh.Childq; p++)
                {
                    if (hh.Children[p] == chosenhuman.ID)
                    {
                        for (int pp = p; pp < hh.Childq-1; pp++)
                        {
                            hh.Children[pp] = hh.Children[pp + 1];
                        }
                        hh.Childq--;
                        var temp = new String[hh.Childq];
                        Array.Copy(hh.Children, temp, hh.Childq);
                        hh.Children = temp;
                    }
                }
            }
            foreach (Human hh in SearchAllByID(chosenhuman.Children, humandb.dblist))
            {
                for (int p =0;p<2; p++)
                {
                    if (hh.Parents[p] == chosenhuman.ID)
                        hh.Parents[p] = "";
                }
            }
            humandb.dblist.Remove(SearchByID(chosenhuman.ID, humandb.dblist));
            Update(humandb);
            chosenhuman = null;
            ChosenUpdate();
            humandb.Date_Last_Edit = DateTime.Now.Date;
            label18.Text = humandb.Date_Last_Edit.ToShortDateString();
        }

        public static int IndexByID(string id, List<Human> hums)
        {
            for (int i = 0; i < hums.Count; i++)
            {
                if (hums[i].ID == id) return i;
            }
            return -1;
        }
    }
}
