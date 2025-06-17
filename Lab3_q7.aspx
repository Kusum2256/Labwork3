<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lab3_q7.aspx.cs" Inherits="Labwork.Lab3_q7" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Interest Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Simple Interest Calculator</h2>
        <div>
            Principal: <asp:TextBox ID="txtPrincipal" runat="server" /><br /><br />
            Time (Years): <asp:TextBox ID="txtTime" runat="server" /><br /><br />
            Rate (%): <asp:TextBox ID="txtRate" runat="server" /><br /><br />
            <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" /><br /><br />
            <asp:Label ID="lblResult" runat="server" ForeColor="Blue" />
        </div>
    </form>
</body>
</html>

