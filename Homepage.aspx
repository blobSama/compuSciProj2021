<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="compuSciProj2020.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Homepage </title>
    <link rel="stylesheet" type="text/css" href="styleSheet.css"/>
</head>
<body>
     <div id="header">
        <ul>
            <li><a class="bttn1" href="Homepage.aspx">Home Page</a></li>
            <li><a class="bttn1" href="signIn.aspx">Sign In</a></li>
            <li><a class="bttn1" href="Register.aspx">Register</a></li>
            <li><a class="bttn1" href="usersData.aspx">Users Data</a></li>
            <li><a class="bttn1" href="about.aspx">About Us</a></li>
            <li><asp:HyperLink CssClass="bttn1" ID="infoUpdate" href="updateInfo.aspx" runat="server">Update User Info</asp:HyperLink></li>
            <li style="float:right"><asp:Label ID="hello" CssClass="greet" runat="server" Text=""></asp:Label></li>
        </ul>
        <br/>
    </div>
    <br/>
    <div id="title">
        <p>SmartWatch Comparison</p>
        <p>Welcome to our site! Roam around!</p>
    </div>
    <footer id="foot1">
        <p>contact us - ariel.berant@gmail.com</p>
    </footer>
    <div>
        <img class ="mySlides" src="Images/1.jpg" />
        <img class ="mySlides" src="Images/2.jpg" />
        <img class ="mySlides" src="Images/3.jpg" />
        <img class ="mySlides" src="Images/4.jpg" />
    </div>
    <script>
        var myIndex = 0;
        carousel();
        function carousel() {
            var i;
            var x = document.getElementsByClassName("mySlides");
            for (i = 0; i < x.length; i++) {
                x[i].style.display = "none";
            }
            myIndex++;
            if (myIndex > x.length) {
                myIndex = 1
            }
            x[myIndex - 1].style.display = "block";
            setTimeout(carousel, 3400);
        }
    </script>
</body>
</html>
