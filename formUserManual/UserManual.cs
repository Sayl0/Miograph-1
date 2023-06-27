using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Miograph
{
    public partial class UserManual : Form
    {
        public UserManual()
        {
            InitializeComponent();
        }

        private void UserManual_Load(object sender, EventArgs e)
        {  
            webBrowser1.Navigate("manual.pdf");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
