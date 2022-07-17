<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="RegisterUserV1.RegisterUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblcaptcha" runat="server" Font-Size="X-Large" Text="Enter Captcha : "></asp:Label>
            <asp:Image ID="Image1" runat="server" Height="80px" ImageUrl="~/GenCaptcha.aspx" Width="130px" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCaptcha" runat="server" Font-Size="X-Large"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CustomValidator ID="cvalcap" runat="server" ControlToValidate="txtCaptcha" ErrorMessage="Invalid Captcha" ForeColor="#CC0000" OnServerValidate="cvalreg_ServerValidate"></asp:CustomValidator>
&nbsp;
            <br />
            <br />
&nbsp;<asp:Label ID="lbldob" runat="server" Font-Size="X-Large" Text="Date of Birth"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtdob" runat="server" Font-Size="X-Large" TextMode="Date"></asp:TextBox>
            <asp:CustomValidator ID="valdob" runat="server" ControlToValidate="txtdob" ErrorMessage="Invalid Date" Font-Size="X-Large" ForeColor="#CC0000" OnServerValidate="valdob_ServerValidate"></asp:CustomValidator>
            <br />
            <br />
            <asp:Button ID="btncaptcha" runat="server" Font-Size="X-Large" Text="Register" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
        </div>
    </form>
</body>
</html>
