using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Classes
{
    [DataContract]
    public class Query
    {
        [DataMember(Name = "pages")]

        public Dictionary<string,Page> Pages { get; set; }
    }
}