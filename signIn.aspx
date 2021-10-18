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
        <ul>
            <li><a class="bttn1" href="Homepage.aspx">Home Page</a></li>
            <li><a class="bttn1" href="signIn.aspx">Sign In</a></li>
            <li><a class="bttn1" href="Register.aspx">Register</a></li>
            <li><a class="bttn1" href="usersData.aspx">Users Data</a></li>
            <li><a class="bttn1" href="about.aspx">About Us</a></li>
            <li><asp:HyperLink CssClass="bttn1" ID="infoUpdate" href="updateInfo.aspx" runat="server">Update User Info</asp:HyperLink></li>
            <li><asp:HyperLink CssClass="bttn1" ID="learnPython" href="learnPy.aspx" runat="server">HyperLink</asp:HyperLink></li>
            <li style="float:right"><asp:Label ID="hello" CssClass="greet" runat="server" Text=""></asp:Label></li>
        </ul>
        <br/>
    </div>
    <br />
    <div id="title">
        <p>SmartWatch Comparison</p>
    </div>
    <form id="form1" runat="server">
        <div id="registOut">
            <div id="regist">
                <div>
                    <h1>Sign In</h1><br />
                    <asp:Label ID="idLbl" runat="server" Text="Enter Id:"></asp:Label><br />
                    <asp:TextBox ID="idTxt" CssClass="in" runat="server" autofocus="autofocus"></asp:TextBox><br /><br />
                    <asp:Label ID="passLbl" runat="server" Text="Enter Password:"></asp:Label><br />
                    <asp:TextBox ID="passTxt" CssClass="in" TextMode="Password" runat="server"></asp:TextBox><br /><br />
                    <asp:Button ID="Button1" CssClass="sub1" runat="server" Text="Sign In" OnClick="Button1_Click" /><br />
                    <asp:Label ID="problemShow" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
    </form>
    <footer id="foot1">
		<p>contact us - ariel.berant@gmail.com</p>
	</footer>
</body>
</html>
