using LearnBlazor.Attributes;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnBlazor.Components
{
    [Route("/")]
    [Routing("Главная", Priority = 0)]
    public partial class MainApp
    {
        const string header = "Приложение Blazor";
        readonly IEnumerable<string> users = new[] { "Джон", "Vui", "Herr" };

        private Dictionary<string, object> Attr { get; set; } = new Dictionary<string, object>
        {
            ["type"] = "number",
            ["min"] = "1",
            ["max"] = "99",
            ["style"] = "width:180px;"
        };

        string info;
        string buttonText = "click me!";

        public void ClickButton(object sender, EventArgs args)
        {
            buttonText = "thx";
            (sender as MyButton).Parameters["Text"] = buttonText;
        }

        private void Alert(MouseEventArgs args)
        {
            info += "Alert!";
        }
    }
}
