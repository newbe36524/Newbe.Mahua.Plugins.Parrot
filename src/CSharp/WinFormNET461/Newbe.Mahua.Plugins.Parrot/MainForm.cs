using Nancy.Hosting.Self;
using System;
using System.Windows.Forms;

namespace Newbe.Mahua.Plugins.Parrot
{
    public partial class MainForm : Form
    {
        private readonly NancyHost _nancyHost;

        public MainForm()
        {
            InitializeComponent();
            _nancyHost = new NancyHost(new Uri("http://localhost:65321"));
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _nancyHost.Dispose();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _nancyHost.Start();
        }
    }
}