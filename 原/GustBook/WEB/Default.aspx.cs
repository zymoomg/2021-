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
using GustBook.DBUtility;

namespace GustBook.WEB
{
    public partial class Default : System.Web.UI.Page
    {
        public GustBook.DBUtility.ShowMessagae sm = new GustBook.DBUtility.ShowMessagae();
        public DataBase myData = DBHelper.CreateData("mySql");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Response.Cookies.Add(new HttpCookie("CheckCode",""));
                AspNetPager1.RecordCount = (int)myData.ExecuteScalar("Select Count(*) from Content");
                GetList();
            }
            if (Session["nName"] != null)
            {
                Panel1.Visible = false;
            }

            if (Request.QueryString["action"] == "loginout")
            {
                Session["nName"] = null;
                Panel1.Visible = true;
                GustBook.DBUtility.ShowMessagae sm = new GustBook.DBUtility.ShowMessagae();
                sm.ShowRedirect("已退出管理模式！","default.aspx");
            }

            if (Request.QueryString["action"] == "del")
            { 
                //GustBook.Model.Admin mo = new GustBook.Model.Admin();
                //mo.Id =int.Parse( Request.QueryString["id"]);
                int nId = int.Parse(Request.QueryString["id"]);
                GustBook.BLL.Admin bll = new GustBook.BLL.Admin();
                if (bll.uDel(nId))
                    sm.ShowRedirect("删除成功！", "default.aspx");
                else
                    sm.ShowRedirect("出现异常！", "default.aspx");
            }
        }

        private void GetList()
        {
            int intStart = AspNetPager1.PageSize * (AspNetPager1.CurrentPageIndex - 1);//要读取的开始行，这句是如何计算的，不用关心。因为他基本上算是组件的一个计算公式。当然，如果你愿意花精力去研究，那也是可以的。
            int intNum = AspNetPager1.PageSize;//一共要读取多少行，请在.aspx页设置PageSize的大小

            GustBook.BLL.Message bll = new GustBook.BLL.Message();
            Repeater1.DataSource = bll.GetList(intStart,intNum);
            Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if (Request.Cookies["CheckCode"] == null)
            //{
            //    sm.ShowLocation("您的浏览器设置已被禁用 Cookies，您必须设置浏览器允许使用 Cookies 选项后才能使用本系统。");
            //}

        //    if (String.Compare(Request.Cookies["CheckCode"].Value, TextBox3.Text.ToString().Trim(), true) != 0)
         //   {
         //       sm.ShowLocation("验证码输入有误。");
         //   }
        //    else
            {
                GustBook.Model.Admin mo = new GustBook.Model.Admin();
                mo.AdminName = TextBox1.Text.Trim();
                mo.PassWord = TextBox2.Text.Trim();

                GustBook.BLL.Admin bll = new GustBook.BLL.Admin();
                if (bll.ulogin(mo))
                {
                    Panel1.Visible = false;
                    //Session.Add("nName", mo.AdminName);
                    Session["nName"] = mo.AdminName;
                    Response.Redirect("default.aspx");
                }
                else
                {
                    GustBook.DBUtility.ShowMessagae sm = new GustBook.DBUtility.ShowMessagae();
                    sm.ShowLocation("请检查用户名和密码是否正确！！");
                }
            }
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            GetList();
        }
    }
}
