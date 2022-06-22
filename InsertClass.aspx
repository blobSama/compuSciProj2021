<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertClass.aspx.cs" Inherits="compuSciProj2021.InsertClass" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Classes</title>
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
    </div>
    <form id="form1" runat="server">
        <div id="regist">
            <asp:Label ID="instruct" CssClass="cvLabel" runat="server" Text="Enter Class Text(including html styling): " AssociatedControlID="classTxt"></asp:Label>
            <asp:TextBox runat="server" ID="classTxt" TextMode="MultiLine" Rows="30" CssClass="inApply" placeholder="Enter class text"></asp:TextBox><br /><br />
            <asp:Label ID="questLbl" runat="server" Text="Enter class question here: "></asp:Label><br />
            <asp:TextBox ID="question" runat="server" CssClass="in"></asp:TextBox><br />
            <asp:Label ID="ansLbl" runat="server" Text="Enter the answer here: "></asp:Label><br />
            <asp:TextBox ID="answer" runat="server" CssClass="in"></asp:TextBox><br /><br />
            <asp:Label ID="subToplbl" runat="server" Text="Enter the Sub Topic Name here: "></asp:Label><br />
            <asp:TextBox ID="subTopName" runat="server" CssClass="in"></asp:TextBox><br /><br />
            <asp:DropDownList CssClass="ddlAdd" ID="DropDownList1" runat="server" AutoPostBack="true">
            </asp:DropDownList><br /><br />
            <asp:Button runat="server" Text="Insert Lesson" ID="addClass" CssClass ="ddlBttnAdd" OnClick="addClass_Click" />
        </div>
    </form>
    <footer id="foot1">
        <p>contact us - ariel.berant@gmail.com</p>
    </footer>
</body>
</html>
