using lesson06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lesson06.Controllers
{
    public class PvvSongController : Controller
    {
        private static List<PvvSong> pvvSongs = new List<PvvSong>()
        {
          new PvvSong{ Id = 221090085, PvvTitle = "phan viet vuong", PvvAuthor = "k22cntt3", PvvArtist = "NTU", PvvYearRelease="2020"},
          new PvvSong{ Id = 1, PvvTitle = "phan viet vuong", PvvAuthor = "k22cnt3", PvvArtist = "NTU", PvvYearRelease="2020"}
        };

        // GET: PvvSong
        public ActionResult PvvIndex()
        {
            return View(pvvSongs);
        }
        public ActionResult PvvCreate() 
        {
            var pvvsong = new PvvSong();
            return View(pvvsong);
        }
    }
}