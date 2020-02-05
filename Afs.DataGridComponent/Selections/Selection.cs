using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.Selections
{
    public class Selection
    {
        public Selection(string mode = "")
        {
            this.Mode = string.IsNullOrWhiteSpace(mode) ? SelectionTypes.Multiple.Value : mode;
        }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("deferred")]
        public bool? Deferred { get; set; }


        public class SelectionTypes
        {
            public static readonly SelectionTypes Multiple = new SelectionTypes() { Value = "multiple" };
            public static readonly SelectionTypes Single = new SelectionTypes() { Value = "single" };

            public string Value { get; set; }
        }
    }
}
