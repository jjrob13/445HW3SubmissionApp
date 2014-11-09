using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HW3SubmissionPage
{
    public partial class JohnRobertson : System.Web.UI.Page
    {
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

        string NEWS_SERVICE_REST_API_LINK = "http://10.1.11.192:8001/NewsService/NewsService.svc/search/";
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
    }
}