<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Author Sample Service</title>
</head>
<body>
    <h1>Get Books By Author</h1>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="authorDropDownList" runat="server"></asp:DropDownList>
        <asp:GridView ID="bookGridView" runat="server"></asp:GridView>
        <asp:Button ID="BookButton" runat="server" Text="Get Books" OnClick="BookButton_Click"/>
    </div>
    </form>
</body>
</html>
