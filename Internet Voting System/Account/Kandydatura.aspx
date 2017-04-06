<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Kandydatura.aspx.cs" Inherits="Internet_Voting_System.Account.Kandydatura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p class="text-center" style="font-size: xx-large">
        Złóż swoją kandydaturę</p>
    <p>
        &nbsp;</p>
    <p>
        Imię</p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        Nazwisko</p>
    <p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        Adres e-mail (prywatny)</p>
    <p>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        Grupa Dziekańska</p>
    <p>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
    <p>
        Kierunek</p>
    <p>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </p>
    <p>
        Rok Studiów</p>
    <p>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    </p>
    <p>
        Semestr</p>
    <p>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    </p>
    <p>
        Rok Studiów</p>
    <p>
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
    </p>
    <p>
        Wydział</p>
    <p>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>WA</asp:ListItem>
            <asp:ListItem Value="WBiS">WBiŚ</asp:ListItem>
            <asp:ListItem>WBMiZ</asp:ListItem>
            <asp:ListItem>WE</asp:ListItem>
            <asp:ListItem>WEiT</asp:ListItem>
            <asp:ListItem>WFT</asp:ListItem>
            <asp:ListItem>WI</asp:ListItem>
            <asp:ListItem>WIZ</asp:ListItem>
            <asp:ListItem>WMRiT</asp:ListItem>
            <asp:ListItem>WTCh</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        Numer Indeksu</p>
    <p>
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
    </p>
    <p>
        Numer Telefonu</p>
    <p>
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text=" Oświadczam, że posiadam uprawnienia w zakresie przetwarzania danych osobowych wynikające z odpowiedniego przeszkolenia dot. ochrony danych osobowych wewnątrz Politechniki Poznańskiej." />
    </p>
    <p>
        <asp:CheckBox ID="CheckBox2" runat="server" Text="Wyrażam zgodę na przetwarzanie moich danych osobowych, zawartych w złożonym przeze mnie Kwestionariuszu Wyborczym, w celach związanych z realizacją wyborów do wskazanej Wydziałowej Rady Samorządu Studentów, a w przypadku uzyskania przeze mnie mandatu, także w celach związanych z działalnością Samorządu Studentów Politechniki Poznańskiej w kadencji 2015-2017, zgodnie z ustawą z dnia 29 sierpnia 1997r. o ochronie danych osobowych (Dz. U. z 2002r. nr 101, poz. 926 ze zm.)." />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Złóż kandydature" Width="240px" align="center" />
    </p>
</asp:Content>
