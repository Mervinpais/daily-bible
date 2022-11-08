using System;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace Daily_Bible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            Thread.Sleep(2500);
            try
            {
                using (WebClient client = new WebClient()) // WebClient class inherits IDisposable
                {
                    client.DownloadFile("https://www.verseoftheday.com/", @"C:\Windows\Temp\bible_verse_website.html");

                    // Or you can get the file content without saving it
                    string htmlCode = client.DownloadString("https://www.verseoftheday.com/");
                    htmlCode = htmlCode.Substring(htmlCode.IndexOf("<div class=\"bilingual-left\">"));
                    htmlCode = htmlCode.Substring(0, htmlCode.IndexOf("<div class=\"end-scripture\"></div>"));
                    Debug.WriteLine(htmlCode);

                    string bible_verse = htmlCode.Substring(htmlCode.IndexOf("<div class=\"bilingual-left\">") + "<div class=\"bilingual-left\">".Length);
                    bible_verse = bible_verse.Substring(0, htmlCode.IndexOf("<div class=\"reference\">") - "<div class=\"reference\">".Length - 5);
                    Debug.WriteLine("Bible verse...");
                    Debug.WriteLine(bible_verse);

                    bible_verse_lb.Text = bible_verse;

                    string bible_verse_from = htmlCode.Substring(htmlCode.IndexOf("<a href=\"https://bible.faithlife.com/bible/niv/") + 3);
                    bible_verse_from = bible_verse_from.Substring(0, bible_verse_from.IndexOf("</a></div></div>"));
                    bible_verse_from = bible_verse_from.Substring(bible_verse_from.IndexOf(">"));
                    bible_verse_from = bible_verse_from.Substring(1);
                    Debug.WriteLine("Bible verse from...");
                    Debug.WriteLine(bible_verse_from);

                    verse_from_bible_lb.Text = bible_verse_from;
                }
            }
            catch
            {
                this.Hide();
                MessageBox.Show("Looks like you have no internet, may god bless you and take care of you");
                Environment.Exit(-1);
            }
        }

        private void ok_btn_Click(object sender, System.EventArgs e)
        {
            Environment.Exit(-1);
        }
    }
}
