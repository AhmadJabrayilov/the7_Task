using System.Collections;
using System.Collections.Generic;
using The7_BackEnd.Models;

namespace The7_BackEnd.ViewModels
{
    public class HomeVM
    {
        public PageIntro PageIntro { get; set; }
        public IEnumerable<Service> Service { get; set; }
        public IEnumerable<Blog> Blog { get; set; }
        public IEnumerable<Team> Team { get; set; }

    }
}
