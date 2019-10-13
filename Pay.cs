using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Nano_Jukebox
{
    [ComVisible(true)]
    public partial class Pay : Form
    {
        public Pay()
        {
            InitializeComponent();

            PayBrowser.AllowWebBrowserDrop = false;
            PayBrowser.IsWebBrowserContextMenuEnabled = false;
            PayBrowser.WebBrowserShortcutsEnabled = false;
            PayBrowser.ObjectForScripting = this;
            // Uncomment the following line when you are finished debugging.
            //PayBrowser.ScriptErrorsSuppressed = true;

            PayBrowser.DocumentText = Properties.Resources.Pay;
        }
    }
}
