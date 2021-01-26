using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


namespace GustBook.BLL
{
    public class Message
    {
        private readonly GustBook.DAL.Message dal = new GustBook.DAL.Message();

        ///<summary>
        ///增加一条留言 业务逻辑曾直接调用数据访问曾
        ///</summary>
        public bool Add(GustBook.Model.Content model)
        {
            return dal.Add(model);
        }
        ///<summary>
        ///获取留言列表
        ///</summary>
        public DataSet GetList(int intSta,int intNum)
        {
            return dal.GetList(intSta,intNum); 
        }
    }
}
