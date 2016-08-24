<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Finish.aspx.cs" Inherits="GameOfDrones.Finish" %>

<%@ PreviousPageType VirtualPath="~/Match.aspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="HeaderLabel" runat="server" Text="We have a WINNER!!"></asp:Label>
        <br />
        <br />
        <asp:Label ID="WinnerNameLabel" runat="server"></asp:Label>
&nbsp;<asp:Label ID="EmperorLabel" runat="server" Text="is the new EMPEROR!"></asp:Label>
        <br />
        <br />
        <asp:Button ID="PlayAgainButton" runat="server" Text="Play Again" OnClick="PlayAgainButton_Click" />
    
    </div>
    </form>
</body>
</html>
