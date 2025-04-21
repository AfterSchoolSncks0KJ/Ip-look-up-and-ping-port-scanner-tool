using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace CheckHostTool
{
    public partial class Form1 : Form
    {
        static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            //this.Icon = Properties.Resources.appicon;
        }

        private async void btnPing_Click(object sender, EventArgs e)
        {
            string host = txtHost.Text;
            txtOutput.Text = "Running Ping...";

            var response = await client.GetStringAsync($"https://check-host.net/check-ping?host={host}");
            string requestId = JObject.Parse(response)["request_id"].ToString();

            await Task.Delay(5000);

            string result = await client.GetStringAsync($"https://check-host.net/check-result/{requestId}");
            txtOutput.Text = FormatResult(result);
        }

        private async void btnDns_Click(object sender, EventArgs e)
        {
            string host = txtHost.Text;
            txtOutput.Text = "Running DNS Lookup...";

            var response = await client.GetStringAsync($"https://check-host.net/check-dns?host={host}");
            string requestId = JObject.Parse(response)["request_id"].ToString();

            await Task.Delay(5000);

            string result = await client.GetStringAsync($"https://check-host.net/check-result/{requestId}");
            txtOutput.Text = FormatResult(result);
        }

        private async void btnPort_Click(object sender, EventArgs e)
        {
            string host = txtHost.Text;
            txtOutput.Text = "Running Port Check...";

            var response = await client.GetStringAsync($"https://check-host.net/check-tcp?host={host}:80");
            string requestId = JObject.Parse(response)["request_id"].ToString();

            await Task.Delay(5000);

            string result = await client.GetStringAsync($"https://check-host.net/check-result/{requestId}");
            txtOutput.Text = FormatResult(result);
        }

        private string FormatResult(string rawJson)
        {
            var formatted = "";
            var json = JObject.Parse(rawJson);
            foreach (var kv in json)
            {
                formatted += $"[{kv.Key}]";
                var entries = kv.Value as JArray;
                if (entries != null)
                {
                    foreach (var entry in entries)
                    {
                        formatted += $" - {entry}" +
                            $"";
                    }
                }
            }
            return formatted;
        }
    }
}