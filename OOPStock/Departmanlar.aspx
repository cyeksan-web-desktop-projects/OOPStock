<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Departmanlar.aspx.cs" Inherits="OOPStock.WebForm1" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container">
        <form runat="server">
            <table class="table table-hover">
                <thead>
                    <tr>
                        <th>DEPARTMAN ID</th>
                        <th>DEPARTMAN ADI</th>
                        <th>SİL</th>
                        <th>GÜNCELLE</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("DEPARTMANID") %></td>
                                <td><%# Eval("DEPARTMANAD") %></td>
                                <td>
                                    <asp:Button ID="btnSil" runat="server" CssClass="btn btn-danger" Text="Sil" CommandArgument='<%#Eval("DEPARTMANID")%>' OnClick="MySilBtnHandler"></asp:Button></td>
                                <td>
                                    <asp:LinkButton ID="btnGuncelle" runat="server" CssClass="btn btn-warning" Text="Güncelle" CommandArgument='<%#Eval("DEPARTMANID")%>'  OnCommand="lnkEdit_Command" ></asp:LinkButton></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
            <a class="btn btn-primary" href="DepartmanEkle.aspx">Departman Ekle</a>
        </form>
    </div>
</asp:Content>
