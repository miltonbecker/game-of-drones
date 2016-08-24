<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Match.aspx.cs" Inherits="GameOfDrones.Match" %>

<%@ PreviousPageType VirtualPath="~/Start.aspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">


        <div style="width: 276px; float: left;">

            <asp:Label ID="RoundNameLabel" runat="server" Text="Round"></asp:Label>
            &nbsp;<asp:Label ID="RoundNumberLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="PlayerLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="SelectMoveLabel" runat="server" Text="Select Move:"></asp:Label>
            &nbsp;<asp:DropDownList ID="MovesDropDown" runat="server">
                <asp:ListItem>Rock</asp:ListItem>
                <asp:ListItem>Paper</asp:ListItem>
                <asp:ListItem>Scissors</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="OkButton" runat="server" OnClick="OkButton_Click" Text="OK" />
        </div>
        <div style="width: 700px">
            <asp:Label ID="ScoreLabel" runat="server" Text="Score"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" OnRowDataBound="GridView1_RowDataBound" Width="200px">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
