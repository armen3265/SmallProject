using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class PhoneNumber : IEquatable<PhoneNumber>
    {
       
        public bool Equals(PhoneNumber other)
        {
            if (this.GetHashCode() == other.GetHashCode())
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return Id^Number.GetHashCode();
        }
    }
}
