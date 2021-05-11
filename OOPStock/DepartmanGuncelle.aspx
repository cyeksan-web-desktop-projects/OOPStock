<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="DepartmanGuncelle.aspx.cs" Inherits="OOPStock.DepartmanGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group">
        <div class="container">
             <asp:Label runat="server" Text="Departman Id" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="txtDepartmanId" runat="server" CssClass="form-control" Style="margin-top:20px; margin-bottom:20px;" Enabled="false"></asp:TextBox>
            <asp:Label runat="server" Text="Departman Adı" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="txtDepartmanAd" runat="server" CssClass="form-control" Style="margin-top:20px" placeholder="Departman adını giriniz"></asp:TextBox>
            <asp:Button ID="btnGuncelle" runat="server" Text="Departman Güncelle" CssClass="btn btn-success" Style="margin-top:20px" OnClick="btnGuncelle_Click"/>
        </div>
    </form>
</asp:Content>

