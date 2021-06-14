using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CineStore.Models;

namespace CineStore.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }

        public List<Customer> Customers { get; set; }
    }
}