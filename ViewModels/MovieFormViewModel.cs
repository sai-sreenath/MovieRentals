using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoRentals.Models;

namespace VideoRentals.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
        public string Title { get; set; }
    }
}