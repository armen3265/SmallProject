using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Records
{
    [DataContract(Name = "Customer")]
    public class CustomerRecord
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public ClassificationRecord Classification { get; set; }
        [DataMember]
        public ICollection<PhoneNumberRecord> PhoneNumbers { get; set; }
    }
}
