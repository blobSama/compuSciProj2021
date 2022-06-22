<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="about.aspx.cs" Inherits="compuSciProj2021.about" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign In</title>
	<link rel="stylesheet" type="text/css" href="css/styleSheet.css"/>
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
    <br />
    <div id="title">
        <p>Learn C#!</p>
        <p>Our story</p>
    </div>
    <form id="form1" runat="server">
        <div id="registOut">
            <div id="regist">
                <div>
                    <div style="text-align:center"><h1>About Us</h1></div><br />
                    <p>
                        I am Ariel Berant, 17 years old from Ramat-Gan, and I really love writing code.
                    </p>
                    <p>
                        So, I tried to learn more about a computer language from a site on the internet. Sadly, the site I tried was absolutely horrible.</p>
                    <p>
                        Incidentally, we also had a computer science project at the time on any subject of our choosing.
                    </p>
                    <p>
                         The Idea of a site that teaches you a computer language popped right up, and this site was born!
                    </p>
                </div>
            </div>
        </div>
    </form>
    <footer id="foot1">
		<p>contact us - ariel.berant@gmail.com</p>
	</footer>
</body>
</html>
