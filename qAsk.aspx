<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="qAsk.aspx.cs" Inherits="compuSciProj2021.qAsk" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Ask a Question </title>
	<link rel="stylesheet" type="text/css" href="css/styleSheet.css"/>
</head>
<body>
    <div id="header">
        <ul class="header">
            <li><a class="bttn1" href="Homepage.aspx">Home Page</a></li>
            <li><asp:HyperLink CssClass="bttn1" ID="backTofaqs" NavigateUrl="faqs.aspx" runat="server">Back to Faqs</asp:HyperLink></li>
            <li style="float:right"><asp:Label ID="hello" CssClass="greet" runat="server" Text=""></asp:Label></li>
        </ul>
        <br/>
    </div>               
	<div id="title">
		<p>Learn C#!</p>
        <p>Ask any question about c#!</p>
	</div>
    <form id="form1" runat="server">
        <div id="regist">
            <asp:Label ID="qLbl" CssClass="cvLabel" runat="server" Text="Enter the question: "></asp:Label><br />
            <asp:TextBox ID="quest" runat="server" CssClass="in"></asp:TextBox><br />
            <asp:Button ID="submitQ" CssClass="sub1" runat="server" Text="Submit Question" OnClick="submitQ_Click" /><br />
        </div>
    </form>
    <footer id="foot1">
		<p>contact us - ariel.berant@gmail.com</p>
	</footer>
</body>
</html>
