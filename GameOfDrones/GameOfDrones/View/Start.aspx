<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Start.aspx.cs" Inherits="GameOfDrones.Start" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        
        <h1>Enter Player's Names</h1>
       
        <p>
            Player 1
            &nbsp;
            <asp:TextBox ID="Player1TextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="Player1Validator" runat="server" ControlToValidate="Player1TextBox" ErrorMessage="Please type the Player 1 name">*</asp:RequiredFieldValidator>
        </p>

        <p>
            Player 2
            &nbsp;
            <asp:TextBox ID="Player2TextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="Player2Validator" runat="server" ControlToValidate="Player2TextBox" ErrorMessage="Please type the Player 2 name">*</asp:RequiredFieldValidator>
       </p>

        <asp:Button ID="StartButton" runat="server" Text="Start" PostBackUrl="~/View/Match.aspx" />
    
    </div>
    </form>
</body>
</html>
