using Dapper;
using WEBLET.DataAccess;
using WEBLET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBLET.BusinessLogics
{
    public class Role
    {
        public static List<AspNetRole> NetRoleList()
        {
            string qry = "select * from AspNetRoles";
            var listrole = SqlDataAccess.LoadDataList<AspNetRole>(qry,new DynamicParameters { });
            return listrole;
        }
    }
}
