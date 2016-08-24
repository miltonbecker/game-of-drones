<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Match.aspx.cs" Inherits="GameOfDrones.Match" %>

<%@ PreviousPageType VirtualPath="~/View/Start.aspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div style="width: 290px; float: left;">

            <h1>
                Round
                &nbsp;
                <asp:Label ID="RoundNumberLabel" runat="server"></asp:Label>
            </h1>
            
            <h2>
                <asp:Label ID="PlayerLabel" runat="server"></asp:Label>
            </h2>

            <p>
                Select Move:
                &nbsp;
                <asp:DropDownList ID="MovesDropDown" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Key" DataValueField="Key">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllowedMoves" TypeName="GameOfDrones.Models.Rules"></asp:ObjectDataSource>
            </p>
            
            <asp:Button ID="OkButton" runat="server" OnClick="OkButton_Click" Text="OK" />
        
        </div>
        
        <div style="width: 700px; padding-top:10px;">
         
            <h3>
                Score
            </h3>
        
            <asp:GridView ID="GridView1" runat="server" OnRowDataBound="GridView1_RowDataBound" Width="200px">
            </asp:GridView>

        </div>
    </form>
</body>
</html>
