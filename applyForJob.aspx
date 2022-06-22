<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="applyForJob.aspx.cs" Inherits="compuSciProj2021.applyForJob" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Job Application</title>
	<link rel="stylesheet" type="text/css" href="css/styleSheet.css"/>
    <script src="script/projScript.js"></script>
</head>
<body>
    <div id="header">
        <ul class="header">
            <li><a class="bttn1" href="Homepage.aspx">Home Page</a></li>
            <li><asp:HyperLink ID="replies" CssClass="bttn1" runat="server" NavigateUrl="Replies.aspx">Replies</asp:HyperLink></li>
            <li style="float:right"><asp:Label ID="hello" CssClass="greet" runat="server" Text=""></asp:Label></li>
        </ul>
        <br/>
    </div>
    <br />
    <div id="title">
        <p>Learn C#!</p>
        <p>Apply for your dream job!</p>
    </div>
    <form id="form1" runat="server">
        <div id="regist" runat="server">
            <asp:Label ID="cvLabel" runat="server" CssClass="cvLabel" Text="Label" AssociatedControlID="usrCv">Please Enter Your CV:</asp:Label><br />
            <asp:TextBox runat="server" ID="usrCv" TextMode="MultiLine" Rows="30" CssClass="inApply" placeholder="Enter CV here"></asp:TextBox><br />
            <asp:Button CssClass="sub1" ID="submit" runat="server" Text="Submit CV" OnClick="submit_Click" /><br />
        </div>
    </form>
    <footer id="foot1">
		<p>contact us - ariel.berant@gmail.com</p>
    </footer>
</body>
</html>
