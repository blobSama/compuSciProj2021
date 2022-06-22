<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="replyToApplication.aspx.cs" Inherits="compuSciProj2021.replyToApplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reply To Application</title>
	<link rel="stylesheet" type="text/css" href="css/styleSheet.css"/>
    <script src="script/projScript.js"></script>
</head>
<body>
    <div id="header">
        <ul class="header">
            <li><a class="bttn1" href="Homepage.aspx">Home Page</a></li>
            <li style="float:right"><asp:Label ID="hello" CssClass="greet" runat="server" Text=""></asp:Label></li>
        </ul>
        <br/>
    </div>
    <br />
    <div id="title">
        <p>Learn C#!</p>
        <p>Reply to applications</p>
    </div>
    <form id="form1" runat="server">
        <div id="regist" runat="server">
            <asp:Label ID="cvLabel" runat="server" CssClass="cvLabel" Text="Label" AssociatedControlID="wrplceReply">Please Enter A Reply:</asp:Label><br />
            <asp:TextBox runat="server" ID="wrplceReply" CssClass="inApply"></asp:TextBox><br />
            <asp:Label ID="Label1" runat="server" Text="Appliant Status:"></asp:Label><br />
            <asp:RadioButton GroupName="AcceptOrNot" ID="RadioButton1" runat="server" Text="Accepted" />
            <asp:RadioButton GroupName="AcceptOrNot" ID="RadioButton2" runat="server" Text="Rejected" />
            <asp:Button CssClass="sub1" ID="submit" runat="server" Text="Reply To Application" OnClick="submit_Click" /><br />
            <asp:Label ID="error" runat="server" Text=""></asp:Label>
        </div>
    </form>
    <footer id="foot1">
		<p>contact us - ariel.berant@gmail.com</p>
    </footer>
</body>
</html>
