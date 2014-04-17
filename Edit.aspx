<%@ Page Title="Edit Customer" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Edit.aspx.cs" Inherits="About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Edit / Delete Customer Information</h2>
    <p>
        <asp:Label ID="dbErrorLabel" ForeColor="Red" runat="server" />
        Please select a customer ID:<br />
        <asp:DropDownList ID="customerList" runat="server" />
        <asp:Button ID="selectButton" Text="Select" runat="server" 
            onclick="selectButton_Click" />
    </p>

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
    
    <p>
    <asp:Button ID="updateButton" Text="Update Customer" Width="200" Enabled="false" 
            runat="server" onclick="updateButton_Click" />
            <hr />
        <p>Click here to delete a customer:</p>
        <asp:Button ID="deleteButton" runat="server" Text="Delete Customer" 
            Enabled="False" onclick="deleteButton_Click" />
    </p>
</asp:Content>
