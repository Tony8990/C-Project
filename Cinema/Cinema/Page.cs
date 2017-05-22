using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
namespace Cinema.Classes
{
    [DataContract]
    public class Page
    {
        [DataMember (Name = "pageId")]
        public int Id { get; set; }
        [DataMember(Name = "fullurl")]
        public string Url { get; set; }

    }
}