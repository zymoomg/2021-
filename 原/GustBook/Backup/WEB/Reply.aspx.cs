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
    public partial class Reply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GustBook.DBUtility.ShowMessagae sm = new GustBook.DBUtility.ShowMessagae();
            GustBook.Model.Content mo = new GustBook.Model.Content();
            mo.Id=int.Parse(Request.QueryString["id"]);
            mo.Reply = FCKeditor1.Value;

            GustBook.BLL.Admin bll = new GustBook.BLL.Admin();
            if (bll.uAddRe(mo))
                sm.ShowRedirect("回复成功！", "Default.aspx");
            else sm.Show("回复不成功！");
        }
    }
}
