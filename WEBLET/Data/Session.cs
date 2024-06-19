using WEBLET.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBLET.Data
{
    public class Session
    {
        public static int GetCpCode(string UserIdentity)
        {
            return SqlDataAccess.GetSingleDataValues<int>($"select PJ_CODE from AspNetUsers where Email='{UserIdentity}' and UserName='{UserIdentity}'", new Dapper.DynamicParameters());
        }
    }
}
