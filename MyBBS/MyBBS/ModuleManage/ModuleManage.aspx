<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModuleManage.aspx.cs" Inherits="MyBBS.ModuleManage.ModuleManage" %>

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
                    版块名称：<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    <asp:Button ID="btnFind" runat="server" CssClass="ButtonCss" OnClick="btnFind_Click"
                        Text="查找" />&nbsp;
                    <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Black" NavigateUrl="~/ModuleManage/AddModule.aspx"
                        Target="mainframe" Font-Underline="True">添加</asp:HyperLink></td>
            </tr>
            <tr>
                <td style="height: 300px; vertical-align: top;"><br />
                    <br />
                    <asp:GridView ID="gvInfo" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                        CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="gvInfo_PageIndexChanging"
                        OnRowDeleting="gvInfo_RowDeleting" OnRowCancelingEdit="gvInfo_RowCancelingEdit" OnRowEditing="gvInfo_RowEditing" OnRowUpdating="gvInfo_RowUpdating" Font-Size="9pt">
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <Columns>
                            <asp:BoundField DataField="版块编号" HeaderText="版块编号" ReadOnly="True" />
                            <asp:BoundField DataField="版块名称" HeaderText="版块名称" />
                            <asp:HyperLinkField DataNavigateUrlFields="版块编号" DataNavigateUrlFormatString="../CardManage/Card.aspx?ModuleID={0}"
                                HeaderText="详情" Text="详情">
                                <ControlStyle ForeColor="Black" />
                            </asp:HyperLinkField>
                            <asp:CommandField HeaderText="编辑" ShowEditButton="True" />
                            <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
                        </Columns>
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" HorizontalAlign="Center" />
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

