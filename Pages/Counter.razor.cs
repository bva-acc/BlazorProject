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

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;

            singleton.Value = currentCount;
            transient.Value = currentCount;
        }
    }
}
