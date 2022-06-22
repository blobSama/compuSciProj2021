<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insertTests.aspx.cs" Inherits="compuSciProj2021.insertTests" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>All Tests</title>
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
        <p>Add test questions</p>
    </div>
    <form id="form1" runat="server">
        <div id="regist" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Question: "></asp:Label><br />
            <asp:TextBox ID="quest" CssClass="in" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Option 1: "></asp:Label><br />
            <asp:TextBox ID="answer1" CssClass="in" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Option 2: "></asp:Label><br />
            <asp:TextBox ID="answer2" CssClass="in" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label4" runat="server" Text="Option 3: "></asp:Label><br />
            <asp:TextBox ID="answer3" CssClass="in" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label5" runat="server" Text="Option 4: "></asp:Label><br />
            <asp:TextBox ID="answer4" CssClass="in" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label6" runat="server" Text="Right Answer(copy and paste it here): "></asp:Label><br />
            <asp:TextBox ID="rightAns" CssClass="in" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label7" runat="server" Text="Explanation: "></asp:Label><br />
            <asp:TextBox ID="expl" CssClass="in" runat="server"></asp:TextBox><br />
            <asp:Button ID="addAnother" CssClass="sub1" runat="server" Text="Add Another Question" OnClick="addAnother_Click" />
            <asp:Button ID="submit" CssClass="sub1" runat="server" Text="Submit Test and Finalize" OnClick="submit_Click" />
        </div>
    </form>
    <footer id="foot1">
		<p>contact us - ariel.berant@gmail.com</p>
    </footer>
</body>
</html>
