<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jobsForYou.aspx.cs" Inherits="compuSciProj2021.jobsForYou" %>

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
            <li><asp:HyperLink ID="replies" CssClass="bttn1" runat="server" NavigateUrl="Replies.aspx">Replies</asp:HyperLink></li>
            <li><asp:HyperLink ID="addOffer" CssClass="bttn1" runat="server" NavigateUrl="addOffer.aspx">Add Job Offer</asp:HyperLink></li>
            <li style="float:right"><asp:Label ID="hello" CssClass="greet" runat="server" Text=""></asp:Label></li>
        </ul>
        <br/>
    </div>
    <br />
    <div id="title">
        <p>Learn C#!</p>
        <p>What awaits us today on our job hunt?</p>
    </div>
    <form id="form1" runat="server">
        <div>
            <ul runat="server" id="ddlList" class="dropDowns">
                <li><asp:DropDownList CssClass="ddlAdd" ID="DropDownList1" runat="server"></asp:DropDownList></li>
                <li><asp:DropDownList CssClass="ddlAdd" ID="DropDownList2" runat="server">
                    <asp:ListItem Value="1">Today</asp:ListItem>
                    <asp:ListItem Value="2">This Month</asp:ListItem>
                    <asp:ListItem Value="3" Text="">This Year</asp:ListItem>
                    </asp:DropDownList></li>
                <li><asp:Button CssClass="ddlBttnAdd" ID="sort" runat="server" Text="Sort" OnClick="sort_Click" /></li>
                
            </ul><br />
            <asp:DataList ID="DataList1" DataKeyField="offerNumber" runat="server" OnItemCommand="DataList1_ItemCommand">
                <ItemTemplate>
                    <div class="datalistDiv" runat="server">
                        <div class="indatlstdiv" runat="server">
                            <asp:Label CssClass="datalistLbl" ID="usrId" runat="server" Text='<%# Eval("applyingUserId") %>'></asp:Label><br />
                            <asp:Label CssClass="datalistLbl" ID="Cv" runat="server" Text='<%# Eval("cv") %>'></asp:Label><br />
                            <asp:Label CssClass="datalistLbl" ID="JobDscrpt" runat="server" Text='<%# Eval("jobDescript") %>'></asp:Label><br />
                            <asp:Button CssClass="dtaLstBttn" ID="reply" runat="server" Text="Write A Reply" CommandName="applicationReply" />
                            <br />
                        </div>
                    </div>
                </ItemTemplate>
            </asp:DataList>
            <asp:DataList ID="DataList2" DataKeyField="offerNumber" runat="server" OnItemCommand="DataList2_ItemCommand">
                <ItemTemplate>
                    <div class="datalistDiv" runat="server">
                        <div class="indatlstdiv" runat="server">
                            <asp:Label ID="WorkplaceName" CssClass="datalistLbl" runat="server" Text='<%# Eval("companyName") %>'></asp:Label><br />
                            <asp:Label ID="JobDescript" CssClass="datalistLbl" runat="server" Text='<%# Eval("jobDescript") %>'></asp:Label><br />
                            <asp:Label ID="JobCity" CssClass="datalistLbl" runat="server" Text='<%# Eval("cityName") %>'></asp:Label><br />
                            <asp:Label ID="UploadDate" CssClass="datalistLbl" runat="server" Text='<%# Eval("dateOfUpload") %>'></asp:Label><br />
                            <asp:Button CssClass="dtaLstBttn" ID="apply" runat="server" Text="Apply" CommandName="applyForJob"/>
                            <br />
                        </div>
                    </div>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
    <footer id="foot1">
		<p>contact us - ariel.berant@gmail.com</p>
    </footer>
</body>
</html>
