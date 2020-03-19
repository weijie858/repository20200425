using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApp.Models
{
    public class TimeJob : IJob
    {
      //  https://www.cnblogs.com/best/p/7658573.html
        public void Execute(IJobExecutionContext context)
        {
            System.IO.File.AppendAllText(@"d:\Quartz.txt", DateTime.Now + Environment.NewLine);
        }
    }
}