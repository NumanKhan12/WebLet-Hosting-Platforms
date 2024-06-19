using Dapper;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBLET.DataAccess;
using WEBLET.Models;

namespace WEBLET.BusinessLogics
{
    public class MemberProcessor
    {
        public static Member GetMember(string UserID)
        {
            try
            {
                return SqlDataAccess.GetDataModel<Member>($"select *from MEMBER where MEMBER_USERID='{UserID}'", new DynamicParameters());
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static Member GetMemberByCNIC(string CNIC)
        {
            try
            {
                return SqlDataAccess.GetDataModel<Member>($"select *from MEMBER where MEMBER_CNIC='{CNIC}'", new DynamicParameters());
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static int SaveMEMBER(Member MEMBER)
        {
            var dbargs = new DynamicParameters();
            dbargs.Add("@MEMBER_ID", MEMBER.MEMBER_ID);
            dbargs.Add("@MEMBER_PJ_CODE", MEMBER.MEMBER_PJ_CODE);
            dbargs.Add("@MEMBER_NAME", MEMBER.MEMBER_NAME);
            dbargs.Add("@MEMBER_TITLE", MEMBER.MEMBER_TITLE);
            dbargs.Add("@MEMBER_FATHER_NAME", MEMBER.MEMBER_FATHER_NAME);
            dbargs.Add("@MEMBER_DOB", MEMBER.MEMBER_DOB);
            dbargs.Add("@MEMBER_CNIC", MEMBER.MEMBER_CNIC);
            dbargs.Add("@MEMBER_COUNTRY", MEMBER.MEMBER_COUNTRY);
            dbargs.Add("@MEMBER_CITY", MEMBER.MEMBER_CITY);
            dbargs.Add("@MEMBER_ADDRESS", MEMBER.MEMBER_ADDRESS);
            dbargs.Add("@MEMBER_USERID", MEMBER.MEMBER_USERID);
            dbargs.Add("@MEMBER_PIC", MEMBER.MEMBER_PIC);
            try
            {
             return SqlDataAccess.insertDataDapper("insert into MEMBER values(@MEMBER_PJ_CODE,@MEMBER_NAME,@MEMBER_TITLE,@MEMBER_FATHER_NAME,@MEMBER_CNIC,@MEMBER_COUNTRY,@MEMBER_CITY,@MEMBER_ADDRESS,@MEMBER_USERID,@MEMBER_DOB,@MEMBER_PIC)", dbargs);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public static int Update(Member MEMBER)
        {
            var dbargs = new DynamicParameters();
            dbargs.Add("@MEMBER_ID", MEMBER.MEMBER_ID);
            dbargs.Add("@MEMBER_PJ_CODE", MEMBER.MEMBER_PJ_CODE);
            dbargs.Add("@MEMBER_NAME", MEMBER.MEMBER_NAME);
            dbargs.Add("@MEMBER_TITLE", MEMBER.MEMBER_TITLE);
            dbargs.Add("@MEMBER_FATHER_NAME", MEMBER.MEMBER_FATHER_NAME);
            dbargs.Add("@MEMBER_DOB", MEMBER.MEMBER_DOB);
            dbargs.Add("@MEMBER_CNIC", MEMBER.MEMBER_CNIC);
            dbargs.Add("@MEMBER_COUNTRY", MEMBER.MEMBER_COUNTRY);
            dbargs.Add("@MEMBER_CITY", MEMBER.MEMBER_CITY);
            dbargs.Add("@MEMBER_ADDRESS", MEMBER.MEMBER_ADDRESS);
            dbargs.Add("@MEMBER_USERID", MEMBER.MEMBER_USERID);
            dbargs.Add("@MEMBER_PIC", MEMBER.MEMBER_PIC);
            return SqlDataAccess.insertDataDapper("update  MEMBER set "+
            "MEMBER_PJ_CODE=@MEMBER_PJ_CODE," +
            "MEMBER_NAME=@MEMBER_NAME," +
            "MEMBER_TITLE=@MEMBER_TITLE," +
            "MEMBER_FATHER_NAME=@MEMBER_FATHER_NAME," +
            "MEMBER_DOB=@MEMBER_DOB," +
            "MEMBER_CNIC=@MEMBER_CNIC," +
            "MEMBER_COUNTRY=@MEMBER_COUNTRY," +
            "MEMBER_CITY=@MEMBER_CITY," +
            "MEMBER_ADDRESS=@MEMBER_ADDRESS," +
            "MEMBER_PIC=@MEMBER_PIC," +
            "MEMBER_USERID=@MEMBER_USERID " +
            "where MEMBER_ID = @MEMBER_ID", dbargs);
             
        }
        public static int Delete(int Id)
        {
            try
            {
                return SqlDataAccess.insertDataDapper($"Delete from MEMBER where MEMBER_ID ={ Id}", new DynamicParameters());
            }
            catch (Exception ex)
            {
                return 2;
                throw;
            }
        }

        public static List<Member> GetMembers(int PJ_CODE)
        {
            try
            {
                return SqlDataAccess.LoadDataList<Member>($"select *from MEMBER where MEMBER_PJ_CODE={PJ_CODE}", new DynamicParameters());
            }
            catch (Exception ex)
            {
                throw;
            }
        }

     

    }
}
