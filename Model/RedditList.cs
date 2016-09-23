using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditReaderWinForms.Model
{
    public class Subreddits
    {
        public List<string> SubredditsList { get; set; }

        public Subreddits()
        {
            this.SubredditsList = new List<string>();
            SubredditsList.Add(string.Empty);
            SubredditsList.Add("sadcringe");
            SubredditsList.Add("whiteknighting");
            SubredditsList.Add("TheRedPill");
            SubredditsList.Add("cringe");
            SubredditsList.Add("videogames");
            SubredditsList.Add("thesimpsons");
            SubredditsList.Add("americandad");
            SubredditsList.Add("sharktank");
            SubredditsList.Add("scifi");
            SubredditsList.Add("microsoft");
        }
    }
}
