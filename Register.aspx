<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="compuSciProj2021.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Register </title>
    <link rel="stylesheet" type="text/css" href="css/styleSheet.css" />
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
            <li style="float:right"><asp:Label ID="hello" CssClass="greet" runat="server" Text=""></asp:Label></li>
        </ul>
        
        <br/>
    </div>
    <br />
    <div id="title">
        <p>SmartWatch Comparison</p>
    </div>
    <div id="registOut">
        <div id="regist">
            <h1> Register </h1>
            <form id="form1" runat="server">
                First Name:
                <em class="redF">*</em><br />
                <input type="text" class="in" id="fName" name="fName" required="required" autofocus="autofocus"/><br />
                <asp:Label ID="wrngName" runat="server" Text=""></asp:Label>
                <br /> Last Name:
                <em class="redF">*</em><br />
                <input type="text" class="in" id="lName" name="lName" required="required"/><br />
                <asp:Label ID="wrngFmly" runat="server" Text=""></asp:Label><br /> 
                Email Address:<em class="redF">*</em><br />
                <input type="text" class="in" id="mail" name="mail" placeholder="name@gmail.com"/><br />
                <asp:Label ID="mailWrng" runat="server" Text=""></asp:Label><br /> 
                Age:<em class="redF">*</em> <br />
                <input type="number" class="in" id="age" name="age"/><br />
                <asp:Label ID="ageWrng" runat="server" Text=""></asp:Label><br />
                Password(minimum 8 chars):
                <em class="redF">*</em><br />
                <input type="password" class="in" id="pass" name="password" title="8 to 16 characters" required ="required"/><br />
                <asp:Label ID="passWrng" runat="server" Text=""></asp:Label><br />
                Confirm Password:
                <em class="redF">*</em><br />
                <input type="password" class="in" id="passConf" name="passwordConfirm" title="8 to 16 characters" required ="required"/><br />
                <asp:Label ID="passConfWrng" runat="server" Text=""></asp:Label><br />
                <asp:Label ID="enterId" runat="server" Text="Id:"></asp:Label><em class="redF">*</em><br />
                <asp:TextBox ID="UId" CssClass="in" runat="server"></asp:TextBox><br />
                <asp:Label ID="idWrng" runat="server" Text=""></asp:Label><br />
                <input type="button" id="check" class="sub1" value="Check form" onclick="checkAll()" onchange="dis()"/>
				<input type="reset" value="Reset" class="sub1" /><br />
                <asp:Label ID="csWrong" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="checkWrng" runat="server" Text=""></asp:Label><br />
                <asp:Button ID="submit" CssClass="sub1" runat="server" Text="Submit" disabled="disabled" OnClick="submit_Click"/>
                <br />
                <small>
                    <em class="redF">*</em> indicates a required field
                </small>
            </form>
        </div>
    </div>
    <footer id="foot1">
        <p>contact us - ariel.berant@gmail.com</p>
    </footer>
</body>
</html>
