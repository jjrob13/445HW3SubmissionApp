using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HW3SubmissionPage.ServiceReferenceNearByPlaces;
using HW3SubmissionPage.ServiceReferencePlacesReviewService;
using HW3SubmissionPage.ServiceReferenceIncidentService;
using HW3SubmissionPage.ServiceReferenceTwitterService;

namespace HW3SubmissionPage
{
    public partial class NitishBhatia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text.Trim() != "")
                {
                    Label1.Text = "";
                    ServiceReferencePlacesReviewService.Service1Client sc = new ServiceReferencePlacesReviewService.Service1Client();
                    HotelList[] list;
                    list = sc.GetHotelData(TextBox1.Text.Trim());
                    for (int i = 0; i < list.Count(); i++)
                    {
                        Label1.Text = Label1.Text + "<b>Name:</b> " + list[i].name + " <br /><b>Reference: </b>" + list[i].referenceId + "<br />=============================================<br />";
                    }
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please enter a place.')", true);
                }
            }
            catch (Exception ex)
            {
                Label1.Text = "No Restaurants Found! Make your own food :D";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (TextBox2.Text.Trim() != "")
                {
                    Label2.Text = "";
                    ServiceReferencePlacesReviewService.Service1Client sc = new ServiceReferencePlacesReviewService.Service1Client();
                    HotelDetails[] list1;
                    list1 = sc.GetPerHotelDetails(TextBox2.Text.Trim());
                    for (int i = 0; i < list1.Count(); i++)
                    {
                        string s;
                        string number = "";
                        string website = "";
                        if (list1[i].formatted_number != null)
                        {
                            number = list1[i].formatted_number;
                        }
                        if (list1[i].website != null)
                        {
                            website = list1[i].website;
                        }
                        s = "<b>Name:</b> " + list1[i].name +
                            " <br /><b>Phone Number: </b>" + number +
                            "<br /> <b>Website: </b>" + website + "<br /><br />";
                        for (int j = 0; j < list1[i].review.Count(); j++)
                        {
                            Review r = new Review();
                            string rate = "";
                            if (list1[i].review[j].rate != null)
                            {
                                rate = list1[i].review[j].rate;
                            }
                            s = s + "<b>Review " + j + "</b>: " + list1[i].review[j].text +
                                "<br /><b>Author</b>: " + list1[i].review[j].author_name +
                                "<br /><b>Rating</b>: " + rate +
                                "<br /><br />";
                        }
                        Label2.Text = Label2.Text + s;
                    }
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please enter a reference.')", true);
                }
            }
            catch (Exception ex)
            {
                Label2.Text = "Sorry! No Reviews Found";
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox3.Text.Trim() != "")
                {
                    Label3.Text = "";
                    ServiceReferenceIncidentService.Service1Client sc = new ServiceReferenceIncidentService.Service1Client();
                    TrafficList[] trafficlist;
                    trafficlist = sc.GetTrafficUpdates(TextBox1.Text.Trim());
                    for (int i = 0; i < trafficlist.Count(); i++)
                    {
                        Label3.Text = Label3.Text + "<b>Severity:</b> " + trafficlist[i].severity + " <br /><b>startTime: </b>" + trafficlist[i].startTime + "<br />" + "<b>EndTime: </b>" + trafficlist[i].endTime + "<br />" + "<b>Description: </b>" + trafficlist[i].shortDesc + "<br />" + trafficlist[i].fullDesc + "<br /><br />";
                    }
                }
            }
            catch (Exception ex)
            {
                Label3.Text = "No Incident in the area you provided. Isn't that good news :)";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {

                string hashtag = TextBox4.Text.ToString();
                Label4.Text = "";
                ServiceReferenceTwitterService.Service1Client sc = new ServiceReferenceTwitterService.Service1Client();
                TwitterModel[] list;
                list = sc.GetTweets(hashtag);

                for (int i = 0; i < list.Count(); i++)
                {
                    Label4.Text = Label4.Text + "<b>Tweet: </b> " + list[i].Content + " <br /><b>Name: </b>" + list[i].AuthorName + "<br /><b>Screen Name: " + list[i].screen_name + "<br /><br />";
                }
            }catch(Exception ex)
            {
                Label4.Text = "Please try again!";
            }
        }
        }
    }