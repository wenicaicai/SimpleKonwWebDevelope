using SimpleDBContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleKonwWebDevelope.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<Employee> Employees { get; set; }
    }
}
