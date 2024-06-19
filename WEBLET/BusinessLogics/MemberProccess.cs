using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBLET.DataAccess;
using WEBLET.Models;

namespace WEBLET.BusinessLogics
{
    public class MemberProccess
    {
        public static List<PanelDetails> MemberViewPanelList()
        {
            return SqlDataAccess.LoadDataList<PanelDetails>("select * from AspPanelDetails", new DynamicParameters { });
        }
    }
}
