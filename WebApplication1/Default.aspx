<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     
    <div>
        <asp:Label ID="Label4" runat="server" Text="Id : "></asp:Label>
                <asp:TextBox ID="textbox4" runat="server"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="First_Name : "></asp:Label>
                <asp:TextBox ID="textbox1" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Last_Name : "></asp:Label>
                <asp:TextBox ID="textbox2" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Mobile_No :"></asp:Label>
                <asp:TextBox ID="textbox3" runat="server"></asp:TextBox>

            <asp:Button ID="btnsave" runat="server" Text="Submit" OnClick="btnsave_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
        
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
       
    </div>
</asp:Content>
