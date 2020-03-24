using LearnBlazor.Attributes;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace LearnBlazor.Components
{
    [Route("/CssEditor")]
    [Routing("Редактор css")]
    public partial class CssEditor
    {
        string property = "height", value = "10px";
        readonly Dictionary<string, string> css = new Dictionary<string, string>();

        string Css
        {
            get => string.Join(";", css.Select(x => $"{x.Key}:{x.Value}"));
            set { }
        }

        private void SelectChange(ChangeEventArgs args)
        {
            if ((property == "height" || property == "width") && args.Value.ToString() == "background-color")
                value = "red";
            else if ((args.Value.ToString() == "height" || args.Value.ToString() == "width") && property == "background-color")
                value = "10px";
            property = args.Value.ToString();
        }
    }
}
