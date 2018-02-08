<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateGroup.aspx.cs" Inherits="TefteriLoginTest.CreateGroup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button2" runat="server" Text="Select All" OnClick="Button2_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="DeSelect All" OnClick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          

            <asp:CheckBoxList ID="CheckBoxList1" runat="server" Height="61px" Width="152px" AutoPostBack="True" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
                <asp:ListItem Text="Ioannis Moscholios"  Value="1"></asp:ListItem>
                <asp:ListItem Text="Stathis Chrysikos"  Value="2"></asp:ListItem>
                <asp:ListItem Text="George Prokopakis"  Value="3"></asp:ListItem>
            </asp:CheckBoxList>

            <asp:ListBox ID="ListBox1" SelectionMode="Multiple" runat="server" Height="95px" Width="176px"></asp:ListBox>
            <asp:Label ID="Label1" Font-Bold="true" runat="server"></asp:Label>

            <br />
            <br />
           

        </div>
    </form>
</body>
</html>
