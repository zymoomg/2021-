using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;

namespace GustBook.DBUtility
{
    /// <summary>
    /// 信息输出通用方法   数据访问层 接口的实现
    /// </summary>
    public class ShowMessagae
    {

        /// <summary>
        /// 一般输出
        /// </summary>
        /// <param name="str"></param>
        public void Write(string str)
        {
            System.Web.HttpContext.Current.Response.Write(str);
        }
        /// <summary>
        /// 显示一段自定义的输出代码
        /// </summary>
        /// <param name="MyPage"></param>
        /// <param name="strCode"></param>
        public void ShowJS(System.Web.UI.Page MyPage, string strCode)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<script language=\"javascript\"> \n");
            sb.Append(strCode.Trim());
            sb.Append("</script>");
            MyPage.Response.Write(sb.ToString());
        }
        /// <summary>
        /// 页面重载
        /// </summary>
        public void Location()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<script language=\"javascript\"> \n");
            sb.Append("window.location.href=window.location.href;");
            sb.Append("</script>");
            System.Web.HttpContext.Current.Response.Write(sb.ToString());
        }
        /// <summary>
        /// 显示一个弹出窗口
        /// </summary>
        /// <param name="str"></param>
        public void Show(string str)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<script language=\"javascript\"> \n");
            sb.Append("alert(\"" + str.Trim() + "\"); \n");
            sb.Append("</script>");
            System.Web.HttpContext.Current.Response.Write(sb.ToString());
        }
        /// <summary>
        /// 显示一个弹出窗口，并关闭当前页
        /// </summary>
        /// <param name="str"></param>
        public void ShowClose(string str)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script language=\"javascript\">\n");
            sb.Append("alert(\"" + str.Trim() + "\"); \n");
            sb.Append("window.close();\n");
            sb.Append("</script>\n");
            System.Web.HttpContext.Current.Response.Write(sb.ToString());
        }
        /// <summary>
        /// 显示一个弹出窗口，并转向当前页(刷新)
        /// </summary>
        /// <param name="str"></param>
        public void ShowLocation(string str)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<script language=\"javascript\"> \n");
            sb.Append("alert(\"" + str.Trim() + "\"); \n");
            sb.Append("window.location.href=window.location.href;\n");
            sb.Append("</script>");
            System.Web.HttpContext.Current.Response.Write(sb.ToString());
        }
        /// <summary>
        /// 显示一个弹出窗口，并转向目标页(导航)
        /// </summary>
        /// <param name="str"></param>
        /// <param name="url"></param>
        public void ShowRedirect(string str, string url)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<script language=\"javascript\"> \n");
            sb.Append("alert(\"" + str.Trim() + "\"); \n");
            sb.Append("window.location.href=\"" + url.Trim() + "\";\n");
            sb.Append("</script>");
            System.Web.HttpContext.Current.Response.Write(sb.ToString());
        }
        /// <summary>
        /// 显示一个弹出窗口，并转向上一页
        /// </summary>
        /// <param name="str"></param>
        public void ShowPre(string str)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<script language=\"javascript\"> \n");
            sb.Append("alert(\"" + str.Trim() + "\"); \n");
            sb.Append("var p=document.referrer; \n");
            sb.Append("window.location.href=p;\n");
            sb.Append("</script>");
            System.Web.HttpContext.Current.Response.Write(sb.ToString());
        }
        /// <summary>
        /// 重定向
        /// </summary>
        /// <param name="url"></param>
        public void RedirectPage(string url)
        {
            string path = "http://" + System.Web.HttpContext.Current.Request.Url.Host + url;
            StringBuilder sb = new StringBuilder();
            sb.Append("<script language=\"javascript\"> \n");
            sb.Append(string.Format("window.location.href='{0}';", @path));
            sb.Append("</script>");
            System.Web.HttpContext.Current.Response.Write(sb.ToString());
        }

    }
} 
