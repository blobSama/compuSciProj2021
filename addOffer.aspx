<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addOffer.aspx.cs" Inherits="compuSciProj2021.addOffer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Recruit and Get Recruited</title>
	<link rel="stylesheet" type="text/css" href="css/styleSheet.css"/>
    <script src="script/projScript.js"></script>
</head>
<body>
    <div id="header">
        <ul class="header">
            <li><a class="bttn1" href="Homepage.aspx">Home Page</a></li>
            <li><asp:HyperLink ID="AddOffer" CssClass="bttn1" runat="server" NavigateUrl="addOffer.aspx">Add Job Offer</asp:HyperLink></li>
            <li style="float:right"><asp:Label ID="hello" CssClass="greet" runat="server" Text=""></asp:Label></li>
        </ul>
        <br/>
    </div>
    <br />
    <div id="title">
        <p>Learn C#!</p>
        <p>Add job offer</p>
    </div>
    <form id="form1" runat="server">
        <div>
            <div id="registJobs">
            <asp:Label CssClass="infoText" ID="instructions" runat="server" Text="Enter the Job Information: "></asp:Label><br />
            <asp:Label ID="description" runat="server" Text="Description: "></asp:Label>
            <asp:TextBox CssClass="in" ID="jobDescript" runat="server"></asp:TextBox><br />
            <asp:Label ID="city" runat="server" Text="City of Job: "></asp:Label>
            <asp:DropDownList CssClass="ddlDtaLst" ID="DropDownList1" runat="server">
            </asp:DropDownList><br /><br />
            <asp:Button runat="server" ID="submit" CssClass="sub1" Text="Enter Job Offer" OnClick="submit_Click" />
        </div>
        </div>
    </form>
    <footer id="foot1">
		<p>contact us - ariel.berant@gmail.com</p>
    </footer>
</body>
</html>
