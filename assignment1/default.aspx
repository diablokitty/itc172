<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ITC 172 - Assignment 1</title>
    <link href="styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!--This is an HTML or xml comment-->
        <h1>Birthday Calculator</h1>
        <hr />
        <p>Choose your birthday: </p>
        <asp:Calendar ID="BirthdayCalendar" runat="server">

        </asp:Calendar>
        <p>
          Enter your name:  <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
        </p>
        <p><asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" /></p>
        <p><asp:Label ID="ResultLabel" runat="server" Text="" CssClass="result"></asp:Label></p>
    </div>
    </form>
</body>
</html>
