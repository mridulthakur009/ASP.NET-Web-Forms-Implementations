<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertMultipleRec2.aspx.cs" Inherits="Implementations.InsertMultipleRec2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center; width:60%">
    <table width="100%">
    <tr>
    <th>Student Name</th>
    <th>Registration Number</th>
    <th>Department</th>
    <th>FatherName</th>
    </tr>
   
    <tr>
    <td><asp:TextBox ID="name1" runat="server"></asp:TextBox></td>
    <td><asp:TextBox ID="reg1" runat="server"></asp:TextBox></td>
    <td><asp:TextBox ID="dep1" runat="server"></asp:TextBox></td>
    <td><asp:TextBox ID="Fname1" runat="server"></asp:TextBox></td>
    </tr>

     <tr>
    <td><asp:TextBox ID="name2" runat="server"></asp:TextBox></td>
    <td><asp:TextBox ID="reg2" runat="server"></asp:TextBox></td>
    <td><asp:TextBox ID="dep2" runat="server"></asp:TextBox></td>
    <td><asp:TextBox ID="Fname2" runat="server"></asp:TextBox></td>
    </tr>
   
     <tr>
    <td><asp:TextBox ID="name3" runat="server"></asp:TextBox></td>
    <td><asp:TextBox ID="reg3" runat="server"></asp:TextBox></td>
    <td><asp:TextBox ID="dep3" runat="server"></asp:TextBox></td>
    <td><asp:TextBox ID="Fname3" runat="server"></asp:TextBox></td>
    </tr>
   
     <tr>
    <td><asp:TextBox ID="name4" runat="server"></asp:TextBox></td>
    <td><asp:TextBox ID="reg4" runat="server"></asp:TextBox></td>
    <td><asp:TextBox ID="dep4" runat="server"></asp:TextBox></td>
    <td><asp:TextBox ID="Fname4" runat="server"></asp:TextBox></td>
    </tr>
   
    </table>
    <br />
    <asp:Button ID="btnSubmit" runat="server" Text="SaveDetails"
            onclick="btnSubmit_Click" />
            <br />
            <asp:Label ID="lblStatus" runat="server"></asp:Label>
    </div>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </form>
</body>
</html>
