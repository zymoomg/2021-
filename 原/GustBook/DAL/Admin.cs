using System;
using System.Collections.Generic;
using System.Text;
using GustBook.DBUtility;
using System.Data;


namespace GustBook.DAL
{
    public class Admin
    {
        public DataBase myData = DBHelper.CreateData("mySql");

        ///<summary>
        ///用户登录           数据访问曾 只有声明没有实现
        ///</summary>
        public bool uLogin(GustBook.Model.Admin model)
        {
            myData.AddParameter("@name", model.AdminName);
            myData.AddParameter("@pass", model.PassWord);
            string strsql = "select AdminName,PassWord From Admin where AdminName=@name and PassWord=@pass";
            DataTable dt = myData.ExecuteDataSet(strsql).Tables[0];
            if (dt.Rows.Count < 1)
                return false;
            else return true;

        }
        ///<summary>
        ///删除留言
        ///</summary>
        public bool uDel(int nId)
        {
            //GustBook.Model.Admin mo=new GustBook.Model.Admin();
            myData.AddParameter("@id", nId);

            string sqlstr = "delete from Content Where Id=@id";
            if (myData.ExecuteNonQuery(sqlstr) > 0)
                return true;
            else
                return false;
        }
        ///<summary>
        ///回复留言
        ///</summary>
        public bool uAddRe(GustBook.Model.Content model)
        {
            myData.AddParameter("@id",model.Id);
            myData.AddParameter("@content",model.Reply);
            string sqlstr = "update Content set Reply=@content where Id=@id";
            if (myData.ExecuteNonQuery(sqlstr) > 0)
                return true;
            else return false;
        }
    }
}
