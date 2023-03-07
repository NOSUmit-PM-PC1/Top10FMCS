using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Top10FMCS
{
    public partial class WindowsTop10 : Form
    {
        public WindowsTop10()
        {
            InitializeComponent();
        }

        List<string> GetListFromFile(string fileName)
        {
            List<string> lst = new List<string>();
            StreamReader fileVotes = new StreamReader(fileName);
            while (!fileVotes.EndOfStream)
            {
                string s = fileVotes.ReadLine();
                lst.Add(s);
            }
            fileVotes.Close();
            return lst;
        }

        List<int> CountTop10(List<string> votes, List<string> songs)
        {
            List<int> count = new List<int>();
            foreach (var song in songs)
            {
                int k = 0;
                foreach (var vote in votes)
                    if (song == vote) k++;
                count.Add(k);
            }
            return count;
        }

        private void WindowsTop10_Load(object sender, EventArgs e)
        {
            List<string> votes = GetListFromFile("votes.txt");
            List<string> songs = GetListFromFile("songs.txt");
            List<int> top10 = CountTop10(votes, songs);
            for(int i = 0; i < songs.Count; i++)
            {
                //listViewTop10.Items.Add(s);
                ListViewItem data = new ListViewItem(songs[i]);
                data.SubItems.Add(top10[i].ToString());
                listViewTop10.Items.Add(data);
            }
            
        }
    }
}
