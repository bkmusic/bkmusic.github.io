<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ctrlAdmin.ascx.cs" Inherits="Admin_ctrlAdmin" %>

<%@ Register src="Menu.ascx" tagname="Menu" tagprefix="uc1" %>

<style type="text/css">
    .auto-style1 {
        width: 100px;
    }
</style>

<div>Admin</div>
<table>
    <tr>
    <td class="auto-style1"><uc1:Menu ID="Menu1" runat="server" /></td>
    <td><form id="form" runat="server"><asp:PlaceHolder ID="plLoad" runat="server"></asp:PlaceHolder></form></td>
        </tr>
</table>
