<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="OOPStock.Urunler" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container">
        <form runat="server">
            <table class="table table-hover">
                <thead>
                    <tr>
                        <th>ÜRÜN ID</th>
                        <th>ÜRÜN ADI</th>
                        <th>ÜRÜN FİYATI</th>
                        <th>ÜRÜN ADEDİ</th>
                        <th>SİL</th>
                        <th>GÜNCELLE</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("URUNID") %></td>
                                <td><%#Eval("URUNAD") %></td>
                                <td><%#Eval("URUNFIYAT") %></td>
                                <td><%#Eval("URUNADET") %></td>
                                <td>
                                    <asp:Button ID="btnSil" runat="server" CssClass="btn btn-danger" Text="Sil" CommandArgument='<%#Eval("URUNID")%>' OnClick="MySilBtnHandler"></asp:Button></td>
                                <td>
                                    <asp:LinkButton ID="btnGuncelle" runat="server" CssClass="btn btn-warning" Text="Güncelle" CommandArgument='<%#Eval("URUNID")%>'  OnCommand="lnkEdit_Command" ></asp:LinkButton></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
            <a class="btn btn-primary" href="UrunEkle.aspx">Ürün Ekle</a>
        </form>
    </div>
</asp:Content>
