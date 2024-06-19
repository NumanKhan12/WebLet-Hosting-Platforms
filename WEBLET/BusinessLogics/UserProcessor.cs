using Dapper;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBLET.DataAccess;
using WEBLET.Models;

namespace WEBLET.BusinessLogics
{
    public class UserProcessor
    {
        public static bool CnicAlreayTaken(string CNIC)
        {
            ApplicationUser user = SqlDataAccess.GetDataModel<ApplicationUser>($"select *from Aspnetusers where cNIC='{CNIC}'", new DynamicParameters());
            if (user==null)
            {
                return false;
            }
            return true;
        }
        public static bool PhoneAlreayTaken(string Phone)
        {
            ApplicationUser user = SqlDataAccess.GetDataModel<ApplicationUser>($"select *from Aspnetusers where PhoneNumber='{Phone}'", new DynamicParameters());
            if (user==null)
            {
                return false;
            }
            return true;
        }
        public static ApplicationUser GetApplicationUser(int MID)
        {
            string userID = SqlDataAccess.GetDataModel<string>($"select MEMBER.MEMBER_USERID from  MEMBER where MEMBER_ID={MID}", new DynamicParameters());
            return SqlDataAccess.GetDataModel<ApplicationUser>($"select * from AspNetUsers where id = '{userID}'", new DynamicParameters());
        }
        public static ApplicationUser GetApplicationUserById(string userID)
        {
            
            return SqlDataAccess.GetDataModel<ApplicationUser>($"select * from AspNetUsers where id = '{userID}'", new DynamicParameters());
        }
        public static List<Menu> GetUserMenu()
        {
            List<Menu> menus = SqlDataAccess.LoadDataList<Menu>("select *from Menu where issidemenuitem=1 order by [order] asc", new DynamicParameters());
            List<Menu> Herarchy = menus.Where(m => m.parentID == null).ToList();
            for (int i = 0; i < Herarchy.Count; i++)
            {
                Herarchy[i].Menus = menus.Where(m => m.parentID == Herarchy[i].id).ToList();
                for (int j = 0; j < Herarchy[i].Menus.Count; j++)
                {
                    Herarchy[i].Menus[j].Menus = menus.Where(m => m.parentID == Herarchy[i].Menus[j].id).ToList();
                }
            }
            return Herarchy.ToList();
        }
    }
}
