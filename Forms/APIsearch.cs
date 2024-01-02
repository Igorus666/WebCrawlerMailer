using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using HtmlAgilityPack;
using Newtonsoft.Json.Linq;
using PuppeteerSharp;


namespace Igorus_Email_Bot.Forms
{
    public partial class APIsearch : Form
    {
        private string language;
        private string country;
        public List<string> Emails = new List<string>();
        private int currentProgress = 0;
        public APIsearch()
        {
            InitializeComponent();

            Lang.Items.Add("English");
            Lang.Items.Add("Portuguese");
            Lang.Items.Add("Spanish");

            Log.Items.Add("Ready to start search");
            Log.TopIndex = Log.Items.Count - 1;

            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Step = 1;
        }

        async private void SearchButton_Click(object sender, EventArgs e)
        {
            string selectedValue = Lang.SelectedItem as string;

            if (selectedValue != null && SearchText.Text.Length != 0)
            {
                switch (selectedValue)
                {
                    case "English":
                        language = "lr=lang_en";
                        country = "GB";
                        break;

                    case "Portuguese":
                        language = "lr=lang_pt";
                        country = "BR";
                        break;

                    case "Spanish":
                        language = "lr=lang_es";
                        country = "ES";
                        break;

                }

                await GoogleAPI();
                CleanList();
                Log.Items.Add("Search Ended!");
                Log.Items.Add($"{Emails.Count} Results Found");
                Log.TopIndex = Log.Items.Count - 1;
                progressBar.Value = 100;
                MessageBox.Show($" Search Ended!\n{Emails.Count} new Adresses found", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Export.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Enter a search language and querry", "ATENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        async Task GoogleAPI()
        {
            try
            {
                string apiKey = Properties.Settings.Default.APIkey;
                string cxId = Properties.Settings.Default.CXid;
                string query = SearchText.Text;
                int resultsPerPage = Properties.Settings.Default.ResultPerPages;
                int pages = Properties.Settings.Default.Pages;

                await SearchGoogle(query, apiKey, cxId, resultsPerPage, pages, country, language);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in the API: \n\n" + ex, "ATENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        async Task SearchGoogle(string query, string apiKey, string cxId, int resultsPerPage, int numberOfPages, string country, string language)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                Log.Items.Add("Initializing Google API");
                Log.TopIndex = Log.Items.Count - 1;

                for (int page = 0; page < numberOfPages; page++)
                {
                    Log.Items.Add("Starting New Querry");
                    Log.TopIndex = Log.Items.Count - 1;

                    int startIndex = page * resultsPerPage + 1;

                    string encodedQuery = System.Web.HttpUtility.UrlEncode(query);
                    string apiUrl = $"https://www.googleapis.com/customsearch/v1?q={encodedQuery}&key={apiKey}&cx={cxId}&start={startIndex}&cr={country}&{language}&num={resultsPerPage}";

                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        JObject data = JObject.Parse(json);

                        JArray items = (JArray)data["items"];
                        if (items != null)
                        {
                            foreach (JToken item in items)
                            {
                                string link = item["link"]?.ToString();
                                string title = item["title"]?.ToString();

                                Log.Items.Add($"Link Discovered: {title}");
                                Log.TopIndex = Log.Items.Count - 1;

                                int progressPercentage = (page * 100 + 1) / numberOfPages;
                                ReportProgress(progressPercentage);

                                await SaveHTML(link);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                        break;
                    }
                }

            }
        }

        async Task SaveHTML(string url)
        {
            Log.Items.Add("Reading HTML...");
            Log.TopIndex = Log.Items.Count - 1;

            try
            {
                var launchOptions = new LaunchOptions
                {
                    Headless = true,
                    ExecutablePath = Properties.Settings.Default.ChromePath
                };

                using (var browser = await Puppeteer.LaunchAsync(launchOptions))
                using (var page = await browser.NewPageAsync())
                {
                    var navigationTask = page.WaitForNavigationAsync(new NavigationOptions
                    {
                        WaitUntil = new[] { WaitUntilNavigation.Load }
                    });

                    await page.GoToAsync(url);
                    await navigationTask;
                    string fullPageHtml = await page.GetContentAsync();

                    var emailAddresses = ExtractEmailAddresses(fullPageHtml);

                    foreach (var emailAddress in emailAddresses)
                    {
                        Emails.Add(emailAddress);
                    }
                }
            }
            catch (PuppeteerException ex)
            {
                MessageBox.Show($"Puppeteer error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }

        }

        IEnumerable<string> ExtractEmailAddresses(string html)
        {
            var emailAddresses = new List<string>();
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            var emailNodes = doc.DocumentNode.SelectNodes("//a[contains(@href, 'mailto:')]|//*[contains(text(), '@')]");

            if (emailNodes != null)
            {
                foreach (var emailNode in emailNodes)
                {
                    var matches = Regex.Matches(emailNode.InnerText, @"[\w\.-]+@[a-zA-Z\d\.-]+\.[a-zA-Z]{2,}");

                    foreach (Match match in matches)
                    {
                        emailAddresses.Add(match.Value);
                        Log.Items.Add($"Mail Adress Found: {match.Value}");
                        Log.TopIndex = Log.Items.Count - 1;
                    }
                }
            }

            Log.Items.Add($"{emailAddresses.Count} Email Adressess found!");
            Log.TopIndex = Log.Items.Count - 1;
            return emailAddresses.Distinct();
        }

        private void ReportProgress(int percentage)
        {
            if (percentage >= currentProgress && percentage <= progressBar.Maximum)
            {
                currentProgress = percentage;
                progressBar.Value = percentage;
                Application.DoEvents();
            }
        }

        private void CleanList()
        {
            HashSet<string> uniqueEmails = new HashSet<string>(Emails);
            Emails.Clear();
            Emails.AddRange(uniqueEmails);
        }

        private void Export_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public List<string> GetEmails()
        {
            return Emails;
        }
    }
}