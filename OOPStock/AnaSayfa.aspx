<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AnaSayfa.aspx.cs" Inherits="OOPStock.AnaSayfa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!-- Page Content-->
    <div class="container">
        <!-- Jumbotron Header-->
        <header class="jumbotron my-4">
            <h1 class="display-3">Hoşgeldin!</h1>
            <p class="lead">Stok kayıtlarının tutulduğu OOPStock uygulamasına hoşgeldin!</p>
            <a class="btn btn-primary btn-lg" href="Urunler.aspx">Ürünleri Gör</a>
        </header>
        <!-- Footer-->
        <footer class="py-5 bg-dark">
            <div class="container">
                <p class="m-0 text-center text-white">Copyright © OOPStock 2021</p>
            </div>
        </footer>
        <!-- Bootstrap core JS-->
        <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.bundle.min.js"></script>
        <!-- Core theme JS-->
        <script src="js/scripts.js"></script>
    </div>
</asp:Content>

