<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Add.aspx.cs" Inherits="About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Add A New Customer</h2>

   <p>First Name: <asp:TextBox ID="FirstNameTextBox" TextMode="SingleLine" 
           runat="server"></asp:TextBox></p>

   <p>Last Name: <asp:TextBox ID="LastNameTextBox" TextMode="SingleLine" 
           runat="server"></asp:TextBox></p>

   <p>Street Address: <asp:TextBox ID="StreetTextBox" TextMode="SingleLine" 
           runat="server"></asp:TextBox></p>

   <p>City: <asp:TextBox ID="CityTextBox" TextMode="SingleLine" runat="server"></asp:TextBox></p>

   <p>State: <asp:TextBox ID="StateTextBox" TextMode="SingleLine" runat="server"></asp:TextBox></p>

   <p>Zip Code: <asp:TextBox ID="ZipCodeTextBox" TextMode="SingleLine" runat="server"></asp:TextBox></p>

   <p>Home Phone: <asp:TextBox ID="HomePhoneTextBox" TextMode="SingleLine" runat="server"></asp:TextBox></p>

   <p>Work Phone: <asp:TextBox ID="WorkPhoneTextBox" TextMode="SingleLine" runat="server"></asp:TextBox></p>

   <p>Mobile Phone: <asp:TextBox ID="MobilePhoneTextBox" TextMode="SingleLine" runat="server"></asp:TextBox></p>

   <p>Alternate Phone: <asp:TextBox ID="AltPhoneTextBox" TextMode="SingleLine" runat="server"></asp:TextBox></p>

    <asp:Button ID="Submit" runat="server" Text="Add Customer" 
        onclick="Submit_Click" />
</asp:Content>
