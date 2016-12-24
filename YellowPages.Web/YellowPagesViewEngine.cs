using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YellowPages.Web
{
    public class YellowPagesViewEngine : RazorViewEngine
    {
        public YellowPagesViewEngine() : base()
        {
            AreaViewLocationFormats = new string[]
            {
                "~/Areas/{2}/Views/{1}/{0}.cshtml",
                "~/Areas/{2}/Views/Shared/{0}.cshtml"
            };
            AreaMasterLocationFormats = new string[]
            {
                "~/Areas/{2}/Views/{1}/{0}.cshtml",
                "~/Areas/{2}/Views/Shared/{0}.cshtml"
            };
            AreaPartialViewLocationFormats = new string[]
            {
                "~/Areas/{2}/Views/{1}/{0}.cshtml",
                "~/Areas/{2}/Views/Shared/{0}.cshtml"
            };
            ViewLocationFormats = new string[]
            {
                "~/Views/{1}/{0}.cshtml",
                "~/Views/Shared/{0}.cshtml"
            };
            MasterLocationFormats = new string[]
            {
                "~/Views/{1}/{0}.cshtml",
                "~/Views/Shared/{0}.cshtml"
            };
            PartialViewLocationFormats = new string[]
            {
                "~/Views/{1}/{0}.cshtml",
                "~/Views/Shared/{0}.cshtml"
            };
            FileExtensions = new string[] { "cshtml" };
        }
        //public YellowPagesViewEngine() : base()
        //{
        //    AreaViewLocationFormats = new string[]
        //    {
        //        "~/Areas/{2}/Views/{1}/%1/{0}.cshtml",
        //        "~/Areas/{2}/Views/Shared/%1/{0}.cshtml"
        //    };
        //    AreaMasterLocationFormats = new string[]
        //    {
        //        "~/Areas/{2}/Views/{1}/%1/{0}.cshtml",
        //        "~/Areas/{2}/Views/Shared/%1/{0}.cshtml"
        //    };
        //    AreaPartialViewLocationFormats = new string[]
        //    {
        //        "~/Areas/{2}/Views/{1}/%1/{0}.cshtml",
        //        "~/Areas/{2}/Views/Shared/%1/{0}.cshtml"
        //    };
        //    ViewLocationFormats = new string[]
        //    {
        //        "~/Views/{1}/%1/{0}.cshtml",
        //        "~/Views/Shared/%1/{0}.cshtml"
        //    };
        //    MasterLocationFormats = new string[]
        //    {
        //        "~/Views/{1}/%1/{0}.cshtml",
        //        "~/Views/Shared/%1/{0}.cshtml"
        //    };
        //    PartialViewLocationFormats = new string[]
        //    {
        //        "~/Views/{1}/%1/{0}.cshtml",
        //        "~/Views/Shared/%1/{0}.cshtml"
        //    };
        //    FileExtensions = new string[] {"cshtml"};
        //}

        //protected override IView CreateView(ControllerContext controllerContext, string viewPath, string masterPath)
        //{
        //    return base.CreateView(controllerContext, viewPath.Replace("%1", "Pages"), masterPath);
        //}

        //protected override IView CreatePartialView(ControllerContext controllerContext, string partialPath)
        //{
        //    return base.CreatePartialView(controllerContext, partialPath.Replace("%1", "PartialPages"));
        //}

        //protected override bool FileExists(ControllerContext controllerContext, string virtualPath)
        //{
        //    return (base.FileExists(controllerContext, virtualPath.Replace("%1", "Pages")) ||
        //            base.FileExists(controllerContext, virtualPath.Replace("%1", "PartialPages")));
        //}
    }
}