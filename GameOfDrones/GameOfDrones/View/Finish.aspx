<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Finish.aspx.cs" Inherits="GameOfDrones.Finish" %>

<%@ PreviousPageType VirtualPath="~/View/Match.aspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>
            We have a WINNER!!
        </h1>

        <h1>
            <asp:Label ID="WinnerNameLabel" runat="server"></asp:Label>
            &nbsp;is the new EMPEROR!
       </h1>
        
        <asp:Button ID="PlayAgainButton" runat="server" Text="Play Again" OnClick="PlayAgainButton_Click" />
    
    </div>
    </form>
</body>
</html>
