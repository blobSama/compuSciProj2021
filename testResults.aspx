<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testResults.aspx.cs" Inherits="compuSciProj2021.testResults" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Test Results </title>
	<link rel="stylesheet" type="text/css" href="css/styleSheet.css"/>
    <style type="text/css">
        .auto-style1 {
            width: 107px;
        }
    </style>
</head>
<body>
    <div id="header">
        <ul>
            <!--
            <li><a class="bttn1" href="Homepage.aspx">Home Page</a></li>
            <li><a class="bttn1" href="signIn.aspx">Sign In</a></li>
            <li><a class="bttn1" href="Register.aspx">Register</a></li>
            <li><asp:HyperLink CssClass="bttn1" ID="userData" href="usersData.aspx" runat="server">Users Data</asp:HyperLink></li>
            <li><a class="bttn1" href="about.aspx">About Us</a></li>
            <li><asp:HyperLink CssClass="bttn1" ID="infoUpdate" href="updateInfo.aspx" runat="server">Update User Info</asp:HyperLink></li>
            <li><asp:HyperLink CssClass="bttn1" ID="learnPython" href="learnPy.aspx" runat="server">Courses</asp:HyperLink></li>
            <li><asp:HyperLink CssClass="bttn1" ID="tests" href="showTests.aspx" runat="server">Available Tests</asp:HyperLink></li>
            <li style="float:right"><asp:Label ID="hello" CssClass="greet" runat="server" Text=""></asp:Label></li>
        --></ul>
        <br/>
    </div>
    <br />
    <div id="title">
        <p>Learn python!</p>
    </div>
    <form id="form1" runat="server">
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <div class="answerSub">
                    <table style="width:100%;">
                        <tr>
                            <td class="auto-style1">
                                <asp:Label ID="Label4" runat="server" Text="The question was:"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="question" runat="server" Text='<%# Eval("question") %>'></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:Label ID="Label1" runat="server" Text="Your Answer:"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="ansr" runat="server" Text=""></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:Label ID="Label2" runat="server" Text="That was: "></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="rghtOrwrng" runat="server" Text=""></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="rightAns" runat="server" Text=""></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </div>
            </ItemTemplate>
        </asp:DataList>
        <asp:Button ID="Button1" CssClass="in" runat="server" Text="return to Homepage" OnClick="Button1_Click" />
    </form>
    <footer id="foot1">
		<p>contact us - ariel.berant@gmail.com</p>
    </footer>
</body>
</html>
