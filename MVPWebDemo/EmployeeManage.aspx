<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeManage.aspx.cs" Inherits="MVPWebDemo.EmployeeManage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p><asp:textbox runat="server" ID="txt_cno" placeholder="请输入编号"></asp:textbox><label>教育程度：</label><asp:DropDownList ID="ddl_employeeState" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddl_employeeState_SelectedIndexChanged"></asp:DropDownList><asp:Button ID="btn_search" runat="server" Text="查询" OnClick="btn_search_Click" /></p>
        <asp:GridView ID="gv_employee" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="CNO" HeaderText="编号" />
                <asp:BoundField DataField="UserName" HeaderText="姓名" />
                <asp:BoundField DataField="Gender" HeaderText="性别"/>
                <asp:BoundField DataField="Education" HeaderText="教育"/>
                <asp:BoundField DataField="WorkAddres" HeaderText="工作地点"/>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>

