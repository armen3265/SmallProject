using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Records
{
    [DataContract(Name = "PhoneNumber")]
    public class PhoneNumberRecord
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Number { get; set; }
    }
}
