 using Lab7Task3.TweetService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7Task3
{
    public partial class _Default : Page
    {
        TweetService.TweetServiceSoapClient client = new TweetService.TweetServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = client.GetLast100Tweets();
                GridView1.DataBind();
            }
        }

        protected void btnTweet_Click(object sender, EventArgs e)
        {
            Tweet tweet = new Tweet();
            tweet.Username = "thac0006";
            tweet.DatePosted = DateTime.Now;
            tweet.Entry = TextBox1.Text;

            client.PostTweet(tweet);

            GridView1.DataSource = client.GetLast100Tweets();
            GridView1.DataBind();
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Label1.Text = "Panel refreshed at: " + DateTime.Now.ToLongTimeString();
            GridView1.DataSource = client.GetLast100Tweets();
            GridView1.DataBind();
        }
    }
}