using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.Classes;
using System.Runtime.Serialization;

namespace Cinema
{
    /* https://en.wikipedia.org/w/api.php?action=query&prop=info&pageids=18630637&inprop=url&format=json */
    [DataContract]
    public class FilmCollection
    { 
        [DataMember(Name = "results")]
        public List<Film> Results { get; set; }
        public string RequiestWikipediaUrl()
        {
            string ibs=string.Empty;
            foreach(Film film in Results)
            {
                ibs += String.Concat(film.WikipediaId, "|");
            }
            ibs=ibs.Substring(0, ibs.Length- 1);  
            string standardLinkFormat = "https://en.wikipedia.org/w/api.php?action=query&prop=info&pageids={0}&inprop=url";
            standardLinkFormat = string.Format(standardLinkFormat, ibs);
            return standardLinkFormat;
        }
    }
}
