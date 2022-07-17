<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="MySocialNetworkingSite.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>       
    </title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style3 {
            height: 38px;
        }
        .auto-style4 {
            width: 1571px;
        }
        .auto-style5 {
            margin-left: 1px;
        }
        .auto-style6 {
            text-align: justify;
        }
        .auto-style7 {
            width: 145%;
            padding-right: var(--bs-gutter-x, 0.75rem);
            padding-left: var(--bs-gutter-x, 0.75rem);
            margin-right: auto;
            margin-left: auto;
        }
        .auto-style8 {
            width: 587px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style7">
            <div class="row">
            <table style="width:100%;">
                <tr>
                    <td colspan="2" class="auto-style6">
                        <img src="images/S31600.png" class="auto-style4" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="auto-style8">
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblun" runat="server" Font-Size="X-Large" Text="User Name :"></asp:Label>
                    </td>
                    <td class="auto-style3">&nbsp;<br />
                        <asp:TextBox ID="txtun" runat="server" CssClass="offset-sm-0" Font-Size="X-Large" Width="242px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="auto-style8">
                        <br />
                        <asp:Label ID="lblpwd" runat="server" Font-Size="X-Large" Text="Password :"></asp:Label>
                    </td>
                    <td>
                        &nbsp;<br />
                        <asp:TextBox ID="txtpwd" runat="server" CssClass="auto-style5" Font-Size="X-Large" Width="246px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="auto-style8">
                        <br />
                        <asp:Button class="btn btn-info" ID="btnsignin" runat="server" Font-Size="X-Large" Text="Sign In" Width="203px" OnClick="btnsignin_Click" />
                    </td>
                    <td>
                        &nbsp; &nbsp;<br />
                        &nbsp;
                        <asp:Button class="btn btn-info" ID="btnsignup" runat="server" Font-Size="X-Large" Text="Sign Up" Width="197px" PostBackUrl="~/RegisterUser.aspx" />
                    </td>
                </tr>
            </table>
          </div>
        </div>
    </form>
</body>
</html>
