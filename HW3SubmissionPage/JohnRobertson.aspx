<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JohnRobertson.aspx.cs" Inherits="HW3SubmissionPage.JohnRobertson" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <span class="auto-style1"><strong>Required Services</strong></span><br />
        <br />
        <strong>1. Storage Service</strong><br />
        Description: Uploads local file to remote server location<br />
        Input: File location on local machine<br />
        Output: URL of uploaded file on server.<br />
        <br />
        File to upload:<br />
&nbsp;
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload!" />
        <br />
        <br />
        Remote File URL:<br />
&nbsp;<asp:Label ID="StorageServiceOutputLabel" runat="server"></asp:Label>
        <br />
        -------------------------------------------------------------------------------------------<br />
        <strong>2. News Service</strong><br />
        Description: Takes a keyword or phrase and returns a list of urls that contain news on that subject<br />
        Input: Keyword or phrase<br />
        Output: List of urls containing news on that topic<br />
        <br />
        Keyword:<br />
&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="Search!" />
        <br />
        <br />
        News URLs:<br />
        <asp:ListBox ID="ListBox1" runat="server" Width="295px"></asp:ListBox>
        <br />
        <br />
        Elective Services<br />
        <br />
        3. Stock Data Point Service<br />
        Description: Takes a stock ticker and returns stock data points for that ticker<br />
        Input: Stock Ticker (eg. TSLA)<br />
        Output: List of stock prices with their corresponding date<br />
        <br />
        Stock Ticker:<br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" OnClick="Button1_Click" Text="Enter!" />
        <br />
        <br />
        Data Points:<br />
        <asp:ListBox ID="ListBox2" runat="server" Width="295px"></asp:ListBox>
        <br />
        <br />
        4. Stock Chart Service<br />
        Description: Takes a company name and returns a chart of that company&#39;s stock performance<br />
        Input: Company name (eg. Tesla, Microsoft, Google)<br />
        Output: URL of chart depicting the company&#39;s stock performance<br />
        <br />
        Company Name:<br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:Button ID="Button4" runat="server" OnClick="Button1_Click" Text="Enter!" />
        <br />
        <br />
        StockChart:<br />
        <asp:Image ID="StockChartImage" runat="server" />
        <br />
        <br />
        ImageURL:
        <br />
        <asp:Label ID="Label1" runat="server" Text="StockChartImageUrlLabel"></asp:Label>
        <br />
        <br />
        5. Stock Description Service<br />
        Description: Takes a company name and returns a description of the company&#39;s stock performance in english.<br />
        Input: Company name (eg. Tesla, Microsoft, Google)<br />
        Output: A description of how the company&#39;s stock has been performing.<br />
        <br />
        Company Name:<br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:Button ID="Button5" runat="server" OnClick="Button1_Click" Text="Enter!" />
        <br />
        <br />
        Stock Performance Description:<br />
        <asp:Label ID="Label2" runat="server" Text="StockPerformanceLabel"></asp:Label>
    </form>
</body>
</html>
