using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threads
{
    public partial class Form1 : Form
    {
        delegate void CharParamDelegate(char aChar);
        private const string MESSAGE = "This application demonstrates " + 
            "Thread.Suspend() and Thread.Resume() methods. ";

        private Thread mThread;


        public Form1()
        {
            InitializeComponent();
            mThread = new Thread(new ThreadStart(this.PrintMessages));
            mThread.IsBackground = true;
            mThread.Start();
            SuspendThread();
        }

        private void PrintMessages()
        {
            while(true)
            {
                foreach (var letter in MESSAGE.ToArray())
                {
                    try
                    {
                        this.Invoke(new CharParamDelegate(AppendTextToTextBox), new object[] { letter });
                    }
                    catch (Exception)
                    {
                        return;
                        throw;
                    }
                    Thread.Sleep(50);
                }
            }
        }

        private void AppendTextToTextBox(char aChar)
        {
            textBox1.AppendText(aChar.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SuspendThread();
        }

        private void SuspendThread()
        {
            this.mThread.Suspend();
            this.button1.Enabled = false;
            this.button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResumeThread();
        }

        private void ResumeThread()
        {
            this.mThread.Resume();
            this.button1.Enabled = true;
            this.button2.Enabled = false;
        }
    }
}
