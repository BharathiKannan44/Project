<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OnlineCollgeAdmissionWeb.Login" %>

<asp:Content ID="cntLoginHead" ContentPlaceHolderID="head" runat="server">
    <title>Login</title>
</asp:Content>
<asp:Content ID="cntLogin" ContentPlaceHolderID="cphMainHolder" runat="server">
     <div align = "center">
            <h1>Login</h1>
            <table>
                <tr>
                    <td>Email Id</td>
                    <td>
                        <asp:TextBox ID="txtEmailId" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>                   
                </tr>               
            </table>
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"></asp:Button>
        </div>
</asp:Content>
