using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;
using RestSharp;
using MVC.Helper;

namespace MVC.Controllers
{
    public class ServerDataController : Controller
    {
        //www.c-sharpcorner.com/UploadFile/g_arora/how-to-consume-Asp-Net-web-api-from-Asp-Net-mvc4-using-rests/

        static readonly IServerDataRestClient RestClient = new ServerDataRestClient();
        public ActionResult Index()
        {
            return View(RestClient.GetAll());
        }
    }
}