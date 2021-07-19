using BackendService.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendService.Helpers
{
    public class ResponseProcess
    {
        public static Payload MakeResponse(dynamic data)
        {
            Payload payload = new Payload();
            if (data != null)
            {
                payload.Message = "Successfull";
                payload.Status = true;
                payload.Data = data;
            }
            else
            {
                payload.Message = "Unsuccessfull";
                payload.Status = false;
                payload.Data = "No Data";
            }

            return payload;
        }
    }
}
