using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadonGui
{
    class Response
    {
        public string status { get; set; }
        public int count { get; set; }
        public string after { get; set; }
        public List<Order> orders { get; set; }
    }
}
