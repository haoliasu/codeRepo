using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;


namespace WebCrawler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool _stop;
        private bool[] _reqsBusy = null;
        private int _reqCount = 4;
        private void DispatchWork()
        {
            if (_stop)
            {
                return;
            }
            for (int i = 0; i < _reqCount; i++)
            {
                if (!_reqsBusy[i])
                {
                    RequestResource(i);
                }
            }
        }

        private void RequestResource(int index)
        {
            int depth;
            string url = "";
            Object _locker = new Object();
            try
            {
                lock (_locker)
                {
 
                }
            }
            catch (WebException we)
            {
                MessageBox.Show("RequestResource" + we.Message + url + we.Status);
            }
        }






    }
}
