<%@ Control Language="C#" AutoEventWireup="true" CodeFile="cataBaiHat.ascx.cs" Inherits="Admin_BaiHat_cataBaiHat" %>
<div>Danh Sach Bai Hat</div>
<%--<asp:MultiView ID="mul" runat="server" ActiveViewIndex="0">
    <asp:View ID="v1" runat="server">--%>
        <div>
            <asp:Repeater ID="rptcataBaiHat" runat="server">
                <HeaderTemplate>
                    <table style="width: 100%;">
                        <tr>
                            <td style="width: 200px;">Ten Bai Hat</td>
                            <td style="width: 200px;">Ten Ca Si</td>
                            <td></td>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%#:Eval("TenBaiHat") %></td>
                        <td><%#:Eval("TenCaSi") %></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div> 
    <%--<div><asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Them Bai Hat Moi</asp:LinkButton></div>
        </asp:View>
    <asp:View ID="V2" runat="server">
        <table>
            <tr>
                <td>Ten Bai Hat</td>
                <td><asp:TextBox ID="tbTenBaiHat" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Khu Vuc</td>
                <td><asp:DropDownList ID="ddlKhuVuc" runat="server" OnSelectedIndexChanged="Seclection_Change">
                    <asp:ListItem Value="<%#:Eval("TenKhuVuc") %>"></asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            
        </table>
    </asp:View>
</asp:MultiView>--%>