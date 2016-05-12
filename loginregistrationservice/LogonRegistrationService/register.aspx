<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Book Reviewer Registration</h1>
    <table>
        <tr>
            <td>
                Last Name
            </td>
            <td>
                <asp:TextBox ID="lastNameTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Last Name is Required" ControlToValidate="lastNameTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
             First Name   
            </td>
            <td>
                <asp:TextBox ID="firstNameTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="First Name is Required" ControlToValidate="firstNameTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
             Email   
            </td>
            <td>
                <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email must be in a valid format" ControlToValidate="emailTextBox" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Email Is Required" ControlToValidate="emailTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
             Password   
            </td>
            <td>
                <asp:TextBox ID="passwordTextBox" TextMode="Password" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Password is Required" ControlToValidate="passwordTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
            Retype Password    
            </td>
            <td>
                <asp:TextBox ID="confirmTextBox" TextMode="Password" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords Must Match" ControlToCompare="passwordTextBox" ControlToValidate="confirmTextBox"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
            </td>
            <td>
                <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
