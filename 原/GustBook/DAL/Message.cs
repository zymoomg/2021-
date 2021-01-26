using System;
using System.Collections.Generic;
using System.Text;
using GustBook.DBUtility;
using System.Data;

namespace GustBook.DAL
{
    public  class Message
    {
        public DataBase myData = DBHelper.CreateData("mySql");
        #region 成员方法

        ///<summary>
        ///添加一条留言
        ///</summary>
        public bool Add(GustBook.Model.Content model)
        {
            myData.AddParameter("@userName",model.UserName);
            myData.AddParameter("@picUrl",model.PicUrl);
            myData.AddParameter("@userEmail", model.UserMail);
            myData.AddParameter("@userUrl", model.UserUrl);
            myData.AddParameter("@userQQ",model.UserQQ);
            myData.AddParameter("@faceUrl",model.FaceUrl);
            myData.AddParameter("@userIp",model.UserIp);
            myData.AddParameter("@addTime", model.AddTime);
            myData.AddParameter("@content",model.Contents);
            myData.AddParameter("@ishid",model.IsHid);

            string sqlstr = "insert into Content(UserName,UserEmail,UserQQ,UserUrl,UserIp,faceUrl,PicUrl,AddTime,Content,Reply,IsHid,IsReply)";
            sqlstr += " values(@userName,@userEmail,@userQQ,@userUrl,@userIp,@faceUrl,@picUrl,@addTime,@content,'',@ishid,0)";
            if (myData.ExecuteNonQuery(sqlstr) > 0)
                return true;
            else return false;
        }
        ///<summary>
        ///获取留言数据
        ///</summary>
        public DataSet GetList(int intSta,int intNum)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append("Select * From Content order by AddTime desc");//访问数据库
            //if(SqlWhere.Trim()!="")
            //    strsql.Append(" Where "+SqlWhere);
            return myData.ExecuteDataSet(strsql.ToString(),intSta,intNum);
        }

        #endregion
    }
}
