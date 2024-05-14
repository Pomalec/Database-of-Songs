using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databaseostapp
{
    internal class Album
    {
        public int ID {  get; set; }
        public string Videogame { get; set; }
        public string Albumname { get; set; }
        public string Artistname { get; set; }
        public int Year { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }

        //later list of track
        public List<Track> Tracks { get; set; }
    }
}
