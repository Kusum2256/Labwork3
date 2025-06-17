<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lab3_q8.aspx.cs" Inherits="Labwork.Lab3_q8" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Registration Form</h2>

        Name:<br />
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
            ErrorMessage="Name is required" ForeColor="Red" /><br />

        Email:<br />
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />
        <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail"
            ErrorMessage="Email is required" ForeColor="Red" /><br />
        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail"
            ErrorMessage="Invalid Email format" ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$"
            ForeColor="Red" /><br />

        Password:<br />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br />
        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword"
            ErrorMessage="Password is required" ForeColor="Red" /><br />

        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" /><br /><br />

        <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label>
    </form>
</body>
</html>
