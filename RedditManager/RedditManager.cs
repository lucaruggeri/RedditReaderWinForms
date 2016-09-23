using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RedditReaderWinForms.Model;
using Newtonsoft.Json;
using System.Net.Http;
using System.Windows.Forms;
using System.Resources;

namespace RedditReaderWinForms.RedditManager
{
    public static class RedditManager
    {
        private const string completeUri = "https://www.reddit.com/r/sadcringe.json";

        public static async Task GetResponse(ListBox myListBox)
        {
            string testResponse = await CallRemoteApi_LoadResponse();

            //deserialize response
            if (testResponse != null)
            {
                RedditRootobject g = new RedditRootobject();
                g = JsonConvert.DeserializeObject<RedditRootobject>(testResponse.ToString());

                //use response
                if (g != null)
                {
                    List<string> myList = new List<string>();
                    foreach(var children in g.data.children)
                    {
                        myList.Add(children.data.title);
                    }

                    myListBox.DataSource = myList;
                }
            }
        }


        private static async Task<string> CallRemoteApi_LoadResponse()
        {
            HttpClient client = WebAPI.WebAPI.CreateHttpClient(completeUri);

            HttpResponseMessage response = await client.GetAsync(completeUri);
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = string.Empty;

                string lineSeparator = ((char)0x2028).ToString();
                string paragraphSeparator = ((char)0x2029).ToString();

                jsonResponse = await response.Content.ReadAsStringAsync();
                //jsonResponse = jsonResponse.Replace("\r\n", string.Empty).Replace("\n", string.Empty).Replace("\r", string.Empty).Replace(lineSeparator, string.Empty).Replace(paragraphSeparator, string.Empty);

                return jsonResponse;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
