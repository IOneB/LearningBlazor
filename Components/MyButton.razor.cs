using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace LearnBlazor.Components
{
    public partial class MyButton
    {
        [Parameter]
        public EventHandler Click { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> Parameters { get; set; } = new Dictionary<string, object>();
    }
}
