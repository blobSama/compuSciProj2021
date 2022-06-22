<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="allTests.aspx.cs" Inherits="compuSciProj2021.allTests" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Previous tests </title>
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
            <li style="float:right"></li>
            <li style="float:right"><asp:Label ID="hello" CssClass="greet" runat="server" Text=""></asp:Label></li>
        </ul>
        <br/>
    </div>
    <br />
    <div id="title">
        <p>Learn C#!</p>
        <p>What tests have you completed?</p>
    </div>
    <form id="form1" runat="server">
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <div class ="datalistDiv">
                    <div class="indatlstdiv2" runat="server">
                        <br class="brClass"/>
                        <asp:Label ID="Label1" runat="server" Text="Test Subject: "></asp:Label><asp:Label ID="Label2" runat="server" Text='<%# Eval("subjName") %>'></asp:Label><br />
                        <asp:Label ID="Label3" runat="server" Text="Test Date: "></asp:Label><asp:Label ID="Label4" runat="server" Text='<%# (((DateTime)Eval("testTime")).Date.ToString("dd/MM/yyyy")) %>'></asp:Label><br />
                        <asp:Label ID="Label5" runat="server" Text="Test Time: "></asp:Label><asp:Label ID="Label6" runat="server" Text='<%# ((DateTime)Eval("testTime")).TimeOfDay %>'></asp:Label><br />
                        <asp:Label ID="Label7" runat="server" Text="Grade: "></asp:Label><asp:Label ID="Label8" runat="server" Text='<%# Eval("grade") %>'></asp:Label><br />
                    </div>
                </div>
            </ItemTemplate>
        </asp:DataList>
        <asp:DataList ID="DataList2" runat="server">
            <ItemTemplate>
                <div class ="datalistDiv">
                    <div class="indatlstdiv2" runat="server">
                        <br class="brClass"/>
                        <asp:Label ID="usrFNameLbl" runat="server" Text="User First Name: "></asp:Label><asp:Label ID="fName" runat="server" Text='<%# Eval("firstName") %>'></asp:Label><br />
                        <asp:Label ID="usrLNameLbl" runat="server" Text="User Last Name: "></asp:Label><asp:Label ID="lName" runat="server" Text='<%# Eval("lastName") %>'></asp:Label><br />
                        <asp:Label ID="Label1" runat="server" Text="Test Subject: "></asp:Label><asp:Label ID="Label2" runat="server" Text='<%# Eval("subjName") %>'></asp:Label><br />
                        <asp:Label ID="Label3" runat="server" Text="Test Date: "></asp:Label><asp:Label ID="Label4" runat="server" Text='<%# (((DateTime)Eval("testTime")).Date.ToString("dd/MM/yyyy")) %>'></asp:Label><br />
                        <asp:Label ID="Label5" runat="server" Text="Test Time: "></asp:Label><asp:Label ID="Label6" runat="server" Text='<%# ((DateTime)Eval("testTime")).TimeOfDay %>'></asp:Label><br />
                        <asp:Label ID="Label7" runat="server" Text="Grade: "></asp:Label><asp:Label ID="Label8" runat="server" Text='<%# Eval("grade") %>'></asp:Label><br />
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
