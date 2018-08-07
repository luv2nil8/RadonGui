using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadonGui
{
    public class Inspector
    {
        public string id { get; set; }
        public string requested { get; set; }
    }

    public class Client
    {
        public string id { get; set; }
        public string first { get; set; }
        public string last { get; set; }
        public string display { get; set; }
        public string email { get; set; }
        public string url { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string stateabbreviation { get; set; }
        public string postal { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string workphone { get; set; }
        public string homephone { get; set; }
        public string mobilephone { get; set; }
        public string workfax { get; set; }
        public string homefax { get; set; }
        public string notes { get; set; }
        public DateTime modified { get; set; }
        public string show { get; set; }
    }

    public class Contact
    {
        public string id { get; set; }
        public string type { get; set; }
        public string contacttype { get; set; }
        public string first { get; set; }
        public string last { get; set; }
        public string display { get; set; }
        public string email { get; set; }
        public string url { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string stateabbreviation { get; set; }
        public string postal { get; set; }
        public string workphone { get; set; }
        public string homephone { get; set; }
        public string mobilephone { get; set; }
        public string workfax { get; set; }
        public string homefax { get; set; }
        public string notes { get; set; }
        public List<string> labels { get; set; }
        public string photourl { get; set; }
        public DateTime modified { get; set; }
        public string show { get; set; }
    }

    public class BuyersAgent
    {
        public string id { get; set; }
        public string agency { get; set; }
        public string first { get; set; }
        public string last { get; set; }
        public string display { get; set; }
        public string email { get; set; }
        public string url { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string stateabbreviation { get; set; }
        public string postal { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string workphone { get; set; }
        public string homephone { get; set; }
        public string mobilephone { get; set; }
        public string workfax { get; set; }
        public string homefax { get; set; }
        public string notes { get; set; }
        public string bio { get; set; }
        public DateTime lastactive { get; set; }
        public List<string> labels { get; set; }
        public string photourl { get; set; }
        public DateTime modified { get; set; }
        public string show { get; set; }
    }

    public class SellersAgent
    {
        public string id { get; set; }
        public string agency { get; set; }
        public string first { get; set; }
        public string last { get; set; }
        public string display { get; set; }
        public string email { get; set; }
        public string url { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string stateabbreviation { get; set; }
        public string postal { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string workphone { get; set; }
        public string homephone { get; set; }
        public string mobilephone { get; set; }
        public string workfax { get; set; }
        public string homefax { get; set; }
        public string notes { get; set; }
        public string bio { get; set; }
        public DateTime lastactive { get; set; }
        public List<string> labels { get; set; }
        public string photourl { get; set; }
        public DateTime modified { get; set; }
        public string show { get; set; }
    }

    public class InsuranceAgent
    {
        public string id { get; set; }
        public string agency { get; set; }
        public string first { get; set; }
        public string last { get; set; }
        public string display { get; set; }
        public string email { get; set; }
        public string url { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string stateabbreviation { get; set; }
        public string postal { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string workphone { get; set; }
        public string homephone { get; set; }
        public string mobilephone { get; set; }
        public string workfax { get; set; }
        public string homefax { get; set; }
        public string notes { get; set; }
        public string bio { get; set; }
        public DateTime lastactive { get; set; }
        public List<string> labels { get; set; }
        public string photourl { get; set; }
        public DateTime modified { get; set; }
        public string show { get; set; }
    }

    public class EscrowOfficer
    {
        public string id { get; set; }
        public string agency { get; set; }
        public string first { get; set; }
        public string last { get; set; }
        public string display { get; set; }
        public string email { get; set; }
        public string url { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string stateabbreviation { get; set; }
        public string postal { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string workphone { get; set; }
        public string homephone { get; set; }
        public string mobilephone { get; set; }
        public string workfax { get; set; }
        public string homefax { get; set; }
        public string notes { get; set; }
        public string bio { get; set; }
        public DateTime lastactive { get; set; }
        public List<string> labels { get; set; }
        public string photourl { get; set; }
        public DateTime modified { get; set; }
        public string show { get; set; }
    }

    public class Fee
    {
        public string id { get; set; }
        public string amount { get; set; }
        public string outsourceamount { get; set; }
        public string name { get; set; }
    }

    public class Control
    {
        public string name { get; set; }
        public string label { get; set; }
        public string type { get; set; }
        public string value { get; set; }
    }

    public class Service
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Order
    {
        public string id { get; set; }
        public int oid { get; set; }
        public string canceled { get; set; }
        public string show { get; set; }
        public string complete { get; set; }
        public string paid { get; set; }
        public string signature { get; set; }
        public string osorder { get; set; }
        public string office { get; set; }
        public DateTime datetime { get; set; }
        public string datetimeformatted { get; set; }
        public string duration { get; set; }
        public DateTime createddatetime { get; set; }
        public string createdby { get; set; }
        public string scheduleddatetime { get; set; }
        public string osscheduleddatetime { get; set; }
        public string confirmeddatetime { get; set; }
        public string deleteddatetime { get; set; }
        public string canceleddatetime { get; set; }
        public string completeddatetime { get; set; }
        public string initialcompleteddatetime { get; set; }
        public string scheduledby { get; set; }
        public string canceledby { get; set; }
        public string confirmedby { get; set; }
        public string deletedby { get; set; }
        public string initialcompletedby { get; set; }
        public string completedby { get; set; }
        public string referreason { get; set; }
        public string referredreason { get; set; }
        public string cancelreason { get; set; }
        public string cancelreasonstring { get; set; }
        public string client { get; set; }
        public string buyersagent { get; set; }
        public string sellersagent { get; set; }
        public string buyersagentcontactnotes { get; set; }
        public string sellersagentcontactnotes { get; set; }
        public string insuranceagent { get; set; }
        public string escrowofficer { get; set; }
        public string squarefeet { get; set; }
        public string yearbuilt { get; set; }
        public string totalfee { get; set; }
        public string reportnumber { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string stateabbreviation { get; set; }
        public string zip { get; set; }
        public string county { get; set; }
        public int latitude { get; set; }
        public string longitude { get; set; }
        public string majorcrossstreets { get; set; }
        public string mapurl { get; set; }
        public string policynumber { get; set; }
        public string policyholder { get; set; }
        public string inspector1 { get; set; }
        public string inspector2 { get; set; }
        public string inspector3 { get; set; }
        public string inspector4 { get; set; }
        public string inspector5 { get; set; }
        public string inspector6 { get; set; }
        public string inspector7 { get; set; }
        public string inspector8 { get; set; }
        public string inspector9 { get; set; }
        public string inspector10 { get; set; }
        public string inspector1requested { get; set; }
        public string inspector2requested { get; set; }
        public string inspector3requested { get; set; }
        public string inspector4requested { get; set; }
        public string inspector5requested { get; set; }
        public string inspector6requested { get; set; }
        public string inspector7requested { get; set; }
        public string inspector8requested { get; set; }
        public string inspector9requested { get; set; }
        public string inspector10requested { get; set; }
        public List<Contact> contacts { get; set; }
        public string ordertype { get; set; }
        public string foundation { get; set; }
        public string costcenter { get; set; }
        public string costcentername { get; set; }
        public List<Fee> fees { get; set; }
        public string propertyoccupied { get; set; }
        public string utilitieson { get; set; }
        public string gatecode { get; set; }
        public List<Control> controls { get; set; }
        public List<Service> services { get; set; }
        public DateTime modified { get; set; }
    }
}
