using BlazorProject.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProject.Pages
{
    public partial class Counter
    {
        [Inject] SingletonServices singleton { get; set; }
        [Inject] TransientServices transient { get; set; }
        //[CascadingParameter(Name = "Color")] public string Color { get; set; }
        //[CascadingParameter(Name = "Size")] public string Size { get; set; }

        [CascadingParameter] public AppStyle Styles { get; set; }

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;

            singleton.Value = currentCount;
            transient.Value = currentCount;
        }
    }
}
