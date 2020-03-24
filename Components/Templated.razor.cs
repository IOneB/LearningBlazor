using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnBlazor.Components
{
    public partial class Templated<TItem>
    {
        [Parameter]
        public RenderFragment Header { get; set; }

        [Parameter]
        public RenderFragment<TItem> Main { get; set; }

        [Parameter]
        public RenderFragment Footer { get; set; }

        [Parameter]
        public IReadOnlyList<TItem> Items { get; set; }
    }
}
