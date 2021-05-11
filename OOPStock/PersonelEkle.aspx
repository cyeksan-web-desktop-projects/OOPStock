<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="PersonelEkle.aspx.cs" Inherits="OOPStock.PersonelEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group">
        <div class="container">
            <asp:Label runat="server" Text="Personel Adı" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="txtPersonelAd" runat="server" CssClass="form-control" Style="margin-top: 20px; margin-bottom: 20px" placeholder="Personel adını giriniz"></asp:TextBox>
            <asp:Label runat="server" Text="Personel Soyadı" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="txtPersonelSoyad" runat="server" CssClass="form-control" Style="margin-top: 20px; margin-bottom: 20px" placeholder="Personel soyadını giriniz"></asp:TextBox>
            <asp:Label runat="server" Text="Personel Departmanı" Font-Bold="true"></asp:Label>
            <asp:DropDownList ID="cmbPersonelDepartman" runat="server" CssClass="form-control" Style="margin-top: 20px; margin-bottom: 20px" AutoPostBack="true">
            </asp:DropDownList>
            <asp:Label runat="server" Text="Personel Maaşı" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="txtPersonelMaas" runat="server" CssClass="form-control" Style="margin-top: 20px" placeholder="Personel maaşını giriniz"></asp:TextBox>
            <asp:Button ID="btnKaydet" runat="server" Text="Personel Kaydet" CssClass="btn btn-success" Style="margin-top: 20px" OnClick="btnKaydet_Click" />
        </div>
    </form>
</asp:Content>
