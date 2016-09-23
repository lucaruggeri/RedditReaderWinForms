using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RedditReaderWinForms.Model;
using RedditReaderWinForms.JSONModel;
using System.Windows.Forms;

using RedditReaderWinForms.Business.Global;

namespace RedditReaderWinForms.Converter
{
    public static class RedditConverter
    {
        public static void LoadTitles(ListBox myListBox, RedditRootobject response)
        {
            if (response != null)
            {
                //initialize global variable
                Global.RedditForum = new RedditForum();
                Global.RedditForum.redditPosts = new List<RedditPost>();

                foreach (var children in response.data.children)
                {
                    //global variable
                    RedditPost newRedditPost = new RedditPost();

                    //id
                    newRedditPost.Id = children.data.id;

                    //title
                    if (children.data.title != null)
                    {
                        newRedditPost.Title = children.data.title;
                    }

                    //preview
                    if (children.data.preview != null)
                    {
                        if (children.data.preview.images[0] != null)
                        {
                            newRedditPost.PreviewPictureLink = children.data.preview.images[0].source.url;
                        }
                    }

                    //global variable 
                    Global.RedditForum.redditPosts.Add(newRedditPost);
                }

                //load combo 
                myListBox.DataSource = Global.RedditForum.redditPosts;
                myListBox.ValueMember = "id";
                myListBox.DisplayMember = "title";
            }
            else
            {
                throw new System.InvalidOperationException("JSON response is NULL");
            }
        }

        public static string FindPostPicturePreview(string id)
        {
            string pictureLink = Global.RedditForum.redditPosts.Where(x => x.Id == id).FirstOrDefault().PreviewPictureLink;

            //string[] myArray = pictureLink.Split('?');
            //return myArray[0];

            return pictureLink;
        }

    }
}
