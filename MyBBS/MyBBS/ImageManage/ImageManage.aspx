<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImageManage.aspx.cs" Inherits="MyBBS.ImageManage.ImageManage" %>

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
     <table cellSpacing="0" cellPadding="0" align="center" border="0" class="TableCss" style="background-image: url(../Images/大背景.jpg); width: 794px; height: 489px">
				<tr>
				<tr>
				   <td style="width: 794px; height: 166px;">
    				  <table cellSpacing="0" cellPadding="0" width=95% align="center" border="0">
    				    <tr>
                            <tr>
		                    <td valign=top style="width: 794px; text-align: center">
		                     <asp:FileUpload ID="imageUpload" runat="server" Font-Size="9pt" />&nbsp;
        		           
                                <asp:button id="UploadImage" Text="上传" runat="server" onclick="UploadImage_OnClick" CssClass="ButtonCss" /></td>
                        </tr>
				        <tr>
					        <td style="width: 794px"><br />
                                <asp:DataList ID="dlImage" runat="server"   RepeatDirection="Horizontal" RepeatColumns="5" OnDeleteCommand="dlImage_DeleteCommand">
                                    <ItemTemplate>
                                        <table style="width: 116px; height: 80px" class="TableCss">
                                            <tr valign =top align=left > 
                                            <td align="left" valign =top style="text-align: center" >
                                                <asp:Image ID="imgUrl" runat="server" ImageUrl='<%#DataBinder.Eval(Container.DataItem,"头像")%>'/></td>
                                                </tr>
                                            <tr>
                                            <td align="left" valign =top style="font-size: 9pt; text-align: center">
                                               <asp:Label ID="labImageName" runat="server" Font-Bold="True" Font-Names="隶书" 
                                                    Text='<%#DataBinder.Eval(Container.DataItem,"编号")%>'></asp:Label>
                                                    </td>    
                                            </tr>
                                            <tr>
                                            <td align ="left" valign =top style="height: 19px; text-align: center;" >
                                             <asp:LinkButton ID=lnkbtnDelete runat =server CommandName="delete" Font-Size="9pt">删除</asp:LinkButton>
                                            </td>
                                            </tr>
                                           
                                        </table>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:DataList></td>
				        </tr>  
			</table><br />
			<table cellpadding="0" cellspacing="0" style="width: 590px">
                        <tr>
                            <td style="font-size: 9pt; width: 780px; text-align: right; height: 14px;">
                                <asp:Label ID="Label7" runat="server" Text="当前页码为："></asp:Label>[
                                <asp:Label ID="labPage" runat="server" Text="1"></asp:Label>
                                ]
                                <asp:Label ID="Label6" runat="server" Text="总页码为："></asp:Label>
                                [
                                <asp:Label ID="labBackPage" runat="server"></asp:Label>
                                ]<asp:LinkButton ID="lnkbtnOne" runat="server" Font-Underline="False" ForeColor="Red"
                                    OnClick="lnkbtnOne_Click">第一页</asp:LinkButton>
                                <asp:LinkButton ID="lnkbtnUp" runat="server" Font-Underline="False" ForeColor="Red"
                                    OnClick="lnkbtnUp_Click">上一页</asp:LinkButton>
                                <asp:LinkButton ID="lnkbtnNext" runat="server" Font-Underline="False" ForeColor="Red"
                                    OnClick="lnkbtnNext_Click">下一页</asp:LinkButton>
                                <asp:LinkButton ID="lnkbtnBack" runat="server" Font-Underline="False" ForeColor="Red"
                                    OnClick="lnkbtnBack_Click">最后一页</asp:LinkButton>
                                &nbsp;</td>
                        </tr>
                    </table>
				    </td>
				</tr>
			</table>
    </div>
    </form>
</body>
</html>

