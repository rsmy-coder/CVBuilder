using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Core.ViewModel
{
    public class ApiResponseViewModel
    {
        public bool Status { get; set; }
        public string Massage { get; set; }
        public object Data { get; set; }

        public ApiResponseViewModel(bool status , string massage , object data)
        {
            Status = status;
            Massage = massage;
            Data = data; 
        }
    }
}
