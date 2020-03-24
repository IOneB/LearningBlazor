using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnBlazor.Components
{
    public partial class AddForm
    {
        [Parameter]
        public EventCallback<string> Callback { get; set; }

        string item;
    }
}
