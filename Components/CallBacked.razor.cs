using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnBlazor.Components
{
    public partial class CallBacked
    {
        [Parameter]
        public EventCallback<MouseEventArgs> Callback { get; set; }
    }
}
