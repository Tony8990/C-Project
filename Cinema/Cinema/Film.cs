using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Cinema.Classes
{
    [DataContract]
    public class Film {
        [DataMember(Name = "title")]
        public string Title { get; set; }

        public FilmGenre Genre { get; set; }

        public int Duration { get; set; }

        //public bool Is3D { get; set; }
        [DataMember (Name="release_year")]
        public int ReleaseYear { get; set; }
        [DataMember(Name = "in_theaters")]

        public bool InTheaters { get; set; }
        [DataMember(Name = "poster_120x171")]

        public string PosterURL { get; set; }
        [DataMember(Name = "wikipedia_id")]
        public int WikipediaId { get; set; }

        public string WikipediaUrl { get; set; }

    }
}
