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
            DirectoryInfo dir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
            FileInfo[] songs = dir.GetFiles("*.mp3,*.mp4");
            foreach(FileInfo song in songs)
            {
                Panel NewPanel = new Panel_LibrarySong();
            }
        }
    }
}
