using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace compuSciProj2021
{
    public class validation
    {
        public static bool CheckId(string id)//check user id
        {
            int[] id_12_digits = { 1, 2, 1, 2, 1, 2, 1, 2, 1 };
            int count = 0;
            if (id == null) { return false; }
            id = id.PadLeft(9, '0');
            for (int i = 0; i < 9; i++)
            {
                int num = Int32.Parse(id.Substring(i, 1)) * id_12_digits[i];
                if (num > 9) { num = (num / 10) + (num % 10); }
                count += num;
            }
            return (count % 10 == 0);
        }

        public static bool CheckFName(string fname)//checks if fname longer than 2 and is letters
        {
            string str = "0.1234546+789/*-~!@#$%^&*()_-={}[]'|:;?\'<>";
            for (int i = 0; i < str.Length; i++)
            {
                if (fname.IndexOf(str[i]) != -1)
                    return false;
            }
            return fname.Length >= 2;
        }

        public static bool CheckCatg(String cat)// checks if category was filled in
        {
            if (!cat.Equals("Choose..."))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckAmnt(int amnt)// checks if amount between 0 to 1000
        {
            if (amnt >= 0 && amnt <= 1000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckCost(int cost)//checks if cost between 1 to 1500
        {
            if (cost >= 1 && cost <= 1500)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckPhoneNum(string number)//checks if phone number is not only numbers
        {//checks if phone ok
            string str = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM!@#$%^&*()[]{}:?<>";
            if (number.Length != 10)
                return false;
            for (int i = 0; i < number.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if (number[i].Equals(str[j]))
                        return false;
                }
            }
            return true;
        }

        public static bool CheckEmail(string email)//checks if mail ok 
        {
            try
            {
                var adder = new System.Net.Mail.MailAddress(email);
                return (adder.Address == email);
            }
            catch
            {
                return false;
            }
        }

        public static bool CheckPic(string url)//checks if url is jpg
        {
            if (url.EndsWith("jpg"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckPass(string pass, string verify)//checks if password is between 8 to 16 characters
        {
            if(verify == null || pass == null)
            {
                return false;
            }
            if (verify.Equals(pass) && (pass.Length >= 8 && pass.Length <= 16))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckLName(string lname)//checks if lname longer than 2 and is letters
        {
            string str = "0.1234546+789/*-~!@#$%^&*()_-={}[]'|:;?\'<>";
            for (int i = 0; i < str.Length; i++)
            {
                if (lname.IndexOf(str[i]) != -1)
                    return false;
            }
            return lname.Length >= 2;
        }

        public static bool CheckAge(int age)//checks if age is greater than 16
        {
            if (age > 16)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckUser(User u)
        {
            bool ok = true;
            if (!CheckEmail(u.Addrs))
            {
                ok = false;
            }
            if (!CheckAge(u.Age))
            {
                ok = false;
            }
            if (!CheckFName(u.Firstname))
            {
                ok = false;
            }
            if (!CheckLName(u.Firstname))
            {
                ok = false;
            }
            if (!CheckPass(u.pssWrd, u.passwordVerify))
            {
                ok = false;
            }
            if (!CheckId(u.ID))
            {
                ok = false;
            }
            return ok;
        }

        public static string CheckWhatWrong(User u)
        {
            string ok = "";
            if (!CheckEmail(u.Addrs))
            {
                ok += ", " + "Email address is wrong";
            }
            if (!CheckAge(u.Age))
            {
                ok += ", " + "Age is invalid.";
            }
            if (!CheckFName(u.Firstname))
            {
                ok = ", " + "First name is invalid.";
            }
            if (!CheckLName(u.Firstname))
            {
                ok = ", " + "Last name is invalid.";
            }
            if (!CheckPass(u.pssWrd, u.passwordVerify))
            {
                ok = ", " + "Password invalid or not iterated correctly.";
            }
            if (!CheckId(u.ID))
            {
                ok = ", " + "id is wrong.";
            }
            return ok;
        }

        public static bool idExists(string id)
        {
            bool ok = false;
            userService us = new userService();
            DataSet ds = us.GetUser(id);
            if (ds.Tables[0].Rows.Count != 0)
            {
                ok = true;
            }
            return ok;
        }
    }
}