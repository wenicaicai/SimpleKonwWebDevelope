using Microsoft.CodeAnalysis.CSharp.Syntax;
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

    public class TestMode<T>
    {
        public IEnumerable<T> BeforeValModel { get; set; }
        public IEnumerable<T> ValModel { get; set; }
    }
}
