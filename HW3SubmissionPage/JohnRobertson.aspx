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
    <div itemref="http://10.1.11.192:8001">
    
        <asp:Label ID="Label1" runat="server" Font-Size="20pt" Text="John Robertson CSE 445 HW3 TryIt Page 11/8/2014"></asp:Label>
        <br />
        <br />
        Please view most up-to-date version on the
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://10.1.11.192:8001">IIS Server</asp:HyperLink>
        <br />
    
    </div>
        <span class="auto-style1"><strong>Required Services</strong></span><br />
        <br />
        <strong>1. Storage Service</strong><br />
        Description: Uploads local file to remote server location.&nbsp; No external APIs used.<br />
        <br />
        Input: File location on local machine<br />
        Output: URL of uploaded file on server.<br />
        <br />
        File to upload:<br />
&nbsp;
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <asp:Button ID="fileUploadButton" runat="server" OnClick="Button1_Click" Text="Upload!" />
        <br />
        <br />
        Remote File URL:<br />
&nbsp;<asp:Label ID="StorageServiceOutputLabel" runat="server"></asp:Label>
        <br />
        -------------------------------------------------------------------------------------------<br />
        <strong>2. News Service</strong><br />
        Description: A RESTFul service that takes a keyword or phrase and returns a list of urls that contain news on that subject.&nbsp; Calls the reddit.com/r/news api and returns the first 20 results.<br />
        <br />
        Input: Keyword or phrase<br />
        Output: List of urls containing news on that topic<br />
        <br />
        Keyword:<br />
&nbsp;<asp:TextBox ID="NewServiceKeywordTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="NewsServiceSearchButton" runat="server" OnClick="NewsServiceSearchButtonClick" Text="Search!" />
        <br />
        <br />
        News URLs:<br />
        <asp:ListBox ID="NewsServiceResultListBox" runat="server" Height="126px" Width="598px"></asp:ListBox>
        <br />
        <br />
        -------------------------------------------------------------------------------------------<br />
        <span class="auto-style1"><strong>Elective Services</strong></span><br />
        <br />
        <strong>3. Stock Data Point Service</strong><br />
        Description: Takes a stock ticker and returns stock data points for that ticker.&nbsp; Uses the quandl.com stock data api and parses the response (which is a .csv file).&nbsp; Also utilizes a local cache so that not all request need to call the external api, improving performance.<br />
        <br />
        Input: Stock Ticker (eg. TSLA)<br />
        Output: List of stock prices with their corresponding date<br />
        <br />
        Stock Ticker:<br />
        <asp:TextBox ID="StockDataPointsStockTickerTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="StockDataPointsEnterButton" runat="server" OnClick="StockDataPointsEnterButtonClick" Text="Enter!" />
        <br />
        <br />
        Data Points:<br />
        <asp:ListBox ID="DataPointsResultListBox" runat="server" Width="295px"></asp:ListBox>
        <br />
        -------------------------------------------------------------------------------------------<br />
        <br />
        <strong>4. Stock Chart Service</strong><br />
        Description: Takes a company name and returns a chart of that company&#39;s stock performance.&nbsp; Uses the graphx open source chart api, the stock data points service described above and group member Ryan Prinsen&#39;s stock ticker from company name service.&nbsp; Similar to the DataPoints service above, this service also utilizes a memory cache so that not all requests need to hit the external services.<br />
        <br />
        Input: Company name (eg. Tesla, Microsoft, Google)<br />
        Output: URL of chart depicting the company&#39;s stock performance<br />
        <br />
        Company Name:<br />
        <asp:TextBox ID="StockChartCompanyNameTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="StockChartServiceEnterButton" runat="server" OnClick="StockChartEnterButtonClick" Text="Enter!" />
        <br />
        <br />
        StockChart:<br />
        <asp:Image ID="StockChartImage" runat="server" />
        <br />
        <br />
        ImageURL:
        <br />
        <asp:Label ID="StockChartImageUrlLabel" runat="server"></asp:Label>
        <br />
        -------------------------------------------------------------------------------------------<br />
        <br />
        <strong>5. Stock Description Service</strong><br />
        Description: Takes a company name and returns a description of the company&#39;s stock performance in english.&nbsp; Uses the StockDataPoints Service defined above and Ryan Prinsen&#39;s GetStockTicker service.&nbsp; Again, this sevice implements a cache to drastically improve performance on repeat requests.<br />
        <br />
        Input: Company name (eg. Tesla, Microsoft, Google)<br />
        Output: A description of how the company&#39;s stock has been performing.<br />
        <br />
        Company Name:<br />
        <asp:TextBox ID="StockDescriptionCompanyNameTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="StockDescriptionEnterButton" runat="server" OnClick="StockDescriptionEnterButtonClick" Text="Enter!" />
        <br />
        <br />
        Stock Performance Description:<br />
        <asp:Label ID="StockPerformanceDescriptionLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
