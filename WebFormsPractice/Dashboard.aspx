<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="WebFormsPractice._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div>
            <asp:DropDownList ID="ddlEmployee" runat="server">
                <asp:ListItem Enabled="true" Text="Select Employee" Value="-1"></asp:ListItem>
            </asp:DropDownList>
        </div>
    </main>

</asp:Content>
