<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Satislar.aspx.cs" Inherits="OOPStock.Satislar" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container">
        <form runat="server">
            <table class="table table-hover">
                <thead>
                    <tr>
                        <th>SATIŞ ID</th>
                        <th>ÜRÜN</th>
                        <th>PERSONEL</th>
                        <th>MÜŞTERİ</th>
                        <th>TUTAR</th>
                        <th>SİL</th>
                        <th>GÜNCELLE</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("SATISID") %></td>
                                <td><%#Eval("URUN") %></td>
                                <td><%#Eval("PERSONEL") %></td>
                                <td><%#Eval("MUSTERI") %></td>
                                <td><%#Eval("TUTAR") %></td>
                                <td>
                                    <asp:Button ID="btnSil" runat="server" CssClass="btn btn-danger" Text="Sil" CommandArgument='<%#Eval("SATISID")%>' OnClick="MySilBtnHandler"></asp:Button></td>
                                <td>
                                    <asp:LinkButton ID="btnGuncelle" runat="server" CssClass="btn btn-warning" Text="Güncelle" CommandArgument='<%#Eval("SATISID")%>'  OnCommand="lnkEdit_Command" ></asp:LinkButton></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
            <a class="btn btn-primary" href="SatisEkle.aspx">Satış Ekle</a>
        </form>
    </div>
</asp:Content>
