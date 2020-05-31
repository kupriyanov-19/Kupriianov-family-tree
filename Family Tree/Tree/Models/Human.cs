using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Human
    {
        public string Name { get; }
        public string SName { get; }
        public string FName { get; }

        public DateTime BornDate { get; set; }
        public bool Life { get; set; }
        public DateTime DeathDate { get; set; }

        public string[] Parents { get; set; }
        public int Childq { get; set; }
        public string[] Children { get; set; }

        public string humaninf { get; }
        public string ID { get; }


        //конструктор
        public Human(string name, string sname, string fname, DateTime brn , bool life, DateTime dth, string[] par, int childq, string[] chi, string id)
        {
            if (ValidateSingle(name)) Name = name;
            else throw new FormatException(Properties.Resources.Error_Validate_Name);
            if (ValidateSingle(sname)) SName = sname;
            else throw new FormatException(Properties.Resources.Error_Validate_SName);
            if (ValidateSingle(fname)) FName = fname;
            else throw new FormatException(Properties.Resources.Error_Validate_FName);
            BornDate = brn;
            Life = life;
            if (Validate_Death_Date(dth)) DeathDate = dth;
            else throw new FormatException(Properties.Resources.Error_Validate_Death_Date);
            Parents = par;
            Childq = childq;
            Children = chi;
            humaninf = SName + " " + Name.Substring(0, 1) + "." + FName.Substring(0, 1) + ".   " + BornDate.Year + "г.";
            if (ValidateID(id)) ID = id;
            else throw new FormatException(Properties.Resources.Error_Validate_ID);
            
        }
        #region  Проверки данных
        public static bool ValidateSingle(string str)
        {
            if (str == "") return false;
            foreach (char value in str)
            {
                if (!char.IsLetter(value)) return false;
            }
            return true;
        }

        public bool Validate_Death_Date(DateTime dth)
        {
            if (dth<BornDate)return false; 
            return true;
        }

        public static bool ValidateID(string id)
        {
            if (id == "") return false;
            foreach (char value in id)
            {
                if (!char.IsNumber(value)) return false;
            }
            return true;
        }
        #endregion
    }
}
