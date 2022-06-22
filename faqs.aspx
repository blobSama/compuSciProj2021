<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="faqs.aspx.cs" Inherits="compuSciProj2021.faqs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> F A Q </title>
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
            <li style="float:right"><asp:Label ID="hello" CssClass="greet" runat="server" Text=""></asp:Label></li>
        </ul>
        <br/>
    </div>               
	<div id="title">
		<p>Learn C#!</p>
        <p>Ask and Answer Questions</p>
	</div>
    <form id="form1" runat="server">
        <div class="ask">
            <asp:Button ID="askQ" CssClass="sub1" runat="server" Text="Ask a Question" OnClick="askQ_Click" />
        </div>
        <asp:DataList ID="DataList1" runat="server" DataKeyField="questionNum" OnItemCommand="DataList1_ItemCommand">
            <ItemTemplate>
                <div class="datalistDiv" runat="server">
                    <div class="indatlstdiv" runat="server">
                        <asp:Label CssClass="datalistLbl" ID="askUsrName" runat="server" Text='<%# Eval("userIdAsk") %>'></asp:Label><br />
                        <asp:Label CssClass="datalistLbl" ID="qstn" runat="server" Text='<%# Eval("question") %>'></asp:Label><br />
                        <asp:Label CssClass="datalistLbl" ID="ansUsrName" runat="server" Text='<%# Eval("userIdAns") %>'></asp:Label><br />
                        <asp:Label CssClass="datalistLbl" ID="ans" runat="server" Text='<%# Eval("answer") %>'></asp:Label><br />
                        <asp:Button CssClass="dtaLstBttn" ID="answerQ" runat="server" Text="Answer The Question" Visible="false" CommandName="AnswerQuest" />
                    </div>
                </div>
            </ItemTemplate>
        </asp:DataList>
    </form>
    <footer id="foot1">
		<p>contact us - ariel.berant@gmail.com</p>
	</footer>
</body>
</html>
