using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBLET.DataAccess;
using WEBLET.Models;
using WEBLET.ViewModels;

namespace WEBLET.BusinessLogics
{
    public class PanelProcessor
    {
        public static List<ASP_SM_PANEL> PanelList()
        {
            var data = SqlDataAccess.LoadDataList<ASP_SM_PANEL>("select * from ASP_SM_PANEL", new DynamicParameters { });
            return data;
        }
        public static List<PanelDetails> PanelDetailsList()
        {
            return SqlDataAccess.LoadDataList<PanelDetails>("select * from AspPanelDetails", new DynamicParameters { });
        }
        public static int AddPanel(ASP_SM_PANEL obj)
        {
            DynamicParameters dbrs = new DynamicParameters();
            dbrs.Add("@Panel_Code", obj.Panel_Code);
            dbrs.Add("@Panel_Name", obj.Panel_Name);
            string qry = "insert into ASP_SM_PANEL (ID,Panel_Code,Panel_Name) values(DEFAULT,@Panel_Code,@Panel_Name)";
            return SqlDataAccess.insertDataDapper(qry, dbrs);

        }
        public static int UpdatePanel(ASP_SM_PANEL obj)
        {
            DynamicParameters dbrs = new DynamicParameters();
            //dbrs.Add("@ID", obj.ID);
            dbrs.Add("@Panel_Code", obj.Panel_Code);
            dbrs.Add("@Panel_Name", obj.Panel_Name);
            string qry = $@"update ASP_SM_PANEL set Panel_Code=@Panel_Code , Panel_Name=@Panel_Name where ID='{obj.ID}'";
            return SqlDataAccess.insertDataDapper(qry, dbrs);


        }
        public static int DeletePanel(Guid ID)
        {
            string qry = $"delete from ASP_SM_PANEL where ID = '{ID}'";

            return SqlDataAccess.insertDataDapper(qry, new DynamicParameters { });

        }
   
        public static Guid AddPanelDetails(PanelViewModel obj)
        {
            //string delqry = $"delete AspPanelDetails where PANEL_ID={obj.PANEL_ID} ";
            //SqlDataAccess.insertDataDapper(delqry, new DynamicParameters { });
            var de_number = SqlDataAccess.GetSingleDataValues<int>("select PanelDetailsNumber from AspPanelDetails ORDER BY PanelDetailsNumber DESC",new DynamicParameters { });
            de_number = de_number + 1;  
            DynamicParameters dbrm = new DynamicParameters();
            dbrm.Add("@PANEL_ID", obj.PANEL_ID);
            dbrm.Add("@DISCRIPTION", obj.DISCRIPTION);
            dbrm.Add("@CONDITION", obj.CONDITION);
            dbrm.Add("@DELEVERYDAY", obj.DELEVERYDAY);
            dbrm.Add("@FROM_DATE", obj.FROM_DATE);
            dbrm.Add("@TO_DATE", obj.TO_DATE);
            dbrm.Add("@PRICE", obj.PRICE);
            dbrm.Add("@SHIPMRNT", obj.SHIPMRNT);
            dbrm.Add("@DEMO_LINK", obj.DEMO_LINK);
            dbrm.Add("@RETURNS_DIS", obj.RETURNS_DIS);
            dbrm.Add("@PanelDetailsNumber", de_number);
            string qry = @$"insert into AspPanelDetails  (ID, PANEL_ID, DISCRIPTION, CONDITION, DELEVERYDAY, FROM_DATE, TO_DATE, PRICE, SHIPMRNT,DEMO_LINK,RETURNS_DIS,PanelDetailsNumber)
                            values(DEFAULT, @PANEL_ID, @DISCRIPTION, @CONDITION, @DELEVERYDAY, @FROM_DATE, @TO_DATE, @PRICE, @SHIPMRNT,@DEMO_LINK,@RETURNS_DIS,@PanelDetailsNumber)";

             SqlDataAccess.insertDataDapper(qry, dbrm);
            return SqlDataAccess.GetSingleDataValues<Guid>("select ID from AspPanelDetails ", new DynamicParameters{ });
            }
        public static int AddPicPanels(string fileName,string culName,string Id)
        {
            string qre = $@"update AspPanelDetails set {culName}='{fileName}' where ID='{Id}' ";
            return SqlDataAccess.insertDataDapper(qre, new DynamicParameters { });
             
        }

        public static int UpdatePanelDetails(PanelViewModel obj)
        {
            //string delqry = $"delete AspPanelDetails where PANEL_ID={obj.PANEL_ID} ";
            //SqlDataAccess.insertDataDapper(delqry, new DynamicParameters { });
            DynamicParameters dbrm = new DynamicParameters();
            dbrm.Add("@PANEL_ID", obj.PANEL_ID);
            dbrm.Add("@DISCRIPTION", obj.DISCRIPTION);
            dbrm.Add("@CONDITION", obj.CONDITION);
            dbrm.Add("@DELEVERYDAY", obj.DELEVERYDAY);
            dbrm.Add("@FROM_DATE", obj.FROM_DATE);
            dbrm.Add("@TO_DATE", obj.TO_DATE);
            dbrm.Add("@PRICE", obj.PRICE);
            dbrm.Add("@SHIPMRNT", obj.SHIPMRNT);
            dbrm.Add("@DEMO_LINK", obj.DEMO_LINK);
            dbrm.Add("@RETURNS_DIS", obj.RETURNS_DIS);
            string qry = $@"update  AspPanelDetails  set   PANEL_ID=@PANEL_ID, DISCRIPTION=@DISCRIPTION, CONDITION=@CONDITION,
                         DELEVERYDAY=@DELEVERYDAY, FROM_DATE=@FROM_DATE, TO_DATE=@TO_DATE, PRICE=@PRICE, SHIPMRNT= @SHIPMRNT, 
                         DEMO_LINK=@DEMO_LINK,RETURNS_DIS=@RETURNS_DIS where ID='{obj.ID}'";

            return SqlDataAccess.insertDataDapper(qry, dbrm);
        //    return SqlDataAccess.GetSingleDataValues<Guid>("select ID from AspPanelDetails ", new DynamicParameters { });
        }

        public static int DelectePanelDetails(Guid ID)
        {
            string qry = $"delete from AspPanelDetails where ID = '{ID}'";
         return   SqlDataAccess.insertDataDapper(qry, new DynamicParameters { });
        }

    }
}
