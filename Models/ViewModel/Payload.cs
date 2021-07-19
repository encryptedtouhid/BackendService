using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendService.Models.ViewModel
{
    public class Payload
    {
        public string Message { get; set; }
        public bool Status { get; set; }
        public dynamic Data { get; set; }


    }
}
