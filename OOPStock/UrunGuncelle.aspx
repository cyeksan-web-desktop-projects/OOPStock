<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunGuncelle.aspx.cs" Inherits="OOPStock.UrunGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group">
        <div class="container">
            <asp:Label runat="server" Text="Ürün Id" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="txtUrunId" runat="server" CssClass="form-control" Style="margin-top: 20px; margin-bottom: 20px;" Enabled="false"></asp:TextBox>
            <asp:Label runat="server" Text="Ürün Adı" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="txtUrunAd" runat="server" CssClass="form-control" Style="margin-top: 20px; margin-bottom: 20px" placeholder="Ürün adını giriniz"></asp:TextBox>
            <asp:Label runat="server" Text="Ürün Fiyatı" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="txtUrunFiyat" runat="server" CssClass="form-control" Style="margin-top: 20px; margin-bottom: 20px" placeholder="Ürün fiyatını giriniz"></asp:TextBox>
            <asp:Label runat="server" Text="Ürün Adedi" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="txtUrunAdet" runat="server" CssClass="form-control" Style="margin-top: 20px" placeholder="Ürün adedini giriniz"></asp:TextBox>
            <asp:Button ID="btnGuncelle" runat="server" Text="Ürün Güncelle" CssClass="btn btn-success" Style="margin-top: 20px" OnClick="btnGuncelle_Click"/>
        </div>
    </form>
</asp:Content>
