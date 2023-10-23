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

namespace _04TPThreadPriority
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart thread1 = new ThreadStart(MyThreadClass.Thread1);
            ThreadStart thread2 = new ThreadStart(MyThreadClass.Thread2);

            Thread threadA = new Thread(thread1);
            threadA.Name = "Thread A";
            Thread threadB = new Thread(thread2);
            threadB.Name = "Thread B";
            Thread threadC = new Thread(thread1);
            threadC.Name = "Thread C";
            Thread threadD = new Thread(thread2);
            threadD.Name = "Thread D";



            Console.WriteLine(label1.Text.ToString());

            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            label1.Text = "-End of Thread-";
            Console.WriteLine(label1.Text.ToString());
        }
    }
}
