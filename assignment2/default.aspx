<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="ClassicADO.css" rel="stylesheet" type="text/css" />
    <title>Find a New Book</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Book Club</h1>
        <p>Select an author from the list to see the books available for that author:</p>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
        
    </form>
</body>
</html>
