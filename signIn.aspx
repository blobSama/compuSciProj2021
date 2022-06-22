<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signIn.aspx.cs" Inherits="compuSciProj2021.signIn" %>

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
        <p>Welcome back!</p>
    </div>
    <form id="form1" runat="server">
        <div id="registOut">
            <div id="regist">
                <div>
                    <div style="text-align:center"><h1>Sign In</h1></div><br />
                    <asp:Label ID="idLbl" runat="server" Text="Enter Id:"></asp:Label><br />
                    <asp:TextBox ID="idTxt" CssClass="in" runat="server" autofocus="autofocus"></asp:TextBox><br /><br />
                    <asp:Label ID="passLbl" runat="server" Text="Enter Password:"></asp:Label><br />
                    <asp:TextBox ID="passTxt" CssClass="in" TextMode="Password" runat="server"></asp:TextBox><br /><br />
                    <div style="text-align:center"><asp:Button ID="Button1" CssClass="sub1" runat="server" Text="Sign In" OnClick="Button1_Click" /></div><br />
                    <asp:Label ID="problemShow" runat="server" Text=""></asp:Label><br />&nbsp
                </div>
            </div>
        </div>
    </form>
    <footer id="foot1">
		<p>contact us - ariel.berant@gmail.com</p>
	</footer>
</body>
</html>
