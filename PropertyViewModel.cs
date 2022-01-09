using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoApplication.Models
{
    public class PropertyViewModel
    {
        public PropertyViewModel()
        {
            this.Properties = new List<Property>();
        }

        public string Search { get; set; }

        public List<Property> Properties { get; set; }
    }
}