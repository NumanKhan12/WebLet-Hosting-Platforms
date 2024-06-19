using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBLET.DataAccess;
using WEBLET.Models;

namespace WEBLET.BusinessLogics
{
    public class AdminChildRoleProccess
    {
        public static int InsertRightRole(AdminChildRole pAR)
        {
            string qry = "insert into PaymentApprovalRights values (DEFAULT,@USER_ID,@TOKEN,@CONFIRMATION_TOKEN)";
            DynamicParameters dbrs = new DynamicParameters();
            dbrs.Add("@USER_ID", pAR.USER_ID);
            dbrs.Add("@TOKEN", pAR.TOKEN);
            dbrs.Add("@CONFIRMATION_TOKEN", pAR.CONFIRMATION_TOKEN);
            return SqlDataAccess.insertDataDapper(qry, dbrs);

        }
    }
}
