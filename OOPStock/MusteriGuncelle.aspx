<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MusteriGuncelle.aspx.cs" Inherits="OOPStock.MusteriGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group">
        <div class="container">
            <asp:Label runat="server" Text="Müşteri Id" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="txtMusteriId" runat="server" CssClass="form-control" Style="margin-top: 20px; margin-bottom:20px;" Enabled="false"></asp:TextBox>
            <asp:Label runat="server" Text="Müşteri Adı" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="txtMusteriAd" runat="server" CssClass="form-control" Style="margin-top: 20px; margin-bottom:20px" placeholder="Müşteri adını giriniz"></asp:TextBox>
            <asp:Label runat="server" Text="Müşteri Soyadı" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="txtMusteriSoyad" runat="server" CssClass="form-control" Style="margin-top: 20px" placeholder="Müşteri soyadını giriniz"></asp:TextBox>
            <asp:Button ID="btnGuncelle" runat="server" Text="Müşteri Güncelle" CssClass="btn btn-success" Style="margin-top: 20px" OnClick="btnGuncelle_Click"/>
        </div>
    </form>
</asp:Content>
