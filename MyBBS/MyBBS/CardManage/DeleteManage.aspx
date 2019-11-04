<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteManage.aspx.cs" Inherits="MyBBS.CardManage.DeleteManage" %>

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
                    帖子名称：<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    <asp:Button ID="btnFind" runat="server" CssClass="ButtonCss" OnClick="btnFind_Click"
                        Text="查找" />&nbsp;
                    <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Black" NavigateUrl="~/CardManage/DeliverCard.aspx"
                        Target="mainframe" Font-Underline="True">发表帖子</asp:HyperLink></td>
            </tr>
            <tr>
                <td style="height: 300px; vertical-align: top;"><br />
                    <br />
                    <br />
                    <asp:GridView ID="gvInfo" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                        CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="gvInfo_PageIndexChanging"
                        OnRowDeleting="gvInfo_RowDeleting" OnRowCommand="gvInfo_RowCommand" OnRowDataBound="gvInfo_RowDataBound">
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <Columns>
                            <asp:BoundField DataField="CardID" HeaderText="帖子编号" ReadOnly="True" />
                            <asp:BoundField DataField="CardName" HeaderText="帖子名称" />
                            <asp:BoundField DataField="CardTime" HeaderText="发表时间" />
                            <asp:BoundField DataField="CardPeople" HeaderText="发帖人" />
                            <asp:ButtonField CommandName="detail" HeaderText="详情" Text="详情" />
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

