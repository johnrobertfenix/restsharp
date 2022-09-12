using MVC.Models;
using MVC.Models.viewmodel;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {

        private string BaseURLx = "";
        private readonly RestClient _client;
        //private readonly string _url = ConfigurationManager.AppSettings["webapibaseurl"].ToString();
        public HomeController()
        {
            BaseURLx = ConfigurationManager.AppSettings["BaseUrl"];
            _client = new RestClient { BaseUrl = new Uri(BaseURLx) };
        }




        // IMPORTANT//
        //stackoverflow.com/questions/47651525/issue-with-restsharp-installation-in-visual-studio-2013
        //visualstudiomagazine.com/articles/2015/10/01/consume-a-webapi.aspx
        //www.c-sharpcorner.com/UploadFile/g_arora/how-to-consume-Asp-Net-web-api-from-Asp-Net-mvc4-using-rests/

       
       // BASIC SAMPLE

        public async Task<ActionResult> Index()
        {
            try
            {
                //consume via restsharp
                //working kaso nasa ibang API project yun Business logic, pero ito yun pang call  to consume , 
                //ConfigurationManager.AppSettings["BaseUrl"] ang ang configure u para sa API project




                List<BranchModel> branchList = new List<BranchModel>(); ;
                var request = new RestRequest("api/Branches", Method.GET) { RequestFormat = DataFormat.Json };
                var response = _client.Execute<List<BranchModel>>(request);
                branchList = response.Data;
                ViewBag.BranchList = new SelectList(branchList, "BranchCode", "BranchName");
                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



        //HTTPCLIENT approach

        //public async Task<DownloadPageAsyncResult> GetBranches()
        //{
        //    var result = new DownloadPageAsyncResult();
        //    using (HttpClient client = new HttpClient())
        //    {
        //        //Passing service base url
        //        client.BaseAddress = new Uri(BaseURLx);       
        //        client.DefaultRequestHeaders.Clear();
        //        //Define request data format
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //        //Sending request to create web api REST service resource [] using HttpClient
        //        HttpResponseMessage response = await client.GetAsync("api/Branches");

        //        result.result = response.Content.ReadAsStringAsync().Result;
        //        result.reasonPhrase = response.ReasonPhrase;
        //        result.headers = response.Headers;
        //        result.code = response.StatusCode;
        //    }

        //    return result;
        //}


        //restsharp approach

        //public IEnumerable<BranchModel> GetBranches()
        //{
        //    var request = new RestRequest("api/Branches", Method.GET) { RequestFormat = DataFormat.Json };

        //        var response = _client.Execute<List<BranchModel>>(request);

        //        if (response.Data == null)
        //            throw new Exception(response.ErrorMessage);

        //        return response.Data;
        //}



    }
}