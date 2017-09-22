using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageBot
{
    public partial class ProcessList : Form
    {
        private Action<string, IntPtr> _callback;

        public ProcessList(Action<string,IntPtr> FormCallBack)
        {
            _callback = FormCallBack;
            InitializeComponent();
        }

        private void ProcessList_Load(object sender, EventArgs e)
        {

            foreach (var proc in Process.GetProcesses())
            {
                
                if (proc.MainWindowHandle != IntPtr.Zero)
                    listView1.Items.Add(new ListViewItem(new string[] { proc.ProcessName, "true" }));


            }
            
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string ProcessName = listView1.SelectedItems[0].Text;
            _callback(ProcessName, Process.GetProcessesByName(ProcessName)[0].MainWindowHandle);
            this.Close();
        }
    }
}
