﻿using ContosoUniversity.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ContosoUniversity
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DbInterception.Add(new SchoolInterceptorTransientErrors());
            DbInterception.Add(new SchoolInterceptorLogging());
        }
        protected void Application_BeginRequest()
        {
            Debug.WriteLine("Begin Request");
        }

        protected void Application_MapRequestHandler()
        {
            Debug.WriteLine("Map Handler");
        }

        protected void Application_PostMapRequestHandler()
        {
            Debug.WriteLine("Post Map Handler");
        }

        protected void Application_AcquireRequestState()
        {
            Debug.WriteLine("Request State");
        }

        protected void Application_PreRequestHandlerExecute()
        {
            Debug.WriteLine("Pre Handler Execute");
        }

        protected void Application_PostRequestHandlerExecute()
        {
            Debug.WriteLine("Post Handler Execute");
        }

        protected void Application_EndRequest()
        {
            Debug.WriteLine("End Request");
        }
    }
}
