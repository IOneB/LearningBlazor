using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnBlazor.Attributes
{
    public class RoutingAttribute : Attribute
    {
        public RoutingAttribute()
        {

        }
        public RoutingAttribute(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public int Priority { get; set; } = 100;
    }
}
