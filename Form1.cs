using System.Drawing.Imaging;
using System.Drawing;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Diagnostics;

namespace WinFormsApp1 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void takeScreenShot()
        {
            try
            {
                screenshotButton.Enabled = false;
                screenshotButton.Text = "...";
                Bitmap captureBitmap = new Bitmap(1920, 1080, PixelFormat.Format32bppRgb);
                Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
                Graphics captureGraphics = Graphics.FromImage(captureBitmap);
                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
                preview.Image = captureBitmap;
                linkLabel1.Hide();
                screenshotButton.Hide();
                sendButton.Show();
                cancelButton.Show();
                label1.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void screenshotButton_Click(object sender, EventArgs e)
        {
            takeScreenShot();
        }

        private static readonly HttpClient client = new HttpClient();
        private async void sendButton_Click(object sender, EventArgs e)
        {
            ImageConverter converter = new ImageConverter();
            string base64ImageRepresentation = Convert.ToBase64String((byte[])converter.ConvertTo(preview.Image, typeof(byte[])));

            var values = new Dictionary<string, string>
            {
                  { "image", base64ImageRepresentation },
                  { "type", "base64" }
            };

            var clientId = "";
            var reqMsg = new HttpRequestMessage(HttpMethod.Post, "https://api.imgur.com/3/image");
            reqMsg.Headers.Authorization = new AuthenticationHeaderValue("Client-ID", clientId);
            var content = new FormUrlEncodedContent(values);
            reqMsg.Content = content;
            var response = await client.SendAsync(reqMsg);
            var responseString = await response.Content.ReadAsStringAsync();
            dynamic responseJson = JsonConvert.DeserializeObject(responseString);

            sendButton.Hide();
            preview.Image = null;
            linkLabel1.Show();
            linkLabel1.Text = responseJson.data.link.ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            screenshotButton.Enabled = true;
            screenshotButton.Text = "Screenshot";
            preview.Image = null;
            screenshotButton.Show();
            label1.Show();
            sendButton.Hide();
            cancelButton.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(linkLabel1.Text) { UseShellExecute = true };
            Process.Start(startInfo);
        }
    }
}
