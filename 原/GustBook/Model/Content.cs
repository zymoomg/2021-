using System;
using System.Collections.Generic;
using System.Text;

namespace GustBook.Model
{
    public class Content
    {
        public Content() { }

        #region Model

        private int _Id;
        private string _userName;
        private string _userUrl;
        private string _userMail;
        private string _userQQ;
        private string _userIp;
        private string _faceUrl;
        private string _picUrl;
        private DateTime _addTime;
        private string _content;
        private string _reply;
        private int _isHid;
        private int _isreply;

        #endregion

        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            set { _Id = value; }
            get { return _Id; }
        }
        public string UserName
        {
            set { _userName = value; }
            get { return _userName; }
        }
        public string UserMail
        {
            set { _userMail = value; }
            get { return _userMail; }
        }
        public string UserUrl
        {
            set { _userUrl = value; }
            get { return _userUrl; }
        }














        public string UserIp
        {
            set { _userIp = value; }
            get { return _userIp; }
        }
        public string FaceUrl
        {
            set { _faceUrl = value; }
            get { return _faceUrl; }
        }
        public string PicUrl
        {
            set { _picUrl = value; }
            get { return _picUrl; }
        }
        public string UserQQ
        {
            set { _userQQ = value; }
            get { return _userQQ; }
        }
        public DateTime AddTime
        {
            set { _addTime = value; }
            get { return _addTime; }
        }
        public string Contents
        {
            set { _content = value; }
            get { return _content; }
        }
        public string Reply
        {
            set { _reply = value; }
            get { return _reply; }
        }
        public int IsHid
        {
            set { _isHid = value; }
            get { return _isHid; }
        }
        public int IsReply
        {
            set { _isreply = value; }
            get { return _isreply; }
        }
    }
}
