<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="usersData.aspx.cs" Inherits="compuSciProj2021.usersData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> All Users </title>
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
            <li style="float:right"><asp:Label ID="hello" CssClass="greet" runat="server" Text=""></asp:Label></li>
        </ul>
        <br/>
    </div>               
	<div id="title">
		<p>Learn C#!</p>
        <p>Change user's data</p>
	</div>
	<div class="wtchData">
		<form class="wtchData" id="form1" runat="server">
			<!--<asp:TextBox ID="idNum" CssClass="in" runat="server"></asp:TextBox><br />
            <asp:Button ID="del" CssClass="sub1" runat="server" Text="Logically delete" OnClick="del_Click" /><br />
            <asp:Label ID="IDWrng" runat="server" Text=""></asp:Label><br />-->
            <div class="wtchData" >
                <asp:GridView ID="GridView1" CssClass="gridData" runat="server" AutoGenerateColumns="False" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdating="GridView1_RowUpdating">
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="User ID" ReadOnly="true" />
                        <asp:BoundField DataField="firstName" HeaderText="User First Name" />
                        <asp:BoundField DataField="lastName" HeaderText="User Last Name" />
                        <asp:BoundField DataField="mailAdrs" HeaderText="User Mail Adress" />
                        <asp:BoundField DataField="age" HeaderText="User Age" />
                        <asp:BoundField DataField="password" HeaderText="User Password" />
                        <asp:BoundField DataField="isActive" HeaderText="Active User" />
                        <asp:BoundField DataField="isManager" HeaderText="Is A Manager" SortExpression="isManager" />
                        <asp:BoundField DataField="currTop" HeaderText="Latest Subject" SortExpression="currTop" />
                        <asp:BoundField DataField="currSubTop" HeaderText="Latest Sub Topic" SortExpression="currSubTop" />
                        <asp:TemplateField>  
                            <ItemTemplate>  
                                <asp:Button ID="btn_Edit" CssClass="bttn2" runat="server" Text="Edit" CommandName="Edit" />  
                            </ItemTemplate>  
                            <EditItemTemplate>  
                                <asp:Button ID="btn_Update" CssClass="bttn2" runat="server" Text="Update" CommandName="Update"/>  
                                <asp:Button ID="btn_Cancel" CssClass="bttn2" runat="server" Text="Cancel" CommandName="Cancel"/>  
                            </EditItemTemplate>  
                        </asp:TemplateField>  
                    </Columns>
                </asp:GridView>
			</div>
		</form>
	</div>
    
	<footer id="foot1">
		<p>contact us - ariel.berant@gmail.com</p>
	</footer>
</body>
</html>
