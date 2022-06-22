
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jobSignUp.aspx.cs" Inherits="compuSciProj2021.jobs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign Up For Jobs</title>
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
        <p>Sign up to apply for jobs!</p>
    </div>
    <form id="form1" runat="server">
        <div id="registJobs">
            <asp:Label CssClass="infoText" ID="instructions" runat="server" Text="Enter your information to seek for a job"></asp:Label>
            <asp:Label ID="phoneNum" runat="server" Text="Phone Number: "></asp:Label>
            <asp:TextBox CssClass="in" ID="usrPhone" runat="server"></asp:TextBox><br />
            <asp:Label ID="addrs" runat="server" Text="Street Name and Number: "></asp:Label>
            <asp:TextBox CssClass="in" ID="usrAddrs" runat="server"></asp:TextBox><br />
            <asp:Label ID="city" runat="server" Text="City: "></asp:Label>
            <asp:DropDownList CssClass="ddlDtaLst" ID="DropDownList1" runat="server">
            </asp:DropDownList><br /><br />
            <asp:Button runat="server" ID="submit" CssClass="sub1" Text="Proceed to Jobs" OnClick="submit_Click" />
        </div>
    </form>
    <footer id="foot1">
		<p>contact us - ariel.berant@gmail.com</p>
    </footer>
</body>
</html>
