using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadonGui
{
    public class User
    {
        public string id { get; set; }
        public string first { get; set; }
        public string last { get; set; }
        public string display { get; set; }
        public string email { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string state_abbreviation { get; set; }
        public string postal { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string work_phone { get; set; }
        public string home_phone { get; set; }
        public string mobile_phone { get; set; }
        public string work_fax { get; set; }
        public string home_fax { get; set; }
        public string notes { get; set; }
        public DateTime modified { get; set; }
        public bool show { get; set; }
    }
}
