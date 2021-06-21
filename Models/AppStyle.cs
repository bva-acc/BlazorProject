using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProject.Models
{
    public class AppStyle
    {
        public string Color { get; set; } = "green";
        public string Size { get; set; } = "65px";

        public List<string> WizardWords { get; set; } = new List<string>()
        {
            new string ("Abracadabra"),
            new string ("Wooohooo"),
            new string ("Sim-sala-bim")
        };
        public List<TableListModel> TableStyle { get; set; } = new List<TableListModel>()
        {
            new TableListModel()
            {
                Text = "Table Dark", Value = "table-dark"
            },
            new TableListModel()
            {
                Text = "Table Striped", Value = "table-striped"
            },
            new TableListModel()
            {
                Text = "Table Bordered", Value = "table-bordered"
            }
        };
    }
}
