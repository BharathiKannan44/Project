<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="OnlineCollgeAdmissionWeb.SignUp" %>

<asp:Content ID="cntSignUpHead" ContentPlaceHolderID="head" runat="server">
    <title>Sign Up</title>
</asp:Content>
<asp:Content ID="cntSignUp" ContentPlaceHolderID="cphMainHolder" runat="server">
    <div align="center">
        <table>
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
                    <asp:TextBox ID="txtDob" runat="server" TextMode="Date"></asp:TextBox>
                </td>
                <td>
                    <asp:CustomValidator ID="cvDob" runat="server" ControlToValidate="txtDob" OnServerValidate="CheckDob"
                        ErrorMessage="Please select your Date of Birth" Font-Italic="True" ForeColor="Red">
                    </asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td>Gender</td>
                <td>
                    <asp:DropDownList ID="lstGender" runat="server">
                        <asp:ListItem Text="Select Gender" Value="Select"></asp:ListItem>
                        <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                        <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:CustomValidator ID="cvGender" runat="server" ControlToValidate="lstGender"
                        ErrorMessage="Please select Gender" ClientValidationFunction="CheckGender" Font-Italic="True" ForeColor="Red" OnServerValidate="cvGender_ServerValidate">
                    </asp:CustomValidator>
                </td>
            </tr>

            <tr>
                <td>Email Id</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" Type="Email"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvEmailId" runat="server"
                        ErrorMessage="Name required" ControlToValidate="txtEmail" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
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
                    <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvPhoneNumber" runat="server"
                        ErrorMessage="Phone Number required" ControlToValidate="txtPhoneNumber" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                        ControlToValidate="txtPhoneNumber" ErrorMessage="Please enter valid Mobile number!"
                        ValidationExpression="^([7-9]{1})([0-9]{9})$"></asp:RegularExpressionValidator>
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
                    <asp:CompareValidator ID="cvPassword" runat="server" ErrorMessage="Both Passwords are not Equal."
                        ControlToValidate="txtConfirmPassword" ControlToCompare="txtPassword" Font-Italic="True" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>

        </table>
        <asp:Button ID="btnSignUp" runat="server" Text="Sign Up" OnClick="SignUp_Click" Style="height: 26px"></asp:Button>
    </div>
</asp:Content>
