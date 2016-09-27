using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RedditReaderWinForms.Model;
using RedditReaderWinForms.Caller;
using RedditReaderWinForms.Converter;

namespace RedditReaderWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            Subreddits subreddits = new Subreddits();
            this.cmbSubreddits.DataSource = subreddits.SubredditsList;
        }

        private async void LoadTitles()
        {
            string subreddit = cmbSubreddits.SelectedValue.ToString().Trim();

            try
            {
                Converter.RedditConverter.LoadTitles(txtTitles, await Caller.RedditCaller.GetResponse(subreddit));
            }
            catch
            {

            }
        }

        private void cmbSubreddits_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTitles();
        }

        private void txtTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //load picture
                string id = txtTitles.GetItemText(((RedditPost)txtTitles.SelectedItem).Id);

                picPreview.Image = null;
                picPreview.SizeMode = PictureBoxSizeMode.Zoom;
                picPreview.Load(Converter.RedditConverter.FindPostPicturePreview(id));
            }
            catch(Exception exc)
            {
                //THIS IS FOR A GITHUB TEST
            }
        }
    }
}
