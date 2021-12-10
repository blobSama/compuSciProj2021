<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showTests.aspx.cs" Inherits="compuSciProj2021.showTests" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>All Tests</title>
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
            <li><asp:HyperLink CssClass="bttn1" ID="learnPython" href="learnPy.aspx" runat="server">Courses</asp:HyperLink></li>
            <li><asp:HyperLink CssClass="bttn1" ID="tests" href="showTests.aspx" runat="server">Available Tests</asp:HyperLink></li>
            <li style="float:right"><asp:Label ID="hello" CssClass="greet" runat="server" Text=""></asp:Label></li>
        </ul>
        <br/>
    </div>
    <br />
    <div id="title">
        <p>Learn python!</p>
    </div>
    <form id="form1" runat="server">
        <div>
            <ul>
                <li><asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Choose Difficulty:</asp:ListItem>
                        <asp:ListItem>Hard</asp:ListItem>
                        <asp:ListItem>Medium</asp:ListItem>
                        <asp:ListItem>Easy</asp:ListItem>
                    </asp:DropDownList></li>
                <li><asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem>Choose Time of Upload:</asp:ListItem>
                        <asp:ListItem>This Year</asp:ListItem>
                        <asp:ListItem>This Month</asp:ListItem>
                        <asp:ListItem>Today</asp:ListItem>
                    </asp:DropDownList></li>
                <li><asp:Button runat="server" ID="sort" CssClass ="bttn1" OnClick="sort_Click" /></li>
            </ul>
            <asp:DataList ID="DataList1" runat="server" DataKeyField="testNum" OnItemCommand="DataList1_ItemCommand" RepeatColumns="5">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("subjName") %>'></asp:Label>
                    <br></br>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("difficulty") %>'></asp:Label>
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="Go to " CommandName="goToTest"/>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
    <footer id="foot1">
		<p>contact us - ariel.berant@gmail.com</p>
    </footer>
</body>
</html>
