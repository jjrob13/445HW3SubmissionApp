using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}