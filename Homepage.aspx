<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="compuSciProj2021.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Homepage </title>
    <link rel="stylesheet" type="text/css" href="css/styleSheet.css"/>
</head>
<body>
    <div id="header">
        <ul class="header">
            <li><a class="bttn1" href="Homepage.aspx">Home Page</a></li>
            <li><a class="bttn1" href="signIn.aspx">Sign In</a></li>
            <li><a class="bttn1" href="Register.aspx">Register</a></li>
            <li><asp:HyperLink CssClass="bttn1" ID="userData" href="usersData.aspx" runat="server">Users Data</asp:HyperLink></li>
            <li><a class="bttn1" href="about.aspx">About Us</a></li>
            <li><asp:HyperLink CssClass="bttn1" ID="infoUpdate" href="updateInfo.aspx" runat="server">Update User Info</asp:HyperLink></li>
            <li><asp:HyperLink CssClass="bttn1" ID="learnPython" href="learnPy.aspx" runat="server">Courses</asp:HyperLink></li>
            <li><asp:HyperLink CssClass="bttn1" ID="tests" href="showTests.aspx" runat="server">Available Tests</asp:HyperLink></li>
            <li style="float:right"><asp:Label ID="hello" CssClass="greet" runat="server" Text=""></asp:Label></li>
        </ul>
        <br/>
    </div>
    <br/>
    <div id="title">
        <p>Learn python!</p>
        <p>Welcome to our site! Roam around!</p>
    </div>
    <footer id="foot1">
        <p>contact us - ariel.berant@gmail.com</p>
    </footer>
</body>
</html>
