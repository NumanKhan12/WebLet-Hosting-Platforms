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
    public class ChatProccess
    {
        public static List<string> ConsultantList()
        {
            return SqlDataAccess.LoadDataList<string>("select UserId from AspNetUserRoles where RoleId=3", new DynamicParameters { });
        }




        public static int AddChat(AspNetMesg msg)
        {
            DynamicParameters dbrms = new DynamicParameters();
            dbrms.Add("@MSG", msg.MSG);
            dbrms.Add("@FROM_USER", msg.FROM_USER);
            dbrms.Add("@TO_USER", msg.TO_USER);
            dbrms.Add("@MSG_DATETIME", msg.MSG_DATETIME);
            dbrms.Add("@ISACTIVE", msg.ISACTIVE);
            string qry = @"insert into AspNetMesg (MSG_ID,MSG,FROM_USER,TO_USER,MSG_DATETIME,ISACTIVE) values
                          (DEFAULT,@MSG,@FROM_USER,@TO_USER,@MSG_DATETIME,@ISACTIVE)";
            return SqlDataAccess.insertDataDapper(qry,dbrms);
        }




        public static List<AspNetMesg> GetChat(string User, string Cunsaltent)
        {
            string qry= $@"select * from AspNetMesg where TO_USER='{User}' OR ( FROM_USER='{User}' And TO_USER='{Cunsaltent}') and 
                        ISACTIVE = '1' order by MSG_DATETIME ASC";
            return SqlDataAccess.LoadDataList<AspNetMesg>(qry, new DynamicParameters { });
        }





        public static int SaveUserConnection(AspNetUserConnection anuc)
        {
            string Qurye = null;
            DynamicParameters dbrms = new DynamicParameters();
            dbrms.Add("@CONNECTION_ID", anuc.CONNECTION_ID);
            dbrms.Add("@USER_ID", anuc.USER_ID);
            dbrms.Add("@IS_ONLINE", anuc.IS_ONLINE);
            dbrms.Add("@CON_DATETIME", DateTime.Now);
            string qry = $@"select CONNECTION_ID from AspNetUserConnection where USER_ID='{anuc.USER_ID}'";
            string IsCheckStates = SqlDataAccess.GetSingleDataValues<string>(qry, new DynamicParameters { });
            if(IsCheckStates==null)
            {
                  Qurye = @"insert into AspNetUserConnection (ID,CONNECTION_ID,USER_ID,IS_ONLINE,CON_DATETIME)
                        values(DEFAULT,@CONNECTION_ID,@USER_ID,@IS_ONLINE,@CON_DATETIME)";

            }
            else
            {
                  Qurye = @"Update AspNetUserConnection set 
                                CONNECTION_ID=@CONNECTION_ID,
                                IS_ONLINE=@IS_ONLINE,
                                CON_DATETIME=@CON_DATETIME
                            where USER_ID=@USER_ID";

            }

            return SqlDataAccess.insertDataDapper(Qurye, dbrms);
        }






        public static List<IsSentMsgUser> IsSentMsgUserList()
        {
            string qry = @"select distinct Id , Email,[Name] from AspNetUsers 
                        inner join AspNetMesg on AspNetUsers.Id=AspNetMesg.FROM_USER
                        inner join AspNetUserRoles on AspNetUsers.Id=AspNetUserRoles.UserId
                        where AspNetUserRoles.RoleId=2 ";
            return SqlDataAccess.LoadDataList<IsSentMsgUser>(qry, new DynamicParameters { });
        }




        public static AspNetUserConnection AspNetUserConnectionData(string userid)
        {
            try
            {
                string qry = $@"select *  from AspNetUserConnection where [USER_ID]='{userid}'";
                var result = SqlDataAccess.GetDataModel<AspNetUserConnection>(qry, new DynamicParameters { });

                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
          
          
        }




        public static bool IsChackOnline(string userid)
        {
            string qry = $@"select IS_ONLINE from from AspNetUserConnection where [USER_ID]='{userid}'";
            string result= SqlDataAccess.GetSingleDataValues<string>(qry, new DynamicParameters { });
            if(result== "ONLINE")
            {
                return true;
            }
            
             return false;
        }




        public static void Msg_Reade_States(string msg_sender_id , int states)
        {
            string qry =$@"update AspNetUserConnection set MSG_ISREADE='{states}' where [USER_ID]='{msg_sender_id}'";
            SqlDataAccess.insertDataDapper(qry, new DynamicParameters { });
        }

        //public  static bool Chack_Msg_IsRead(string userId)
        //{
        //    string qry = $@"select";
        //}

        

    }
}
    