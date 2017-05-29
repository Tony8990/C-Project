﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Classes

{
    [DataContract]
    class WikipediaResponse
    {
        [DataMember(Name = "query")]
        public Query Query { get; set; }
    }
}
