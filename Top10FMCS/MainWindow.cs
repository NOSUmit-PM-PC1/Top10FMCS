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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            GetSongsFromFile();
        }

        void GetSongsFromFile()
        {
            StreamReader fileSong = new StreamReader("songs.txt");
            while (!fileSong.EndOfStream)
            {
                string s = fileSong.ReadLine();
                listSongs.Items.Add(s);
            }
            fileSong.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listSongs.Items.Add(textSong.Text);
            StreamWriter fileSongs = new StreamWriter("songs.txt", true) ;
            fileSongs.WriteLine(textSong.Text);
            fileSongs.Close();
        }

        private void buttonGolos_Click(object sender, EventArgs e)
        {
            try
            {
                listGolos.Items.Add(listSongs.SelectedItem);
            }
            catch
            {
                MessageBox.Show("Выберите испольнителя в левом списке");
            }
            
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                listGolos.Items.RemoveAt(listGolos.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Для удаления испольнителя выберите его в верхнем списке");
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (listGolos.Items.Count == 3)
            {
                StreamWriter fileVotes = new StreamWriter("votes.txt", true);
                foreach (var s in listGolos.Items)
                    fileVotes.WriteLine(s);
                fileVotes.Close();
            }
            else
            { 
                MessageBox.Show("Вы должны проголосовать за трех исполнителей!");
            }

        }

        private void buttonItog_Click(object sender, EventArgs e)
        {
            WindowsTop10 win = new WindowsTop10();
            win.Show();
        }
    }
}
