<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="DepartmanEkle.aspx.cs" Inherits="OOPStock.DepartmanEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group">
        <div class="container">
            <asp:Label runat="server" Text="Departman Adı" Font-Bold="true" Style="margin-top:20px"></asp:Label>
            <asp:TextBox ID="txtDepartmanAd" runat="server" CssClass="form-control" Style="margin-top:20px" placeholder="Departman adını giriniz"></asp:TextBox>
            <asp:Button ID="btnKaydet" runat="server" Text="Departman Kaydet" CssClass="btn btn-success" Style="margin-top:20px" OnClick="btnKaydet_Click" />
        </div>
    </form>
</asp:Content>
