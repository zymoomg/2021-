<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMessage.aspx.cs" Inherits="GustBook.WEB.AddMessage" %>

<%@ Register assembly="FredCK.FCKeditorV2" namespace="FredCK.FCKeditorV2" tagprefix="FCKeditorV2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>时空留言本</title>
    <style type="text/css">
        .style1
        {
            width: 800px;
            height: 188px;
        }
        .style2
        {
            width: 139px;
        }
body  
{
    font-family: "宋体";font-size:9pt;
   
 }

        .style4
        {
            width: 800px;
            height: 270px;
            margin-bottom: 0px;
        }
        .style5
        {
            width: 138px;
        }
        .style6
        {
            width: 249px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" class="style1">
            <tr>
                <td align="right" class="style2">
                    昵称：</td>
                <td class="style6">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtName" ErrorMessage="昵称必填!"></asp:RequiredFieldValidator>
                </td>
                <td rowspan="5">
                    <asp:Image ID="Image1" runat="server" Height="95px" Width="85px" />
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    请选择头像：</td>
                <td class="style6">
                    <asp:DropDownList ID="ddllPic" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="ddllPic_SelectedIndexChanged1">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    邮箱：</td>
                <td class="style6">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    个人网站：</td>
                <td class="style6">
                    <asp:TextBox ID="txtUrl" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    QQ或MSN：</td>
                <td class="style6">
                    <asp:TextBox ID="txtQQ" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    </div>
        <table align="center" class="style4">
            <tr>
                <td align="right" class="style2">
                    &nbsp;表情：&nbsp;</td>
                <td>
                    <asp:RadioButton ID="Radio1" runat="server" Checked="True" GroupName="a1" />
                    <img  src="images/face/face1.gif"/><asp:RadioButton ID="Radio2" runat="server" 
                        GroupName="a1" />
                    <img src="images/face/face2.gif" /><asp:RadioButton ID="Radio3" runat="server" 
                        GroupName="a1" />
                    <img src="images/face/face3.gif" /><asp:RadioButton ID="Radio4" runat="server" 
                        GroupName="a1" />
                    <img src="images/face/face4.gif" /><asp:RadioButton ID="Radio5" runat="server" 
                        GroupName="a1" />
                    <img src="images/face/face5.gif" /><asp:RadioButton ID="Radio6" runat="server" 
                        GroupName="a1" />
                    <img src="images/face/face6.gif" /><asp:RadioButton ID="Radio7" runat="server" 
                        GroupName="a1" />
                    <img src="images/face/face7.gif" /><asp:RadioButton ID="Radio8" runat="server" 
                        GroupName="a1" />
                    <img src="images/face/face8.gif" /><asp:RadioButton ID="Radio9" runat="server" 
                        GroupName="a1" />
                    <img src="images/face/face9.gif" /><asp:RadioButton ID="Radio10" runat="server" 
                        GroupName="a1" />
                    <img src="images/face/face10.gif" /><br />
                    <asp:RadioButton ID="Radio11" runat="server" GroupName="a1" />
                    <img src="images/face/face11.gif" /><asp:RadioButton ID="Radio12" 
                        runat="server" GroupName="a1" />
                    <img src="images/face/face12.gif" /><asp:RadioButton ID="Radio13" 
                        runat="server" GroupName="a1" />
                    <img src="images/face/face13.gif" /><asp:RadioButton ID="Radio14" 
                        runat="server" GroupName="a1" />
                    <img src="images/face/face14.gif" /><asp:RadioButton ID="Radio15" 
                        runat="server" GroupName="a1" />
                    <img src="images/face/face15.gif" /><asp:RadioButton ID="Radio16" 
                        runat="server" GroupName="a1" />
                    <img src="images/face/face16.gif" /><asp:RadioButton ID="Radio17" 
                        runat="server" GroupName="a1" />
                    <img src="images/face/face17.gif" /><asp:RadioButton ID="Radio18" 
                        runat="server" GroupName="a1" />
                    <img src="images/face/face18.gif" /><asp:RadioButton ID="Radio19" 
                        runat="server" GroupName="a1" />
                    <img src="images/face/face19.gif" /><asp:RadioButton ID="Radio20" 
                        runat="server" GroupName="a1" />
                    <img src="images/face/face20.gif" /></td>
            </tr>
            <tr>
                <td align="right" class="style5">
                    留言内容：</td>
                <td>
                    <FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server" ToolbarSet="Basic">
                    </FCKeditorV2:FCKeditor>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td align="center">
                    <asp:Button ID="Button1" runat="server" Text="发表留言" Width="78px" 
                        onclick="Button1_Click1" />
                &nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="悄悄话" />
                </td>
            </tr>
        </table>
    
    </form>
</body>
</html>
