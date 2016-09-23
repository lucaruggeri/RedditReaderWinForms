using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditReaderWinForms.Model
{
    public class RedditForum
    {
        public List<RedditPost> redditPosts { get; set; }
    }

    public class RedditPost
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string PreviewPictureLink { get; set; }
    }
}


