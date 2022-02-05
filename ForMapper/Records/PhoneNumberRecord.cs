using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ForMapper.Records
{
    [DataContract(Name = "PhoneNumber")]
    public class PhoneNumberRecord
    {
        public int Id { get; set; }

        public string Number { get; set; }
    }
}
