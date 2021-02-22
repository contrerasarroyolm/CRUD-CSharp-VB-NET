using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
using System.Data;
using System.Data.SqlClient;

namespace CRUD_CSharp
{
    public class Client
    {
        public Client() { }

        public Client(int ClientId, string FullName, string Email, string PhoneNumber)
        {
            this.ClientId = ClientId;
            this.FullName = FullName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
        }

        public int ClientId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} ({2})", FullName, Email, PhoneNumber);
        }
    }

    
}
    