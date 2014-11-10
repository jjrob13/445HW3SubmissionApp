using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HW3SubmissionPage.DataPointsService;
namespace HW3SubmissionPage
{
    public partial class JohnRobertson : System.Web.UI.Page
    {
        const string BASE_IIS_SERVER_REMOTE_URL = "http://10.1.11.192:8001";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        StorageService.StorageServiceClient storageServiceClient = new StorageService.StorageServiceClient();
        protected void Button1_Click(object sender, EventArgs e)
        {
            //user has selected a file to upload
            if (FileUpload1.HasFile)
            {
                StorageServiceOutputLabel.Text = storageServiceClient.uploadFile(FileUpload1.FileName, FileUpload1.FileContent);
            }
        }

        string NEWS_SERVICE_REST_API_LINK = BASE_IIS_SERVER_REMOTE_URL + "/NewsService/NewsService.svc/search/";
        protected void NewsServiceSearchButtonClick(object sender, EventArgs e)
        {
            //the textbox is not empty
            if (!NewServiceKeywordTextBox.Text.Equals(""))
            {
                //clear previous urls if any were there
                NewsServiceResultListBox.Items.Clear();

                //call news rest api
                string requestURL = NEWS_SERVICE_REST_API_LINK + NewServiceKeywordTextBox.Text;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestURL);
                WebResponse response = request.GetResponse();

                StreamReader responseStreamReader = new StreamReader(response.GetResponseStream());

                string urls = responseStreamReader.ReadToEnd();
                urls = urls.Trim(new Char[] { '[', ']' });
                urls = urls.Replace("\"", "");
                urls = urls.Replace("\\", "");
                string[] urlList = urls.Split(new char[]{','});

                //add each url to listview
                foreach (string urlToAdd in urlList)
                {
                    ListItem item = new ListItem();
                    item.Text = urlToAdd;
                    NewsServiceResultListBox.Items.Add(item);
                }
            }
        }


        StockDataPointsServiceClient dataPointsClient = new StockDataPointsServiceClient();
        protected void StockDataPointsEnterButtonClick(object sender, EventArgs e)
        {
            //make sure the text box is not empty
            if (!StockDataPointsStockTickerTextBox.Text.Equals(""))
            {
                try
                {
                    //clear any previous items
                    DataPointsResultListBox.Items.Clear();

                    string stockTicker = StockDataPointsStockTickerTextBox.Text;

                    StockDataPoints dataPoints = dataPointsClient.GetStockDataPoints(stockTicker);

                    //something went wrong with the api call and it returned null
                    if (dataPoints == null || dataPoints.DataPoints == null)
                        return;

                    for (int i = 0; i < dataPoints.DataPoints.Length; i++)
                    {
                        if (dataPoints.DataPoints[i] != null)
                        {
                            ListItem item = new ListItem();
                            item.Text = dataPoints.DataPoints[i].date.ToShortDateString() + " --- $" + dataPoints.DataPoints[i].price;
                            DataPointsResultListBox.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    string ERROR_MESSAGE = "Unable To Retrieve Data Points for " + StockDataPointsStockTickerTextBox.Text;
                    DataPointsResultListBox.Items.Clear();
                    DataPointsResultListBox.Items.Add(ERROR_MESSAGE);
                }
            }
        }

        string STOCK_CHART_API_URL = BASE_IIS_SERVER_REMOTE_URL + "/StockChartService/Service1.svc/getStockChart?company=";
        protected void StockChartEnterButtonClick(object sender, EventArgs e)
        {
            //input is not empty
            if (!StockChartCompanyNameTextBox.Text.Equals(""))
            {
                //clear previous image and url
                StockChartImageUrlLabel.Text = "";

                string fullApiCall = STOCK_CHART_API_URL + StockChartCompanyNameTextBox.Text;
                //call the api
                try
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(fullApiCall);
                    WebResponse response = request.GetResponse();
                    StreamReader responseReader = new StreamReader(response.GetResponseStream());

                    string chartURL = responseReader.ReadToEnd();
                    chartURL = chartURL.Trim('"');

                    StockChartImage.ImageUrl = chartURL;
                    StockChartImageUrlLabel.Text = chartURL;
                }
                catch (Exception ex)
                {
                    string ERROR_MESSAGE = "Error creating chart for company: " + StockChartCompanyNameTextBox.Text + ". Please change company name and try again.";
                    StockChartImageUrlLabel.Text = ERROR_MESSAGE;
                }
            }
        }

        //restful api 
        string STOCK_DESCRIPTION_REST_API = BASE_IIS_SERVER_REMOTE_URL + "/StockDescriptionService/Service1.svc/description?company=";
        protected void StockDescriptionEnterButtonClick(object sender, EventArgs e)
        {
            //check for non-empty input
            if (!StockDescriptionCompanyNameTextBox.Text.Equals(""))
            {
                //clear previous stock description
                StockPerformanceDescriptionLabel.Text = "";

                string fullStockDescriptionApiUrl = STOCK_DESCRIPTION_REST_API + StockDescriptionCompanyNameTextBox.Text;

                //call api
                try
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(fullStockDescriptionApiUrl);
                    WebResponse response = request.GetResponse();

                    StreamReader responseReader = new StreamReader(response.GetResponseStream());

                    string stockDescription = responseReader.ReadToEnd();
                    stockDescription = stockDescription.Trim('"');

                    StockPerformanceDescriptionLabel.Text = stockDescription;

                }
                catch (Exception ex)
                {
                    //something went wrong
                    string ERROR_MESSAGE = "Unable to get stock performance description for " + StockDescriptionCompanyNameTextBox.Text + " please try again with a different input";
                    StockPerformanceDescriptionLabel.Text = ERROR_MESSAGE;
                }
            }
        }


    }
}