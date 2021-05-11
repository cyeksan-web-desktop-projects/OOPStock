<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunEkle.aspx.cs" Inherits="OOPStock.UrunEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group">
        <div class="container">
            <asp:Label runat="server" Text="Ürün Adı" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="txtUrunAd" runat="server" CssClass="form-control" Style="margin-top: 20px; margin-bottom: 20px" placeholder="Ürün adını giriniz"></asp:TextBox>
            <asp:Label runat="server" Text="Ürün Fiyatı" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="txtUrunFiyat" runat="server" CssClass="form-control" Style="margin-top: 20px; margin-bottom: 20px" placeholder="Ürün fiyatını giriniz"></asp:TextBox>
            <asp:Label runat="server" Text="Ürün Adedi" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="txtUrunAdet" runat="server" CssClass="form-control" Style="margin-top: 20px" placeholder="Ürün adedini giriniz"></asp:TextBox>
            <asp:Button ID="btnKaydet" runat="server" Text="Ürün Kaydet" CssClass="btn btn-success" Style="margin-top: 20px" OnClick="btnKaydet_Click" />
        </div>
    </form>
</asp:Content>
