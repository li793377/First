<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddHost.aspx.cs" Inherits="MyBBS.HostManage.AddHost" %>

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
    <table style="width: 794px; height: 489px; background-image: url(../Images/大背景.jpg);" class="TableCss" align="center" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td colspan="1" style="font-size: 14pt; width: 233px; height: 36px">
                </td>
                <td colspan="3" style="font-size: 14pt; height: 36px;">
                    <br />
                    添加版主</td>
                <td colspan="1" style="font-size: 14pt; width: 196px; height: 36px">
                </td>
            </tr>
            <tr>
                <td style="width: 233px">
                </td>
                <td style="width: 97px">
                    版主：</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                <td>
                    <asp:Button ID="btnTest" runat="server" Text="检测版主名" CssClass="ButtonCss" OnClick="btnTest_Click" CausesValidation="False" /></td>
                <td style="width: 196px">
                </td>
            </tr>
        <tr>
            <td style="width: 233px">
            </td>
            <td style="width: 97px">
                管理版块：</td>
            <td>
                <asp:DropDownList ID="ddlModule" runat="server" Width="155px">
                </asp:DropDownList></td>
            <td>
            </td>
            <td style="width: 196px">
            </td>
        </tr>
            <tr>
                <td style="width: 233px">
                </td>
                <td style="width: 97px">
                    密码：</td>
                <td>
                    <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" Width="149px"></asp:TextBox></td>
                <td>
                </td>
                <td style="width: 196px">
                </td>
            </tr>
            <tr>
                <td style="width: 233px">
                </td>
                <td style="width: 97px">
                    确认密码：</td>
                <td>
                    <asp:TextBox ID="txtSPwd" runat="server" TextMode="Password" Width="149px"></asp:TextBox></td>
                <td>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPwd"
                        ControlToValidate="txtSPwd" ErrorMessage="密码输入不一致"></asp:CompareValidator></td>
                <td style="width: 196px">
                </td>
            </tr>
            <tr>
                <td style="width: 233px">
                </td>
                <td style="width: 97px">
                    真实姓名：</td>
                <td>
                    <asp:TextBox ID="txtTName" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvTName" runat="server" ControlToValidate="txtTName"
                        ErrorMessage="真实姓名不能为空"></asp:RequiredFieldValidator></td>
                <td style="width: 196px">
                </td>
            </tr>
            <tr>
                <td style="width: 233px">
                </td>
                <td style="width: 97px">
                    性别：</td>
                <td>
                    <asp:DropDownList ID="ddlSex" runat="server">
                        <asp:ListItem>男</asp:ListItem>
                        <asp:ListItem>女</asp:ListItem>
                    </asp:DropDownList></td>
                <td>
                </td>
                <td style="width: 196px">
                </td>
            </tr>
            <tr>
                <td style="width: 233px; height: 26px">
                </td>
                <td style="width: 97px; height: 26px;">
                    出生日期：</td>
                <td style="height: 26px">
                    <asp:TextBox ID="txtBirthday" runat="server" Width="123px"></asp:TextBox>
                    <asp:Button ID="btnSelDate" runat="server" Text="…" CssClass="ButtonCss" OnClick="btnSelDate_Click" CausesValidation="False" /></td>
                <td style="height: 26px">
                    <asp:Calendar ID="calDate" runat="server" style=" position:absolute; left: 479px; top: 208px;" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="169px" NextPrevFormat="ShortMonth" OnSelectionChanged="calDate_SelectionChanged" Visible="False" Width="249px">
                        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                        <TodayDayStyle BackColor="#999999" ForeColor="White" />
                        <DayStyle BackColor="#CCCCCC" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                        <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt"
                            ForeColor="White" Height="12pt" />
                    </asp:Calendar>
                </td>
                <td style="width: 196px; height: 26px">
                </td>
            </tr>
            <tr>
                <td style="width: 233px">
                </td>
                <td style="width: 97px;">
                    联系电话：</td>
                <td>
                    <asp:TextBox ID="txtTel" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RegularExpressionValidator ID="revTel" runat="server" ErrorMessage="*" ControlToValidate="txtTel" ValidationExpression="^(\d{3,4}-)?\d{6,8}$"></asp:RegularExpressionValidator></td>
                <td style="width: 196px">
                </td>
            </tr>
            <tr>
                <td style="width: 233px">
                </td>
                <td style="width: 97px">
                    手机：</td>
                <td>
                    <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox></td>
                <td>
                </td>
                <td style="width: 196px">
                </td>
            </tr>
            <tr>
                <td style="width: 233px">
                </td>
                <td style="width: 97px">
                    QQ号：</td>
                <td>
                    <asp:TextBox ID="txtQQ" runat="server"></asp:TextBox></td>
                <td>
                </td>
                <td style="width: 196px">
                </td>
            </tr>
            <tr>
                <td style="width: 233px">
                </td>
                <td style="width: 97px">
                    头像：</td>
                <td>
                    <asp:Image ID="imgPhoto" runat="server" />
                    <br />
                    <asp:DropDownList ID="ddlPhoto" runat="server" OnSelectedIndexChanged="ddlPhoto_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList></td>
                <td>
                </td>
                <td style="width: 196px">
                </td>
            </tr>
            <tr>
                <td style="width: 233px">
                </td>
                <td style="width: 97px">
                    Email：</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail"
                        ErrorMessage="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
                <td style="width: 196px">
                </td>
            </tr>
            <tr>
                <td style="width: 233px">
                </td>
                <td style="width: 97px">
                    家庭住址：</td>
                <td>
                    <asp:TextBox ID="txtHAddress" runat="server"></asp:TextBox></td>
                <td>
                </td>
                <td style="width: 196px">
                </td>
            </tr>
            <tr>
                <td style="width: 233px">
                </td>
                <td style="width: 97px">
                    联系地址：</td>
                <td>
                    <asp:TextBox ID="txtRAddress" runat="server"></asp:TextBox></td>
                <td>
                </td>
                <td style="width: 196px">
                </td>
            </tr>
            <tr>
                <td style="width: 233px">
                </td>
                <td style="width: 97px">
                    个人首页：</td>
                <td>
                    <asp:TextBox ID="txtIndex" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RegularExpressionValidator ID="revIndex" runat="server" ErrorMessage="*" ControlToValidate="txtIndex" ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?"></asp:RegularExpressionValidator></td>
                <td style="width: 196px">
                </td>
            </tr>
            <tr>
                <td style="width: 233px">
                </td>
                <td style="width: 97px">
                </td>
                <td colspan="2" style="text-align: left">
                    &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Button ID="btnAdd" runat="server" Text="添加" CssClass="ButtonCss" OnClick="btnAdd_Click" />
                    &nbsp; &nbsp;
                    <asp:Button ID="btnCancel" runat="server" Text="取消" CssClass="ButtonCss" OnClick="btnCancel_Click" CausesValidation="False" /></td>
                <td colspan="1" style="width: 196px; text-align: left">
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

