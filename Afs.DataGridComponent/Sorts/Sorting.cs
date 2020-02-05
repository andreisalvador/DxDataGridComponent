using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.Sorts
{
    public class Sorting
    {
        public Sorting(string mode = "")
        {
            this.Mode = string.IsNullOrWhiteSpace(mode) ? SortingTypes.Multiple.Value : mode;
        }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        public class SortingTypes
        {
            public static readonly SortingTypes Multiple = new SortingTypes() { Value = "multiple" };
            public string Value { get; set; }
        }
    }
}
