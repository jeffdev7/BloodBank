using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string Last_Name {get;set;}
        public string Id { get; set; }
        public string Type { get; set; }
        public string Phone { get; set; }
    }
}
