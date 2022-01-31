<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tests.aspx.cs" Inherits="compuSciProj2021.variablesTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Test </title>
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
	<div id="title">
		<p>Learn python!</p>
	</div>
    <form id="form2" runat="server">
        <div id="testOut" runat="server">
            <div id="testIn" runat="server">
                
                <asp:DataList ID="DataList1" runat="server" DataKeyField="questNum">
                    <ItemTemplate>
                        <div class="questionsDiv" runat="server">
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("question") %>'></asp:Label><br />
                            a)<asp:RadioButton ID="answer1" runat="server" GroupName="answers" Text='<%# Eval("answer1") %>' /><br />
                            b)<asp:RadioButton ID="answer2" runat="server" GroupName="answers" Text='<%# Eval("answer2") %>' /><br />
                            c)<asp:RadioButton ID="answer3" runat="server" GroupName="answers" Text='<%# Eval("answer3") %>' /><br />
                            d)<asp:RadioButton ID="answer4" runat="server" GroupName="answers" Text='<%# Eval("answer4") %>' /><br />
                            <asp:Label ID="Label2" runat="server"></asp:Label>
                        </div>
                    </ItemTemplate>
                </asp:DataList>
                
            </div>
        </div>
        <div class="answerSub"><asp:Button runat="server" CssClass="sub1" ID="SubmitAns" Text="Submit" OnClick="SubmitAns_Click" /></div>
    </form>
    <div class="behindFooter"></div>
    <footer id="foot1">
		<p>contact us - ariel.berant@gmail.com</p>
	</footer>
</body>
</html>
