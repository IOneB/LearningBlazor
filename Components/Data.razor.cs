using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnBlazor.Components
{
    public partial class Data
    {
        [Parameter]
        public IEnumerable<string> Users { get; set; }

        public int Count => Users?.Count() ?? 0;

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> InputAttr { get; set; }

        private void AddUser(string user)
        {
            Users = Users.Append(user);
        }
    }
}
