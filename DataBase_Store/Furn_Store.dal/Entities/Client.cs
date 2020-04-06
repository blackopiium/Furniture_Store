using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furnit.Entities
{
    public class Client
    {
        public int Id_Client { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public int Id_Order { get; set; }
        public string Phone_number { get; set; }
        public string E_mail { get; set; }


    }
}
