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
            <li style="float:right"><form id="form3" runat="server"><asp:Button CssClass="bttn3" ID="dis" runat="server" Text="Disconnect" OnClick="dis_Click" /></form></li>
            <li style="float:right"><asp:Label ID="hello" CssClass="greet" runat="server" Text=""></asp:Label></li>
        </ul>
        <br/>
    </div>
    <br/>
    <div id="title">
        <p>Learn C#!</p>
        <p>Welcome to our site! Roam around!</p>
    </div>
    <div id="form1">
        <div id="regist">
            <asp:Label CssClass="hpLabel" ID="Label1" runat="server" Text="Welcome to our site! Here you can make your first steps in c# and learn the language!"></asp:Label><br />
            <asp:Label CssClass="hpLabel" ID="Label2" runat="server" Text="Just sign up and you'll be able to take tests on the material, ask and answer community members' questions and much more! Believe us, you won't regret a single thing."></asp:Label>
        </div>
        
        <img class="mySlides" src="images/homePageImages/cSharp1.jpg" />
        <img class="mySlides" src="images/homePageImages/cSharp2.jpg" />
        <img class="mySlides" src="images/homePageImages/cSharp3.jpg" />
        <img class="mySlides" src="images/homePageImages/cSharp4.jpeg" />
    </div>
    <footer id="foot1">
        <p>contact us - ariel.berant@gmail.com</p>
    </footer>
</body>
    
<script>
    var slideIndex = 0;
    carousel();

    function carousel() {
        var i;
        var x = document.getElementsByClassName("mySlides");
        for (i = 0; i < x.length; i++) {
            x[i].style.display = "none";
        }
        slideIndex++;
        if (slideIndex > x.length) { slideIndex = 1 }
        x[slideIndex - 1].style.display = "block";
        setTimeout(carousel, 2000); // Change image every 2 seconds
    }
</script>
</html>
