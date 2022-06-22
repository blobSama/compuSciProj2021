<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="qAnswer.aspx.cs" Inherits="compuSciProj2021.qAnswer" %>

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
            <li><asp:HyperLink runat="server" CssClass="bttn1" ID="backToFaq" NavigateUrl="faqs.aspx">Back To Faqs</asp:HyperLink></li>
            <li style="float:right"><asp:Label ID="hello" CssClass="greet" runat="server" Text=""></asp:Label></li>
        </ul>
        <br/>
    </div>               
	<div id="title">
		<p>Learn C#!</p>
        <p>Anwer Questions</p>
	</div>
    <form id="form1" runat="server">
        <div id="regist" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Question: "></asp:Label>
            <asp:Label ID="question" runat="server"></asp:Label><br />
            <asp:TextBox ID="answer" CssClass="in" runat="server"></asp:TextBox>
            <asp:Button ID="submit" CssClass="sub1" runat="server" Text="Submit Answer" OnClick="submit_Click" />
        </div>
    </form>
    <footer id="foot1">
		<p>contact us - ariel.berant@gmail.com</p>
	</footer>
</body>
</html>
