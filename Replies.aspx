<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Replies.aspx.cs" Inherits="compuSciProj2021.Replies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Your Replies</title>
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
        <p>See company replies</p>
    </div>
    <form id="form1" runat="server">
        <div class="datalistDiv" runat="server">
            <div class="indatlstdiv" runat="server">
                <asp:DataList ID="DataList1" runat="server">
                    <ItemTemplate>
                        <asp:Label ID="jobDescription" runat="server" Text='<%# Eval("jobDescript") %>'></asp:Label><br />
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("workplaceReply") %>'></asp:Label>
                    </ItemTemplate>
                </asp:DataList>
            </div>
        </div>
    </form>
    <footer id="foot1">
		<p>contact us - ariel.berant@gmail.com</p>
    </footer>
</body>
</html>
