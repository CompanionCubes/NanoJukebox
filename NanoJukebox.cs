using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Nano_Jukebox
{
    public partial class NanoJukebox : Form
    {
        public NanoJukebox()
        {
            InitializeComponent();
            GetSongs();
        }

        public void GetSongs()
        {
            DirectoryInfo dir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
            FileInfo[] songs = dir.GetFiles("*.m4a");

            int x = 0;
            int y = 0;
            foreach (FileInfo song in songs)
            {
                //Console.WriteLine(song.ToString());

                Panel NewPanel = new Panel();
                //NewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                System.Drawing.Point loc = new System.Drawing.Point(x, y);
                NewPanel.Location = loc;
                Panel_Library.Controls.Add(NewPanel);

                foreach (Control c in Panel_LibrarySong.Controls)
                {
                    if (c.AccessibleDescription == "LibrarySongTitle")
                    {
                        Label l = (Label)c;
                        l.Text = song.ToString();
                    }
                    NewPanel.Controls.Add(c);
                }

                x = x + 190;
                if (x > 190 * 6)
                {
                    x = 0;
                    y = y + 100;
                }
                if (y > 100)
                    break;
            }
        }
    }
}
