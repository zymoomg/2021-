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
                Image1.ImageUrl = "Images/face/1.gif";
            }
        }

        private void GetPic()
        {
            ListItem li = new ListItem();
            for (int i = 0; i < 20; i++)
            {
                int Num = i + 1;
                ddllPic.Items.Add("头像" + Num.ToString());
                ddllPic.Items[i].Value = "Images/face/" + Num.ToString() + ".gif";
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
            if (this.Radio1.Checked) { faceurl = "images/face/face1.gif"; }
            if (this.Radio2.Checked) { faceurl = "images/face/face2.gif"; }
            if (this.Radio3.Checked) { faceurl = "images/face/face3.gif"; }
            if (this.Radio4.Checked) { faceurl = "images/face/face4.gif"; }
            if (this.Radio5.Checked) { faceurl = "images/face/face5.gif"; }
            if (this.Radio6.Checked) { faceurl = "images/face/face6.gif"; }
            if (this.Radio7.Checked) { faceurl = "images/face/face7.gif"; }
            if (this.Radio8.Checked) { faceurl = "images/face/face8.gif"; }
            if (this.Radio9.Checked) { faceurl = "images/face/face9.gif"; }
            if (this.Radio10.Checked) { faceurl = "images/face/face10.gif"; }
            if (this.Radio11.Checked) { faceurl = "images/face/face11.gif"; }
            if (this.Radio12.Checked) { faceurl = "images/face/face12.gif"; }
            if (this.Radio13.Checked) { faceurl = "images/face/face13.gif"; }
            if (this.Radio14.Checked) { faceurl = "images/face/face14.gif"; }
            if (this.Radio15.Checked) { faceurl = "images/face/face15.gif"; }
            if (this.Radio16.Checked) { faceurl = "images/face/face16.gif"; }
            if (this.Radio17.Checked) { faceurl = "images/face/face17.gif"; }
            if (this.Radio18.Checked) { faceurl = "images/face/face18.gif"; }
            if (this.Radio19.Checked) { faceurl = "images/face/face19.gif"; }
            if (this.Radio20.Checked) { faceurl = "images/face/face20.gif"; }
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