<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="OnlineCollgeAdmissionWeb.SignUp" %>

<asp:Content ID="cntSignUpHead" ContentPlaceHolderID="head" runat="server">
    <title>Sign Up</title>
</asp:Content>
<asp:Content ID="cntSignUp" ContentPlaceHolderID="cphMainHolder" runat="server">
    <div align="center">
        <table >
            <h2>Sign Up</h2>
            <tr>
                <td>First Name</td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvName" runat="server"
                        ErrorMessage="Name required" ControlToValidate="txtFirstName" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Last Name</td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Date of birth</td>
                <td>
                    <asp:TextBox ID="txtDob" runat="server" Type="date"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Gender</td>
                <td>
                    <asp:DropDownList ID="lstGender" runat="server">
                        <asp:ListItem Text="Select Gender" Value="Select"></asp:ListItem>
                        <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                        <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                        <asp:ListItem Text="Others" Value="Others"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>

            <tr>
                <td>Email Id</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" Type="Email"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="revEmail" runat="server"
                        ErrorMessage="Incorrect Email Id" ControlToValidate="txtEmail" Font-Italic="True" ForeColor="Red"
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Font-Bold="False"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Phone Number</td>
                <td>
                    <asp:TextBox ID="txtPhoneNumber" runat="server" Type="Number"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvPhoneNumber" runat="server"
                        ErrorMessage="Phone Number required" ControlToValidate="txtPhoneNumber" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Confirm Password</td>
                <td>
                    <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="cvPassword" runat="server" ErrorMessage="Both Password are not Equal."
                        ControlToValidate="txtConfirmPassword" ControlToCompare="txtPassword" Font-Italic="True" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>

        </table>
        <asp:Button ID="btnSignUp" runat="server" Text="Sign Up" OnClick="SignUp_Click" Style="height: 26px"></asp:Button>
    </div>
</asp:Content>
