using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models.viewmodel
{
    public class BranchModel
    {

        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string Address { get; set; }
        public string InstitutionCode { get; set; }
        public string BranchStationCode { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<System.DateTime> ActivationDate { get; set; }
        public string ShortCode { get; set; }
        public string CentralSLCode { get; set; }
        public Nullable<bool> isclearingCenter { get; set; }
        public string CentralDrSLCode { get; set; }
        public string CentralCrSLCode { get; set; }
    }
}