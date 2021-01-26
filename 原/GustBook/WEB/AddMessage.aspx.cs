using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace GustBook.WEB
{
    public partial class AddMessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetPic();
                Image1.ImageUrl = "Images/face/18.jpg";
            }
        }

        private void GetPic()
        {
            ListItem li = new ListItem();
            for (int i = 0; i < 20; i++)
            {
                int Num = i + 1;
                ddllPic.Items.Add("头像" + Num.ToString());
                ddllPic.Items[i].Value = "Images/face/" + Num.ToString() + ".jpg";
            }
        }


        protected void ddllPic_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Image1.ImageUrl = ddllPic.SelectedValue.ToString();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            GustBook.DBUtility.ShowMessagae ShowMess = new GustBook.DBUtility.ShowMessagae();
            GustBook.Model.Content ad = new GustBook.Model.Content();
            ad.UserName = txtName.Text.Trim();
            ad.PicUrl = ddllPic.SelectedValue.ToString();
            ad.UserMail = txtEmail.Text.Trim();
            ad.UserUrl = txtUrl.Text.Trim();
            ad.UserQQ = txtQQ.Text.Trim();

            string faceurl = "";
           
            ad.FaceUrl = faceurl;
            ad.UserIp = HttpContext.Current.Request.UserHostAddress;

            ad.Contents = FCKeditor1.Value;
            
            if (CheckBox1.Checked == true)
                ad.IsHid = 1;
            else
                ad.IsHid = 0;
          
            ad.AddTime = System.DateTime.Now;
            GustBook.BLL.Message bll = new GustBook.BLL.Message();
            if (bll.Add(ad))
                ShowMess.ShowRedirect("留言发表成功！", "default.aspx");
            else
                ShowMess.Show("发表失败:(");
        }
    }
}