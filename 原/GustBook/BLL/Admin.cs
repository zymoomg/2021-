using System;
using System.Collections.Generic;
using System.Text;

namespace GustBook.BLL
{
    public class Admin
    {
        GustBook.DAL.Admin dal = new GustBook.DAL.Admin();
        ///<summary>
        ///用户登录
        ///</summary>
        public bool ulogin(GustBook.Model.Admin model)
        {
            return dal.uLogin(model);
        }
        ///<summary>
        ///删除留言
        ///</summary>
        public bool uDel(int nId)
        {
            return dal.uDel(nId);
        }
        ///<summary>
        ///回复留言
        ///</summary>
        public bool uAddRe(GustBook.Model.Content model)
        {
            return dal.uAddRe(model);
        }
    }
}
