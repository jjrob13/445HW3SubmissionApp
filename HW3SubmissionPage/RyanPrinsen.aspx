<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RyanPrinsen.aspx.cs" MasterPageFile="~/Site.Master" Inherits="HW3SubmissionPage.RyanPrinsen" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Weather Service</h1>
        <pre style="border: 1px solid rgb(240, 240, 224); padding: 5px; margin-top: -5px; font-size: 1.2em; font-family: 'Courier New'; color: rgb(0, 0, 0); font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(229, 229, 204);">http://10.1.11.192:8001/SynonymWebService/Service1.svc?wsdl</pre>
        <p class="lead">Enter any valid zip code to get a 7 day high-temperature forecast. Will display maximum temps for each day.</p>
        <p>&nbsp;
            <asp:TextBox ID="WeatherTextBox" runat="server" BorderColor="#3333CC" BorderStyle="Double" ForeColor="#0099FF" OnTextChanged="TextBox2_TextChanged">zip code</asp:TextBox>
            <asp:Button ID="WeatherSubmit" runat="server" OnClick="WeatherSubmit_Click" Text="Submit" />
        &nbsp;&nbsp; method&nbsp; string Weather7Day(string zipcode)</p>
        <p>
            &nbsp;<asp:Label ID="WeatherLabel" runat="server" Text="Show Forecast" Visible="False" ForeColor="#0099FF"></asp:Label>
        </p>
        <h1>Natural Hazards Service </h1>
        <pre style="border: 1px solid rgb(240, 240, 224); padding: 5px; margin-top: -5px; font-size: 1.2em; font-family: 'Courier New'; color: rgb(0, 0, 0); font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(229, 229, 204);">http://10.1.11.192:8001/NaturalHazardsService/Service1.svc?wsdl</pre>
        <p class="lead">Enter both latitude and longitude to get the number of 1.0+ magnitude earthquakes nearby the location within the last month.</p>
        <p class="lead">hint: use locations that frequent earthquakes, i.e. West Coast United States, Japan, etc.</p>
        <p>
            <asp:TextBox ID="NaturalHazardsTextBox1" runat="server" ForeColor="#FF9900" Width="100px" OnTextChanged="TextBox3_TextChanged">latitude</asp:TextBox>
            <asp:TextBox ID="NaturalHazardsTextBox2" runat="server" ForeColor="#FF9900" Width="100px" OnTextChanged="TextBox4_TextChanged">longitude</asp:TextBox>
            <asp:Button ID="NaturalHazardsButton" runat="server" OnClick="NaturalHazards_Click" Text="Submit" />
        &nbsp; method double naturalHazards(double latitude, double longitude)</p>
        <p>
            <asp:Label ID="NaturalHazardsLabel" runat="server" Text="Display hazard message" Visible="False" ForeColor="#FF9900"></asp:Label>
        </p>
        <p class="lead">examples:&nbsp;&nbsp;&nbsp;&nbsp; (45.01, -120.44) Fossil, Oregon</p>
        <p class="lead">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (55.19, 159.82) Takasaki, Japan</p>
        <h1>Synonym Finder Service</h1>
        <pre style="border: 1px solid rgb(240, 240, 224); padding: 5px; margin-top: -5px; font-size: 1.2em; font-family: 'Courier New'; color: rgb(0, 0, 0); font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(229, 229, 204);">http://10.1.11.192:8001/SynonymService/Service1.svc?wsdl</pre>
        <p class="lead">Enter a keyword and part of speech (noun, verb, adj, adv) to find a random synonym.</p>
        <p class="lead">note: may sometimes return an abnormal response, just try again.</p>
        <p>
            <asp:TextBox ID="SynonymTextBox1" runat="server" ForeColor="#339933" Width="100px" OnTextChanged="TextBox3_TextChanged">keyword</asp:TextBox>
            <asp:TextBox ID="SynonymTextBox2" runat="server" ForeColor="#339933" Width="185px" OnTextChanged="TextBox4_TextChanged">noun, verb, adj, adv</asp:TextBox>
            <asp:Button ID="Button3" runat="server" OnClick="Synonym_Click" Text="Submit" />
        &nbsp; method TextMessage getSynonyms(string input, string type)</p>
        <p>
            <asp:Label ID="SynonymLabel" runat="server" Text="Display results" Visible="False" ForeColor="#339933"></asp:Label>
        </p>
        <p class="lead">examples:&nbsp;&nbsp;&nbsp;&nbsp; (average, adj) &nbsp;(badly, adv)</p>
        <h1>Stock Ticker Service</h1>
        <pre style="border: 1px solid rgb(240, 240, 224); padding: 5px; margin-top: -5px; font-size: 1.2em; font-family: 'Courier New'; color: rgb(0, 0, 0); font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(229, 229, 204);">http://10.1.11.192:8001/StockTickerService/Service1.svc?wsdl</pre>
        <p class="lead">Enter a company name to display the company's stock ticker</p>
        <p>
            <asp:TextBox ID="StockTickerTextBox" runat="server" ForeColor="#CC0066" Width="147px" OnTextChanged="TextBox3_TextChanged">Company Name</asp:TextBox>
            <asp:Button ID="StockTickerButton" runat="server" OnClick="StockTicker_Click" Text="Submit" />
        &nbsp; method string GetTicker(string CompanyName)</p>
        <p>
            <asp:Label ID="StockTickerLabel" runat="server" Text="Display results" Visible="False" ForeColor="#CC0066"></asp:Label>
        </p>
        <p class="lead">examples:&nbsp;&nbsp;&nbsp;&nbsp; Microsoft, Apple</p>
    </div>

    </asp:Content>
