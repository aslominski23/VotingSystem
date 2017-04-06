<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glos.aspx.cs" Inherits="Internet_Voting_System.Account.Glos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <p class="text-center" style="font-size: xx-large">
        Głosowanie</p>
    <br />
    <asp:CheckBoxList ID="CheckBoxList1" runat="server" DataSourceID="Glosowanie" DataTextField="Column1" DataValueField="Column1">
    </asp:CheckBoxList>
    <asp:SqlDataSource ID="Glosowanie" runat="server" ConnectionString="<%$ ConnectionStrings:VoteDBConnectionString %>" SelectCommand="select (Imie + ' ' + Nazwisko) from Kandydats"></asp:SqlDataSource>



</asp:Content>
