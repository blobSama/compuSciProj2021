<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="learnPy.aspx.cs" Inherits="compuSciProj2021.learnPy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Coding Tutorials</title>
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
        <p>Pick what you want to learn today!</p>
    </div>
    <form id="form2" runat="server">
        <div>
            <ul class="dropDowns">
                <li>
                    <asp:DropDownList CssClass="ddlAdd" ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
                    </asp:DropDownList>
                </li>
                <li>
                    <asp:DropDownList CssClass="ddlAdd" ID="DropDownList2" runat="server">
                    </asp:DropDownList>
                </li>
                <li>
                    <asp:Button runat="server" Text="Choose Class" ID="classChoose" CssClass ="ddlBttnAdd" OnClick="classChoose_Click" />
                </li>
            </ul><br /><br /><br />
            <div class="datalistDiv" runat="server">
                <div class="indatlstdiv" runat="server"><br />
                    <asp:Label ID="classText" CssClass="datalistLbl" runat="server" Text=""></asp:Label><br />
                    <asp:Label Visible="false" ID="question" CssClass="datalistLbl" runat="server" Text=""></asp:Label><br />
                    <asp:TextBox  Visible="false" ID="answer" CssClass="in2" runat="server"></asp:TextBox><br />
                    <asp:Button Visible="false" ID="checkAns" CssClass="sub1" runat="server" Text="Check Your Answer!" OnClick="checkAns_Click" /><br />
                    <asp:Label ID="rightOrWrong" CssClass="datalistLbl" runat="server" Text=""></asp:Label>
                    <br /><br />
                    <asp:Label Visible="false" ID="uploadTime" CssClass="datalistLbl" runat="server" Text="Uploaded On: "></asp:Label><br /><br />
                    <asp:Button CssClass="sub1" ID="insertClass" runat="server" Text="Insert New Classes" OnClick="insertClass_Click" />
                </div>
            </div>
        </div>
    </form>
    <footer id="foot1">
        <p>contact us - ariel.berant@gmail.com</p>
    </footer>
</body>
</html>
