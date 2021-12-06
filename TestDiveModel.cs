using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApiCall
{
    public class Rootobject
    {
        public Similar Similar { get; set; }
    }

    public class Similar
    {
        public Info[] Info { get; set; }
        public Result[] Results { get; set; }
    }

    public class Result
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class Info
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }
}