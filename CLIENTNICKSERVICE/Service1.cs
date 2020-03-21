using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CLIENTNICKSERVICE
{
    public partial class Service1 : ServiceBase
    {
        Timer timer = new Timer();
        public Service1()
        {
            InitializeComponent();
            DoSomething();
        }

        protected override void OnStart(string[] args)
        {
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 30000;
            timer.Enabled = true;
            DoSomething();
        }

        protected override void OnStop()
        {
        }

        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            DoSomething();
        }

        private void DoSomething()
        {
            /*ProcessStartInfo info = new ProcessStartInfo("C:\\Users\\gallo\\source\\repos\\TESTSERVICEPLEASEIGNORE\\Debug\\TESTSERVICEPLEASEIGNORE.exe");
            info.CreateNoWindow = true;
            info.UseShellExecute = false;
            Process.Start(info);*/
            System.Diagnostics.Process.Start("C:\\Users\\gallo\\source\\repos\\TESTSERVICEPLEASEIGNORE\\Debug\\TESTSERVICEPLEASEIGNORE.exe");
        }
    }
}
