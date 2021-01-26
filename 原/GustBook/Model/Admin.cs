using System;
using System.Collections.Generic;
using System.Text;
//数据实体层
namespace GustBook.Model
{
    public class Admin
    {
        public Admin() { }

        #region

        private int _Id;
        private string _AdminName;
        private string _PassWord;

        public int Id
        {
            set { _Id = value; }
            get { return _Id; }
        }
        public string AdminName
        {
            set { _AdminName = value; }
            get { return _AdminName; }
        }

        public string PassWord
        {
            set { _PassWord = value; }
            get { return _PassWord; }
        }

        #endregion
    }
}
