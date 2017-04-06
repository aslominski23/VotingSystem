<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Internet_Voting_System.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Ask us a queston !</h3>
    <address>
        Jana Pawła II 28/6<br />
        Poznań, 61-139<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Official Student's Goverment e-mail address:</strong>   <a href="mailto:samorzad@put.poznan.pl">Support@example.com</a><br />
        <strong>Official e-mail address to the Electoral Commission</strong> <a href="mailto:komisja.wyborcza@samorzad.put.poznan.pl">Marketing@example.com</a>
    </address>
</asp:Content>
