using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HW3SubmissionPage.ServiceReferenceWeather;
using HW3SubmissionPage.ServiceReferenceSynonym;
using HW3SubmissionPage.ServiceReferenceStockTicker;
using HW3SubmissionPage.ServiceReferenceNaturalHazards;


namespace HW3SubmissionPage
{
    public partial class RyanPrinsen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void WeatherSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReferenceWeather.Service1Client myClient = new ServiceReferenceWeather.Service1Client();
                WeatherLabel.Text = myClient.Weather7day(WeatherTextBox.Text);
            }
            catch (Exception ex)
            {
                WeatherLabel.Text = "Error: Please try again.";
            }
            WeatherLabel.Visible = true;
        }

        protected void NaturalHazards_Click(object sender, EventArgs e)
        {
            
            try
            {
                ServiceReferenceNaturalHazards.Service1Client myClient = new ServiceReferenceNaturalHazards.Service1Client();
                NaturalHazardsLabel.Text = "Earthquake index: " + myClient.NaturalHazards(Convert.ToDouble(NaturalHazardsTextBox1.Text), Convert.ToDouble(NaturalHazardsTextBox2.Text));
            }
            catch (Exception ex)
            {
                NaturalHazardsLabel.Text = "Error: Please try again.";
            }


            NaturalHazardsLabel.Visible = true;
        }

        protected void Synonym_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReferenceSynonym.Service1Client myClient = new ServiceReferenceSynonym.Service1Client();
                SynonymLabel.Text = Convert.ToString(myClient.getSynonyms(SynonymTextBox1.Text, SynonymTextBox2.Text));
            }
            catch (Exception ex)
            {
                SynonymLabel.Text = "Error: Please try again.";
            }
            SynonymLabel.Visible = true;
        }

        protected void StockTicker_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReferenceStockTicker.Service1Client myClient = new ServiceReferenceStockTicker.Service1Client();
                StockTickerLabel.Text = myClient.GetTicker(StockTickerTextBox.Text);
            }
           catch (Exception ex)
            {
                StockTickerLabel.Text = "Error: Please try again.";
            }

            StockTickerLabel.Visible = true;
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        
       



    }
}