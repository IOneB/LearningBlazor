using LearnBlazor.Attributes;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace LearnBlazor.Services
{
    public class NavigationService
    {
        static string navigations;

        public string Navigations()
        {
            if (!string.IsNullOrEmpty(navigations))
                return navigations;

            var classess = Assembly
                .GetExecutingAssembly()
                .DefinedTypes
                .Where(x => x.BaseType.FullName == typeof(ComponentBase).FullName && x.CustomAttributes.Any(x => x.AttributeType == typeof(RouteAttribute)) && x.CustomAttributes.Any(x => x.AttributeType == typeof(RoutingAttribute)))
                .OrderBy(x => x.GetCustomAttribute<RoutingAttribute>().Priority)
                .Select(x => new { Path = x.GetCustomAttribute<RouteAttribute>()?.Template, Name= x.GetCustomAttribute<RoutingAttribute>()?.Name ?? x.Name});

            
            navigations = string.Join("\n", classess.Select(x =>$"<li><a href=\"{x.Path}\">{x.Name}</a></li>"));

            return navigations;
        }
    }
}
