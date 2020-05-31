using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;

namespace Tree
{
    public class HumanDB
    {
        public List<Human> dblist {get; set;}
        public string Clan_Name { get; set; }
        public string Code { get; set; }
        private static string Validate_Code { get { return GetHashCode("102030"); } }
        public DateTime Date_Create { get; }
        public DateTime Date_Last_Edit { get; set; }
              

        public HumanDB(string clan_name, string code)
        {
            if (clan_name != "") Clan_Name = clan_name;
            else throw new FormatException(Properties.Resources.Error_Nothing_ClanName);
            if (code != "") Code = GetHashCode(code);
            else throw new FormatException(Properties.Resources.Error_Nothing_Code);
            Date_Create = DateTime.Now.Date;
            Date_Last_Edit = DateTime.Now.Date;
            dblist = new List<Human>();
        }

        public HumanDB(string clan_name, string date_create, string date_last_edit, string code) : this(clan_name, code)
        {
            Code = code;
            Date_Create = StringToDate(date_create);
            Date_Last_Edit = StringToDate(date_last_edit);
            dblist = new List<Human>();
        }
               

        public static DateTime StringToDate(string str)
        {
            try
            {
                int day = int.Parse(str[0].ToString() + str[1].ToString());
                int mounth = int.Parse(str[3].ToString() + str[4].ToString());
                int year = int.Parse(str[6].ToString() + str[7].ToString() + str[8].ToString() + str[9].ToString());
                DateTime res = new DateTime(year, mounth, day);
                return res;
            }
            catch { throw new FormatException(Properties.Resources.Error_Validate_Str_Date); }
        }

        
        public void WtiteToTxt(string path)
        {
            if (this != null)
            {
                string[] to_write_info = { Clan_Name, Date_Create.ToShortDateString(), Date_Last_Edit.ToShortDateString(), Code, Validate_Code };
                File.WriteAllLines(path, to_write_info);
                if (dblist != null)
                {                    
                    string[] to_write_db = new string[dblist.Count*3];
                    int j = 0;
                    for (int i = 0; i < dblist.Count*3; i+=3)
                    {
                        string towrite1 = "{" + dblist[j].Name + "}{" + dblist[j].SName + "}{" + dblist[j].FName + "}{"
                            + dblist[j].BornDate + "}{" + dblist[j].Life + "}{" + dblist[j].DeathDate + "}{" + dblist[j].Childq +
                            "}{" + dblist[j].ID + "}" ;
                        string towrite2 = "°";
                        foreach (string id in dblist[j].Parents )  {
                            towrite2 += "{" + id + "}";  }
                        
                        string towrite3 = "°";
                        foreach (string id in dblist[j].Children)
                        {
                            towrite3 += "{" + id + "}";
                        }

                        to_write_db[i] = towrite1;
                        to_write_db[i + 1] = towrite2;
                        to_write_db[i + 2] = towrite3;
                        j++;
                    }
                    File.AppendAllLines(path, to_write_db);
                }
            }
        }

        public static HumanDB ReadFromTxt(string path)
        {
            string[] data = File.ReadAllLines(path);
            HumanDB humandb;
            if (data.Length > 4 && data[4] == Validate_Code)
            {
                humandb = new HumanDB(data[0], data[1], data[2], data[3]);
                if (data.Length > 5 && (data.Length - 5) % 3 == 0)
                {
                    for (int i = 5; i < data.Length; i += 3)
                    {
                        string data1 = data[i];
                        string data2 = data[i + 1];
                        string data3 = data[i + 2];
                        
                        int j = 0, k = 0, l = 0;
                        string[] temp0 = new string[8];
                        foreach (char value in data1)
                        {
                            switch (value)
                            {
                                case '{':
                                    {
                                        break;
                                    }
                                case '}':
                                    {
                                        j++;
                                        break;
                                    }
                                default:
                                    {
                                        temp0[j] += value;
                                        break;
                                    }
                            }
                        }

                        int q = Int32.Parse(temp0[6]);

                        string[] temp1 = new string[2];
                        foreach (char value in data2)
                        {
                            switch (value)
                            {
                                case '°':
                                    {
                                        break;
                                    }
                                case '{':
                                    {
                                        break;
                                    }
                                case '}':
                                    {
                                        k++;
                                        break;
                                    }
                                default:
                                    {
                                        temp1[k] += value;
                                        break;
                                    }
                            }
                        }

                        string[] temp2 = new string[q];
                        if (q > 0)
                        {                            
                            foreach (char value in data3)
                            {
                                switch (value)
                                {
                                    case '°':
                                        {
                                            break;
                                        }
                                    case '{':
                                        {
                                            break;
                                        }
                                    case '}':
                                        {
                                            l++;
                                            break;
                                        }
                                    default:
                                        {
                                            temp2[l] += value;
                                            break;
                                        }
                                }
                            }
                        }

                        humandb.dblist.Add(new Human(temp0[0], temp0[1], temp0[2], StringToDate(temp0[3]), Boolean.Parse(temp0[4]), StringToDate(temp0[5]), temp1, q, temp2, temp0[7]));
                    }
                    if (humandb != null) return humandb;
                    else throw new FormatException(Properties.Resources.Error_Validate_File_Gen);
                }
            }
            else throw new FormatException(Properties.Resources.Error_Validate_File);
            return humandb;
        }


        public static string GetHashCode(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

    }
}
