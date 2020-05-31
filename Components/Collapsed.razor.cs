using LearnBlazor.Attributes;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnBlazor.Components
{
    [Route("/Collapsed")]
    [Routing("Коллапсед")]
    public partial class Collapsed
    {
        bool visible = false;
    }
}
