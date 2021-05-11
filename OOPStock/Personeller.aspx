<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Personeller.aspx.cs" Inherits="OOPStock.Personeller" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container">
        <form runat="server">
            <table class="table table-hover">
                <thead>
                    <tr>
                        <th>PERSONEL ID</th>
                        <th>PERSONEL ADI</th>
                        <th>PERSONEL SOYADI</th>
                        <th>PERSONEL DEPARTMANI</th>
                        <th>PERSONEL MAAŞI</th>
                        <th>PERSONEL FOTOĞRAFI</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("PERSONELID") %></td>
                                <td><%#Eval("PERSONELAD") %></td>
                                <td><%#Eval("PERSONELSOYAD") %></td>
                                <td><%#Eval("PERSONELDEPARTMAN") %></td>
                                <td><%#Eval("PERSONELMAAS") %></td>
                                <td>
                                    <asp:Button ID="btnSil" runat="server" CssClass="btn btn-danger" Text="Sil" CommandArgument='<%#Eval("PERSONELID")%>' OnClick="MySilBtnHandler"></asp:Button></td>
                                <td>
                                    <asp:LinkButton ID="btnGuncelle" runat="server" CssClass="btn btn-warning" Text="Güncelle" CommandArgument='<%#Eval("PERSONELID")%>'  OnCommand="lnkEdit_Command" ></asp:LinkButton></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
            <a class="btn btn-primary" href="PersonelEkle.aspx">Personel Ekle</a>
        </form>
    </div>
</asp:Content>
