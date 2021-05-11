<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="SatisEkle.aspx.cs" Inherits="OOPStock.SatisEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <form runat="server" class="form-group">
        <div class="container">
            <asp:Label runat="server" Text="Ürün" Font-Bold="true"></asp:Label>
            <asp:DropDownList ID="cmbUrun" runat="server" CssClass="form-control" Style="margin-top: 20px; margin-bottom: 20px" AutoPostBack="true">
            </asp:DropDownList>
            <asp:Label runat="server" Text="Personel" Font-Bold="true"></asp:Label>
            <asp:DropDownList ID="cmbPersonel" runat="server" CssClass="form-control" Style="margin-top: 20px; margin-bottom: 20px" AutoPostBack="true">
            </asp:DropDownList>
            <asp:Label runat="server" Text="Müşteri" Font-Bold="true"></asp:Label>
            <asp:DropDownList ID="cmbMusteri" runat="server" CssClass="form-control" Style="margin-top: 20px; margin-bottom: 20px" AutoPostBack="true">
            </asp:DropDownList>
            <asp:Label runat="server" Text="Tutar" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="txtSatisTutar" runat="server" CssClass="form-control" Style="margin-top: 20px" placeholder="Satış tutarını giriniz"></asp:TextBox>
            <asp:Button ID="btnKaydet" runat="server" Text="Satış Kaydet" CssClass="btn btn-success" Style="margin-top: 20px" OnClick="btnKaydet_Click"/>
        </div>
    </form>
</asp:Content>
