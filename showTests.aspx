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
    <br />
    <div id="title">
        <p>Learn C#!</p>
        <p>What tests will we do today?</p>
    </div>
    <form id="form1" runat="server">
        <div>
            <ul class="dropDowns">
                <li><asp:DropDownList CssClass="ddlAdd" ID="DropDownList1" runat="server">
                        <asp:ListItem>Choose Difficulty:</asp:ListItem>
                        <asp:ListItem>Hard</asp:ListItem>
                        <asp:ListItem>Medium</asp:ListItem>
                        <asp:ListItem>Easy</asp:ListItem>
                    </asp:DropDownList></li>
                <li><asp:DropDownList CssClass="ddlAdd" ID="DropDownList2" runat="server">
                        <asp:ListItem>Choose Time of Upload:</asp:ListItem>
                        <asp:ListItem>This Year</asp:ListItem>
                        <asp:ListItem>This Month</asp:ListItem>
                        <asp:ListItem>Today</asp:ListItem>
                    </asp:DropDownList></li>
                <li><asp:DropDownList CssClass="ddlAdd" ID="DropDownList3" runat="server">
                    </asp:DropDownList></li>
                <li><asp:Button runat="server" Text="Sort" ID="sort" CssClass ="ddlBttnAdd" OnClick="sort_Click" /></li>
            </ul>
            <asp:DropDownList CssClass="ddlDtaLst" ID="DropDownList4" runat="server"></asp:DropDownList><br />
            <asp:Button CssClass="sub1" ID="addTest" runat="server" Text="Add New Test" OnClick="addTest_Click" />
            <asp:DataList ID="DataList1" runat="server" DataKeyField="testNum" OnItemCommand="DataList1_ItemCommand" RepeatColumns="5">
                <ItemTemplate>
                    <div class="datalistDiv" runat="server">
                        <div class="indatlstdiv" runat="server">
                            <br class="brClass"/>
                            <asp:Label CssClass="datalistLbl" ID="Label1" runat="server" Text='<%# Eval("subjName") %>'></asp:Label><br /><br />
                            <asp:Label ID="Label2" runat="server" CssClass="datalistLbl" Text='<%# Eval("difficulty") %>'></asp:Label><br /><br />
                            <asp:Label ID="Label3" runat="server" CssClass="datalistLbl" Text='<%# Eval("descript") %>'></asp:Label><br /><br />
                            <br />
                            <asp:Button ID="Button2" runat="server" CommandName="goToTest" CssClass="dtaLstBttn" Text="Go to " /><asp:Image ID="passed" runat="server" ImageUrl="~/images/hook-g8d63f63f2_640.png" CssClass="passImg" visible='<%# Eval("hasPassed") %>'/>
                            <br />
                        </div>
                    </div>
                </ItemTemplate>
            </asp:DataList>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdating="GridView1_RowUpdating">
                <Columns>
                    <asp:BoundField DataField="testNum" HeaderText="Test Identifier" ReadOnly="true" />
                    <asp:BoundField DataField="uploadDate" HeaderText="Test Upload Date" SortExpression="uploadDate" />
                    <asp:BoundField DataField="isActiveTest" HeaderText="Test Active" SortExpression="isActiveTest" />
                    <asp:BoundField DataField="subjName" HeaderText="Test Subject" SortExpression="subjName" />
                    <asp:BoundField DataField="difficulty" HeaderText="Test Difficulty" SortExpression="difficulty" />
                    <asp:BoundField DataField="descript" HeaderText="Test Description" SortExpression="descript" />
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
            <asp:Label ID="valdWrng" runat="server" Text=""></asp:Label>
        </div>
    </form>
    <footer id="foot1">
		<p>contact us - ariel.berant@gmail.com</p>
    </footer>
</body>
</html>
