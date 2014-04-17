<%@ Page Title="Customer List" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Customers.aspx.cs" Inherits="About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
<h2>Customer List</h2>

<asp:Repeater ID="customerRepeater" runat="server">
    <ItemTemplate>
        CustomerID: <strong><%#Eval("CustomerID") %></strong><br />
        First Name: <strong><%#Eval("FirstName") %></strong><br />
        Last Name: <strong><%#Eval("LastName") %></strong><br />
        Street Address: <strong><%#Eval("StreetAddress") %></strong><br />
        City: <strong><%#Eval("City") %></strong><br />
        State: <strong><%#Eval("State") %></strong><br />
        Zip Code: <strong><%#Eval("ZipCode") %></strong><br />
        Home Phone: <strong><%#Eval("HomePhone") %></strong><br />
        Work Phone: <strong><%#Eval("WorkPhone") %></strong><br />
        Mobile Phone: <strong><%#Eval("MobilePhone") %></strong><br />
        Alternate Phone: <strong><%#Eval("AlternatePhone") %></strong><br />
    </ItemTemplate>

        <SeparatorTemplate>
        <hr />
        <hr />
        </SeparatorTemplate>

</asp:Repeater>

</asp:Content>
