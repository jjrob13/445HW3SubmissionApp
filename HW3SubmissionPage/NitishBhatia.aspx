<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NitishBhatia.aspx.cs" Inherits="HW3SubmissionPage.NitishBhatia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="color: #336699; background-color: #FFFFFF">
    <div style="font-family: &quot;Trebuchet MS&quot;, &quot;Lucida Sans Unicode&quot;, &quot;Lucida Grande&quot;, &quot;Lucida Sans&quot;, Arial, sans-serif; font-size: large; text-decoration: blink; background-color: #615263; color: #FFFFFF;">
    
        Hello people, the &quot;Get Restaurants&quot; button below will give you a list of fine restaurants in the city you type in the textbox.<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Restaurants" />
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Restaurants list coming soon..."></asp:Label>
        <p>
            &nbsp;</p>
        <p style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: large; background-color: #63576B; color: #CCFFCC;">
            The &quot;Get Reviews!&quot; button will give you reviews for a particular restaurant if you enter the reference id which you get when you search for restaurants in the above service.</p>
        <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Get Reviews!" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Reviews..."></asp:Label>
        <p>
            &nbsp;</p>
        <p style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: large; color: #CCCCFF; background-color: #705C71">
            Enter City Name in the textbox below and hit the &quot;Get Incidents!&quot; button to fetch the list of Incidents nearby. (Try entering a state name to get more incidents as there may be no reporting of incident in the city at a particular time.)</p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Get Incidents!" />
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Incident list..."></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: large; color: #CCCCFF; background-color: #50585F">
            Enter the company name or any thing in the textbox below and hit the &quot;Get Tweets!&quot; button to print the latest tweets in Twitter!</p>
        <p>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Get Tweets!" />
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
