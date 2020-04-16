using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profiler
{
    public partial class AdressWindow : Form
    {
        public AdressWindow()
        {
            InitializeComponent();
        }

        public static string ip = "";
        public static string port = "";

        private void Button1_Click(object sender, EventArgs e)
        {
            ip = IPBox.Text;
            port = PortBox.Text;
        }
    }
}
