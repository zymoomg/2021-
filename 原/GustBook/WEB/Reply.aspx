<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reply.aspx.cs" Inherits="GustBook.WEB.Reply" %>

<%@ Register assembly="FredCK.FCKeditorV2" namespace="FredCK.FCKeditorV2" tagprefix="FCKeditorV2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>猫猫留言板</title>
    <style type="text/css">
        .style1
        {
            width: 678px;
        }
        .style2
        {
            width: 103px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" class="style1">
            <tr>
                <td align="center" class="style2">
                    回复内容：</td>
                <td>
                    <FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server" ToolbarSet="Basic">
                    </FCKeditorV2:FCKeditor>
                </td>
            </tr>
            <tr>
                <td align="center" class="style2">
                    &nbsp;</td>
                <td align="center">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="发表回复" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
