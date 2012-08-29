using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string[,] comments;
        string youtubeIDString;
        int count;
        public Form1()
        {
            InitializeComponent();
        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private bool checkIfUnique(string author)
        {
            for (int i = 0; i < count; i++)
            {
                if (comments[i, 1] == author)
                {
                    return false;
                }
            }
            return true;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            Boolean goOn = true;
            Boolean debug = debugInfo.Checked;
            Boolean noDoubles = doubleComment.Checked;
            count = 0;
            int page = 1;
            int totalComments = 0;
            int numberOfWinner = (int)winnerNum.Value;
            if (numberOfWinner < 1)
            {
                numberOfWinner = 1;
            }
            output.Text = "";

            while (goOn)
            {
                HtmlAgilityPack.HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = web.Load("http://www.youtube.com/all_comments?v="+youtubeIDString+";page=" + page);
                if (totalComments == 0)
                {
                    string totalCommentsString = doc.DocumentNode.SelectSingleNode("//span[@class='comments-section-stat']").InnerHtml.Replace(".", "");
                    totalComments = int.Parse(totalCommentsString.Substring(1, totalCommentsString.Length - 2));
                    if (debug) output.Text = "Total number of comments expected: " + totalComments + "\n\n\n";
                    comments = new string[totalComments, 2];
                }
                if (doc.DocumentNode.SelectSingleNode("//span[@class='comments-section-stat']") == null)
                {
                    if (debug) output.Text = output.Text + "Invalid page " + page + " stopping.";
                    goOn = false;
                    break;
                }
                foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//div[@id='comments-view']/div/ul/li"))
                {
                    if (debug) output.Text = output.Text + "\nComment no:" + count + "\n";
                    if (link.SelectSingleNode(link.XPath + "//em") != null)
                    {
                        // Comment has been marked as spam. Use other way of getting the comment.
                        HtmlNode comment = link.SelectSingleNode(link.XPath + "//div/div/div/div/p");
                        HtmlNode author = link.SelectSingleNode(link.XPath + "//a[@class='yt-uix-sessionlink yt-user-name ']");
                        if (author != null && comment != null)
                        {
                            if (!noDoubles || checkIfUnique(author.InnerHtml))
                            {
                                if (debug)
                                {
                                    output.Text = output.Text + "The comment: " + comment.InnerHtml + "\n";
                                    output.Text = output.Text + "Author: " + author.InnerHtml + "\n\n";
                                }
                                comments[count, 0] = comment.InnerHtml;
                                comments[count, 1] = author.InnerHtml;
                                count++;
                            }
                        }
                    }
                    else
                    {
                        HtmlNode comment = link.SelectSingleNode(link.XPath + "//p");
                        HtmlNode author = link.SelectSingleNode(link.XPath + "//a[@class='yt-uix-sessionlink yt-user-name ']");
                        if (author != null && comment != null)
                        {
                            if (!noDoubles || checkIfUnique(author.InnerHtml))
                            {
                                if (debug)
                                {
                                    output.Text = output.Text + "The comment: " + comment.InnerHtml + "\n";
                                    output.Text = output.Text + "Author: " + author.InnerHtml + "\n\n";
                                }
                                comments[count, 0] = comment.InnerHtml;
                                comments[count, 1] = author.InnerHtml;
                                count++;
                            }
                        }
                    }
                }
                page++;
            }
            output.Text = output.Text + "There is a total of " + count + " comments\n\n";
            int winnerCount = 0;
            Random random = new Random();
            while (numberOfWinner > winnerCount)
            {
                winnerCount++;
                int winner = random.Next(count - 1);
                output.Text = output.Text + "The winning comment number is: " + winner + "\n\n";
                output.Text = output.Text + "The winner is: " + comments[winner, 1] + "\n" + "With the comment: " + comments[winner, 0] + "\n\n\n\n";
            }
        }

        private void youtubeID_TextChanged(object sender, EventArgs e)
        {
            if (youtubeID.TextLength == 11)
            {
                goButton.Enabled = true;
                youtubeIDString = youtubeID.Text;
            }
            else
            {
                if (youtubeID.Text.Contains("watch?v="))
                {
                    int index = youtubeID.Text.IndexOf("watch?v=") + 8;
                    youtubeIDString = youtubeID.Text.Substring(index, 11);
                    goButton.Enabled = true;
                }
                else
                {
                    goButton.Enabled = false;
                    youtubeIDString = "";
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://robserob.dk");
            }
            catch { }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/user/RobinKaja?feature=YTH");
            }
            catch { }
        }
    }
}
