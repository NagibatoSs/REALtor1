using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REALtor.Models
{
    public class Person
    {
        public int id { get; set; }
        public string Fio { get; set; }
        public int NumberOfPhone { get; set; }
        public string Email { get; set; }
        public string Requirements { get; set; }
        //покупатель или разместитель
        public string Status { get; set; }
    }
}
