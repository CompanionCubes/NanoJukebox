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
            String[] extensions =new[] {".m4a",".mp3" };
            FileInfo[] songs = dir.EnumerateFiles().Where(f => )

            int x = 0;
            int y = 0;
            int test_i = 0;
            foreach (FileInfo song in songs)
            {
                Console.WriteLine(song.ToString());

                Panel NewPanel = new Panel();
                //NewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                System.Drawing.Point loc = new System.Drawing.Point(x, y);
                NewPanel.Location = loc;
                Panel_Library.Controls.Add(NewPanel);

                foreach (Control c in Panel_LibrarySong.Controls)
                {
                    if (c.AccessibleDescription == "LibrarySongTitle")
                    {
                        test_i++;
                        Console.WriteLine(test_i);
                        Label l = (Label)c;
                        l.Text = song.ToString();
                        Console.WriteLine(l.Text);
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
