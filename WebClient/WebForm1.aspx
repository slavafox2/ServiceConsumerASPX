<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:DropDownList runat="server" ID="DropDownList1" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Selected="True" Value="%">Filter by:</asp:ListItem>
        </asp:DropDownList>

        <br />
        <br />

        <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="false" AllowSorting="true"
             PageSize="4" AllowPaging="true"
            OnSorting="GridView_Sorting1"   CustomSortDirection="ASC"   OnPageIndexChanging="GridView1_PageIndexChanging" CellPadding="2" Height="16px">
             
            <Columns>
                <asp:BoundField HeaderText="First Name" DataField="First_name"  />
                <asp:BoundField HeaderText="Salary" DataField="Salary" SortExpression="Salary" />            
            </Columns>
       
        </asp:GridView>

    </form>

</body>
</html>

