using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Assign_4_MVC_Active_Cloud_Site.Models
{
    public class Rootobject
    {
        public Meta meta { get; set; }
        public Result[] results { get; set; }
    }

    public class Meta
    {
        public string disclaimer { get; set; }
        public string terms { get; set; }
        public string license { get; set; }
        public string last_updated { get; set; }
    }
    public class Consumer
    {
        public string age { get; set; }
        public string age_unit { get; set; }
    }

    public class Result
    {
        public Products[] products { get; set; }
    }

    public class Products
    {
        public string name_brand { get; set; }
        public string industry_name { get; set; }
        public string industry_code { get; set; }
    }

    public class Reactions
    {
        public string reactions { get; set; }
    }

    public class Outcomes
    {
        public string outcomes { get; set; }
    }
}
