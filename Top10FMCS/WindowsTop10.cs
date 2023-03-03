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

        List<string> GetTop10()
        {
            List<string> lst = new List<string>();
            StreamReader fileVotes = new StreamReader("votes.txt");
            while (!fileVotes.EndOfStream)
            {
                string s = fileVotes.ReadLine();
                lst.Add(s);
            }
            fileVotes.Close();
            return lst;
        }

        private void WindowsTop10_Load(object sender, EventArgs e)
        {
            List<string> top10 = GetTop10();
            foreach (var s in top10)
                listViewTop10.Items.Add(s);
        }
    }
}
