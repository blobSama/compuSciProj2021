<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updateInfo.aspx.cs" Inherits="compuSciProj2021.updateInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Update Your Info </title>
    <link rel="stylesheet" type="text/css" href="css/styleSheet.css" />
    <script src="script/projScript.js"></script>
</head>
<body>
    <div id="header">
        <ul class="header">
            <li><a class="bttn1" href="Homepage.aspx">Home Page</a></li>
            <li><asp:HyperLink CssClass="bttn1" ID="usrSignIn" href="signIn.aspx" runat="server">Sign In</asp:HyperLink></li>
            <li><asp:HyperLink CssClass="bttn1" ID="usrRegister" href="Register.aspx" runat="server">Register</asp:HyperLink></li>
            <li><asp:HyperLink CssClass="bttn1" ID="userData" href="usersData.aspx" runat="server">Users Data</asp:HyperLink></li>
            <li><a class="bttn1" href="about.aspx">About Us</a></li>
            <li><asp:HyperLink CssClass="bttn1" ID="infoUpdate" href="updateInfo.aspx" runat="server">Update User Info</asp:HyperLink></li>
            <li><asp:HyperLink CssClass="bttn1" ID="learnPython" href="learnPy.aspx" runat="server">Courses</asp:HyperLink></li>
            <li><asp:HyperLink CssClass="bttn1" ID="tests" href="showTests.aspx" runat="server">Available Tests</asp:HyperLink></li>
            <li><asp:HyperLink CssClass="bttn1" ID="showDonetests" href="allTests.aspx" runat="server">Completed Tests</asp:HyperLink></li>
            <li><asp:HyperLink CssClass="bttn1" ID="fnqs" NavigateUrl="faqs.aspx" runat="server">FAQ's</asp:HyperLink></li>
            <li><asp:HyperLink CssClass="bttn1" ID="findJobs" href="jobsForYou.aspx" runat="server">Find A Job!</asp:HyperLink></li>
            <li style="float:right"><asp:Label ID="hello" CssClass="greet" runat="server" Text=""></asp:Label></li>
        </ul>
        <br/>
    </div>
    <br/>
    <div id="title">
        <p>Learn C#!</p>
        <p>Update your information</p>
    </div>
    <form id="form1" runat="server">
        <div id="infUpdtOut">
            <div id="infUpdtIn">
                <h1>Update Info</h1>
                <asp:Label ID="info" runat="server" Text="Please make sure your email format is xxx@xxx.xx, your first and last names do not includes numbers, your passwords match and are between 8 to 16 characters and that your age is a number"></asp:Label>
                <br />
                <table>
                    <tr>
                        <td>First Name: </td>
                        <td><asp:Label ID="firstName" runat="server" Text=""></asp:Label></td>
                        <td><asp:TextBox CssClass="in" ID="fNameChange" runat="server"></asp:TextBox></td>      
                    </tr>
                    <tr>
                        <td>Last Name: </td>
                        <td><asp:Label ID="lastName" runat="server" Text=""></asp:Label></td>
                        <td><asp:TextBox CssClass="in" ID="lNameChange" runat="server"></asp:TextBox></td>      
                    </tr>
                    <tr>
                        <td>Mail Adress: </td>
                        <td><asp:Label ID="mail" runat="server" Text=""></asp:Label></td>
                        <td><asp:TextBox CssClass="in" ID="mailChange" runat="server"></asp:TextBox></td>      
                    </tr>
                    <tr>
                        <td><asp:Button ID="showPass" runat="server" Text="Show Password" OnClick="showPass_Click"/></td>
                        <td><asp:Label ID="password" runat="server" Text=""></asp:Label></td>
                        <td><asp:TextBox CssClass="in" ID="passwordChnge" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Confirm Password: </td>
                        <td><asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>
                        <td><asp:TextBox CssClass="in" ID="passwordVrfy" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Age:</td>
                        <td><asp:Label ID="ageShow" runat="server" Text=""></asp:Label></td>
                        <td><asp:TextBox CssClass="in" ID="ageChange" runat="server"></asp:TextBox></td>      
                    </tr>
                </table>
                <asp:Button CssClass="sub1" ID="Submit" runat="server" Text="Submit Changes" OnClick="Submit_Click"/><br />
                <asp:Label ID="csWrng" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
    <footer id="foot1">
        <p>contact us - ariel.berant@gmail.com</p>
    </footer>
</body>
</html>
