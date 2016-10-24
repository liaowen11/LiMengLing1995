
using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace LiMengLing1995
{

    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    /// <summary>
    /// 错误日志类，所有Controller发生异常时会执行这里
    /// </summary>
    public class ErrorlogAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            InitLog4Net();
            if (!filterContext.ExceptionHandled)
            {
                string controllerName = (string)filterContext.RouteData.Values["controller"];
                string actionName = (string)filterContext.RouteData.Values["action"];
                string msgTemplate = "在执行 controller[{0}] 的 action[{1}] 时产生异常";
                LogManager.GetLogger("ErrorlogAttribute").Error(string.Format(msgTemplate, controllerName, actionName), filterContext.Exception);
                //  filterContext.Result = new RedirectResult("/Error/Show/");//跳转至错误提示页面 
                LogManager.GetLogger("LogExceptionAttribute").Error(string.Format(msgTemplate, controllerName, actionName), filterContext.Exception);
            }
            if (filterContext.Result is JsonResult)
            {
                //当结果为json时，设置异常已处理
                filterContext.ExceptionHandled = true;
            }
            else
            {
                //否则调用原始设置
                base.OnException(filterContext);
            }
        }

        private void InitLog4Net()
        {
            var logCfg = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config");
            XmlConfigurator.ConfigureAndWatch(logCfg);
        }
    }
}