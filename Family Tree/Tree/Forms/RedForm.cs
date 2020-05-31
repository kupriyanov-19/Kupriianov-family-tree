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
    public partial class RedForm : Form
    {
        public RedForm()
        {
            InitializeComponent();
        }

        List<Human> validpar=null;
        List<Human> validchil = null;
        List<Human> children = null;
        List<Human> parents = null;
        private void HumanAddButton_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text, sname = SnameBox.Text, fname = FnameBox.Text, id = Generic_Form.chosenhuman.ID;
            DateTime brn = BornDateBox.Value.Date;
            bool life = LifeBox.Checked;            
            DateTime dth = DeathDateBox.Value.Date;
            string[] par = new string[2];
            if (parents.Count < 3)
            {
                for (int i = 0; i < parents.Count; i++)
                {
                    par[i] = parents[i].ID;
                }
            }
           else throw new FormatException(Properties.Resources.Error_ParentsQ);
            string[] chil = new string[children.Count];
            for (int i = 0; i < children.Count; i++)
            {
                chil[i] = children[i].ID;
            }
            int chq = chil.Length;
            Human newhuman = null;
            try { newhuman = new Human(name, sname, fname, brn, life, dth, par, chq, chil, id); }
            catch (FormatException ex) { MessageBox.Show(ex.Message, "Ошибка"); }
            if (newhuman != null)
            {
                foreach (string s in newhuman.Parents)
                {
                    if (s != "" && s != null)
                    {
                        
                        if (IdCheck(
                            Generic_Form.humanlist[IndexByID(s,Generic_Form.humanlist)].Children, newhuman.ID))
                        {
                            string[] temp = Generic_Form.SearchByID(s, Generic_Form.humanlist).Children;
                            Array.Resize(ref temp, temp.Length + 1);
                            temp[temp.Length-1] = newhuman.ID;
                            Generic_Form.SearchByID(s, Generic_Form.humanlist).Children = temp;
                        }
                    }
                }
                foreach (string s in newhuman.Children)
                    if (s != "" && s != null) {
                        {
                            if (IdCheck(Generic_Form.SearchByID(s, Generic_Form.humanlist).Parents, newhuman.ID) &&
                                Generic_Form.SearchByID(s, Generic_Form.humanlist).Parents[0] == null)
                            {
                                Generic_Form.SearchByID(s, Generic_Form.humanlist).Parents[0] = newhuman.ID;
                            }                            
                            if (IdCheck(Generic_Form.SearchByID(s, Generic_Form.humanlist).Parents, newhuman.ID) &&
                                Generic_Form.SearchByID(s, Generic_Form.humanlist).Parents[0] != null &&
                                Generic_Form.SearchByID(s, Generic_Form.humanlist).Parents[1] == null)
                            {
                                Generic_Form.SearchByID(s, Generic_Form.humanlist).Parents[1] = newhuman.ID;
                            }
                        }
                }
                Generic_Form.humandb.dblist[IndexByID(newhuman.ID, Generic_Form.humandb.dblist)] = newhuman;
                Generic_Form.chosenhuman = newhuman;
                Generic_Form.humandb.Date_Last_Edit = DateTime.Now.Date;
                Close();
            }
        }

        public static int IndexByID(string id, List<Human> hums)
        {
            for (int i = 0; i < hums.Count; i++)
            {
                if (hums[i].ID == id) return i;
            }
            return -1;
        }

        public void FolksUpd()
        {
            validpar = new List<Human>();
            validchil = new List<Human>();
            ParentAddBox.Items.Clear();
            ChildrenAddBox.Items.Clear();
            foreach (Human h in Generic_Form.humanlist)
            {
                if (BornDateBox.Value > h.BornDate)
                {
                    validpar.Add(h);
                }
                if (BornDateBox.Value < h.BornDate)
                {
                    validchil.Add(h);
                }
            }

            foreach (Human h in validpar)
            {
                ParentAddBox.Items.Add(h.humaninf);
            }


            foreach (Human h in validchil)
            {
                ChildrenAddBox.Items.Add(h.humaninf);
            }
        }
        private void BornDateBox_ValueChanged(object sender, EventArgs e)
        {
            FolksUpd();            
        }
        private void AddForm_Load(object sender, EventArgs e)
        {            
            nameBox.Text = Generic_Form.chosenhuman.Name;
            SnameBox.Text = Generic_Form.chosenhuman.SName;
            FnameBox.Text = Generic_Form.chosenhuman.FName;
            BornDateBox.Value = Generic_Form.chosenhuman.BornDate;
            DeathDateBox.Value = Generic_Form.chosenhuman.DeathDate;
            if (Generic_Form.chosenhuman.Life == false)
                LifeBox.Checked = false;
            else LifeBox.Checked = true;
            parents = Generic_Form.SearchAllByID(Generic_Form.chosenhuman.Parents, Generic_Form.humanlist);
            children = Generic_Form.SearchAllByID(Generic_Form.chosenhuman.Children, Generic_Form.humanlist);
            FolksUpd();
            ParentBoxUpdate();
            ChildrenBoxUpdate();
        }


        private void LifeBox_CheckedChanged(object sender, EventArgs e)
        {
            switch (LifeBox.CheckState)
            {
                case CheckState.Checked:
                    DeathDateBox.Enabled = false;
                    DeathDateBox.Visible = false;
                    label7.Visible = false;
                    break;
                case CheckState.Unchecked:
                    DeathDateBox.Enabled = true;
                    DeathDateBox.Visible = true;
                    label7.Visible = true;
                    break;
            }
        }

        public void ParentBoxUpdate()
        {
            ParentBox.Items.Clear();
            foreach (Human h in parents)
            {
                ParentBox.Items.Add(h.humaninf);
            }
        }
        public void ChildrenBoxUpdate()
        {
            ChildrenBox.Items.Clear();
            foreach (Human h in children)
            {
                ChildrenBox.Items.Add(h.humaninf);
            }
        }
        public static bool IDCheck(List<Human> h , string id)
        {
           
            foreach (Human hu in h)
            {
                if (hu.ID == id)
                    return false;
            }
            return true;
        }
        public bool IdCheck(string[] h, string id)
        {
            bool res = true;
            foreach (string hu in h)
            {
                if (hu == id)
                    res = false;
            }
            return res;
        }

        private void ParentAddBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IDCheck(parents , validpar[ParentAddBox.SelectedIndex].ID))
                parents.Add(validpar[ParentAddBox.SelectedIndex]); 
            ParentBoxUpdate();
        }

        private void ChildrenAddBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IDCheck(children, validchil[ChildrenAddBox.SelectedIndex].ID))
                children.Add(validchil[ChildrenAddBox.SelectedIndex]);
            ChildrenBoxUpdate();
        }

        private void ParentBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && ParentBox.SelectedIndex!= -1)
            {
                parents.Remove(parents[ParentBox.SelectedIndex]);
                ParentBoxUpdate();
            }
        }
        private void ChildrenBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && ChildrenBox.SelectedIndex !=-1)
            {
                children.Remove(children[ChildrenBox.SelectedIndex]);
                ChildrenBoxUpdate();
            }
        }

       
    }
}
