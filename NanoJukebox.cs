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
using System.Drawing.Text;
using System.Runtime.InteropServices;
using TagLib;

namespace Nano_Jukebox
{
    public partial class NanoJukebox : Form
    {
        public NanoJukebox()
        {
            InitializeComponent();
            InitializeFonts();
            GetSongs();
        }

        public void InitializeFonts()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            int fontLength;
            byte[] fontdata;
            System.IntPtr data;

            //add nunito light to the internal fonts
            fontLength = Properties.Resources.Nunito_Light.Length;
            fontdata = Properties.Resources.Nunito_Light;
            data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
            
            //add nunito regular to the internal fonts
            fontLength = Properties.Resources.Nunito_Regular.Length;
            fontdata = Properties.Resources.Nunito_Regular;
            data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
        }

        public void GetSongs()
        {
            DirectoryInfo dir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
            String[] extensions =new[] {".m4a",".mp3", ".wav" };
            FileInfo[] songs = dir.EnumerateFiles().Where(f => extensions.Contains(f.Extension.ToLower())).ToArray();

            int width = 250;
            int height = 100;

            int x = 0;
            int y = 0;
            foreach (FileInfo song in songs)
            {
                TagLib.File tagfile = TagLib.File.Create(song.FullName);
                string songTitle = tagfile.Tag.Title;
                if (songTitle == null)
                    songTitle = song.Name;
                string songArtist = tagfile.Tag.FirstAlbumArtist;
                string songAlbum = tagfile.Tag.Album;

                Panel NewPanel = new Panel();
                NewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                System.Drawing.Point loc = new System.Drawing.Point(x, y);
                NewPanel.Location = loc;
                NewPanel.Size = Panel_LibrarySong.Size;
                Panel_Library.Controls.Add(NewPanel);

                foreach (Control c in Panel_LibrarySong.Controls)
                {
                    if (c.AccessibleDescription == "LibraryAlbumArt")
                    {
                        PictureBox LibraryAlbumArt = new PictureBox();
                        LibraryAlbumArt.Location = c.Location;
                        LibraryAlbumArt.Size = c.Size;
                        NewPanel.Controls.Add(LibraryAlbumArt);
                    }
                    else if (c.AccessibleDescription == "LibrarySongTitle")
                    {
                        Label LibrarySongTitle = new Label();
                        LibrarySongTitle.Location = c.Location;
                        LibrarySongTitle.Text = songTitle;
                        LibrarySongTitle.Font = c.Font;
                        LibrarySongTitle.ForeColor = c.ForeColor;
                        LibrarySongTitle.Width = 150;
                        NewPanel.Controls.Add(LibrarySongTitle);
                    }
                    else if (c.AccessibleDescription == "LibrarySongArtist")
                    {
                        Label LibrarySongArtist = new Label();
                        LibrarySongArtist.Location = c.Location;
                        LibrarySongArtist.Text = songArtist;
                        LibrarySongArtist.Font = c.Font;
                        LibrarySongArtist.ForeColor = c.ForeColor;
                        NewPanel.Controls.Add(LibrarySongArtist);
                    }
                    else if (c.AccessibleDescription == "LibraryPlayWith")
                    {
                        Label copy = (Label)c; //needs to be cast as a Label to retrieve borderstyle
                        Label LibraryPlayWith = new Label();
                        LibraryPlayWith.Location = c.Location;
                        LibraryPlayWith.Text = c.Text;
                        LibraryPlayWith.Font = c.Font;
                        LibraryPlayWith.ForeColor = c.ForeColor;
                        LibraryPlayWith.Size = c.Size;
                        LibraryPlayWith.BorderStyle = copy.BorderStyle;
                        LibraryPlayWith.Cursor = c.Cursor;
                        LibraryPlayWith.Click += SelectSong;
                        NewPanel.Controls.Add(LibraryPlayWith);
                    }
                    /*
                    else if (c.AccessibleDescription == "LibraryNano")
                    {
                        PictureBox copy = (PictureBox)c; //needs to be cast as PictureBox to retrieve image & sizemode from
                        PictureBox LibraryNano = new PictureBox();
                        LibraryNano.Location = c.Location;
                        LibraryNano.Size = c.Size;
                        LibraryNano.Image = copy.Image;
                        LibraryNano.Cursor = c.Cursor;
                        LibraryNano.SizeMode = copy.SizeMode;
                        NewPanel.Controls.Add(LibraryNano);
                    }
                    */
                }

                x = x + width;
                if (x > width * 6)
                {
                    x = 0;
                    y = y + height;
                }
                if (y > height)
                    break;
            }
        }

        private void SelectSong(object sender, EventArgs e)
        {
            Pay payForm = new Pay();
            payForm.Show();
        }
    }
}
