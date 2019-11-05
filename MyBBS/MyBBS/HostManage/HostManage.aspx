<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HostManage.aspx.cs" Inherits="MyBBS.HostManage.HostManage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>无标题页</title>
     <link href="../CSS/StyleSheet.css" rel="Stylesheet" type="text/css" />
     <style>
    body{margin-top:0px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center" style="width: 794px; height: 489px; background-image: url(../Images/大背景.jpg);" class="TableCss" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td style="height: 20px">
                    <br />
                    <br />
                    版主名称：<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    <asp:Button ID="btnFind" runat="server" CssClass="ButtonCss" OnClick="btnFind_Click"
                        Text="查找" />
                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Underline="True" ForeColor="Black"
                        NavigateUrl="~/HostManage/AddHost.aspx" Target="mainframe">添加</asp:HyperLink></td>
            </tr>
            <tr>
                <td style="height: 300px; vertical-align: top;"><br />
                    <br />
                    <br />
                    <asp:GridView ID="gvHostInfo" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                        CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="gvHostInfo_PageIndexChanging"
                        OnRowCommand="gvHostInfo_RowCommand" OnRowDataBound="gvHostInfo_RowDataBound"
                        OnRowDeleting="gvHostInfo_RowDeleting">
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <Columns>
                            <asp:BoundField DataField="版主" HeaderText="版主" />
                            <asp:BoundField HeaderText="管理版块" />
                            <asp:BoundField DataField="真实姓名" HeaderText="真实姓名" />
                            <asp:BoundField DataField="出生日期" HeaderText="出生日期" />
                            <asp:BoundField DataField="联系电话" HeaderText="联系电话" />
                            <asp:BoundField DataField="联系地址" HeaderText="联系地址" />
                            <asp:ButtonField CommandName="Update" HeaderText="详情" Text="详情" />
                            <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
                        </Columns>
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <EditRowStyle BackColor="#999999" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Right" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

