<%@ Control Language="C#" AutoEventWireup="true" CodeFile="cataCaSi.ascx.cs" Inherits="Admin_CaSi_cataCaSi" %>

<div>Danh Sach Ca Si</div>
<asp:MultiView ID="mul" runat="server" ActiveViewIndex="0">
        <asp:View ID="v1" runat="server">
<div>
    <asp:Repeater ID="rptcataCaSi" runat="server" OnItemCommand="rptcataCaSi_ItemCommand">
        <HeaderTemplate>
            <table style="width: 100%;">
                <tr>
                    <td style="width: 200px;">Ten Ca Si</td>
                    <td style="width: 100px;">Gioi Tinh</td>
                    <td style="width: 100px;">Ngay Sinh</td>
                    <td style="width: 200px;">Mo Ta</td>
                    <td style="width: 200px;">Hinh Anh</td>
                    <td></td>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><asp:LinkButton ID="LinkUpdate" runat="server" CommandName="Update" CommandArgument='<%#:Eval("MaCaSi") %>'><%#:Eval("TenCaSi") %></asp:LinkButton></td>
                <td><%#:Eval("GioiTinh") %></td>
                <td ><%#:Eval("NgaySinh").ToString().Substring(0,11) %></td>
                <td><%#:Eval("MoTa") %></td>
                <td><img style="width:200px; height:200px" src='<%#:Eval("HinhAnh") %>' /></td>
                <td><asp:LinkButton ID="LinkDelete" runat="server" CommandName="Delete" CommandArgument='<%#:Eval("MaCaSi") %>'>Delete</asp:LinkButton></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>

</div>
<div>
    <asp:LinkButton ID="LinkAdd" runat="server" OnClick="LinkAdd_Click">Them Ca Si Moi</asp:LinkButton>
</div>
</asp:View>
        <asp:View ID="V2" runat="server">
            <asp:HiddenField ID="hdCaSiID" runat="server" />
            <asp:HiddenField ID="hdInsert" runat="server" />
            <table>
                <tr>
                    <td>Ten Ca Si</td>
                    <td>
                        <asp:TextBox ID="tbTenCaSi" runat="server" TextMode="SingleLine"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Gioi Tinh</td>
                    <td>
                        <asp:DropDownList ID="ddlGioiTinh" runat="server">
                            <asp:ListItem Value="Nam"> Nam </asp:ListItem>
                            <asp:ListItem Value="Nữ"> Nữ </asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Ngay Sinh</td>
                    <td>
                        <asp:TextBox ID="tbNgaySinh" runat="server" TextMode="Date"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Mo Ta</td>
                    <td>
                        <asp:TextBox ID="tbMoTa" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Hinh Anh</td>
                    <td>
                        <asp:FileUpload id="fuHinhAnh" runat="server" />
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text="Cap Nhat" OnClick="btnSave_Click" /></td>
                </tr>

            </table>
        </asp:View>
</asp:MultiView>

