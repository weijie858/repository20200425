using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using Quartz;
using Quartz.Impl;
using webApp.Models;

namespace webApp
{
    public class Global : HttpApplication
    {
        //调度器
        IScheduler scheduler;
        //调度器工厂
        ISchedulerFactory factory;
        void Application_Start(object sender, EventArgs e)
        {
            // 在应用程序启动时运行的代码
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);



            #region MyRegion
            //创建一个调度器
            factory = new StdSchedulerFactory();
            scheduler = factory.GetScheduler();
            //2、创建一个任务
            IJobDetail job = JobBuilder.Create<TimeJob>().WithIdentity("job1", "group1").Build();

            //3、创建一个触发器
            //DateTimeOffset runTime = DateBuilder.EvenMinuteDate(DateTimeOffset.UtcNow);
            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("trigger1", "group1")
                .WithCronSchedule("0/5 * * * * ?")     //5秒执行一次
                                                       //.StartAt(runTime)
                .Build();

            //4、将任务与触发器添加到调度器中
            scheduler.ScheduleJob(job, trigger);
            //5、开始执行
            scheduler.Start(); 
            #endregion
        }

        protected void Application_End(object sender, EventArgs e)
        {
            //   在应用程序关闭时运行的代码
            if (scheduler != null)
            {
                scheduler.Shutdown(true);
            }
        }
    }


}