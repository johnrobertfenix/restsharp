using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Web;
namespace MVC.Models
{
    public class DownloadPageAsyncResult
    {
        public string result { get; set; }
        public string reasonPhrase { get; set; }
        public HttpResponseHeaders headers { get; set; }
        public HttpStatusCode code { get; set; }
        public string errorMessage { get; set; }
    }
}