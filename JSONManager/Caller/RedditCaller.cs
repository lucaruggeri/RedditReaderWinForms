using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RedditReaderWinForms.JSONModel;
using Newtonsoft.Json;
using System.Net.Http;
using System.Windows.Forms;
using System.Resources;

namespace RedditReaderWinForms.Caller
{
    public static class RedditCaller
    {
        private const string uri1 = "https://www.reddit.com/r/";
        private const string uri2 = ".json";

        public static async Task<RedditRootobject> GetResponse(string subreddit)
        {
            if (subreddit.Trim() == string.Empty)
            {
                throw new System.ArgumentException("Parameter 'subreddit' is empty", "subreddit");
            }

            string testResponse = await CallRemoteApi_LoadResponse(uri1 + subreddit + uri2);

            //deserialize response
            if (testResponse != null)
            {
                RedditRootobject g = new RedditRootobject();
                g = JsonConvert.DeserializeObject<RedditRootobject>(testResponse.ToString());

                //use response
                if (g != null)
                {
                    return g;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }


        private static async Task<string> CallRemoteApi_LoadResponse(string completeUri)
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
