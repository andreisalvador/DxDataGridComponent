using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.Edition
{
    public class Editing
    {
        [JsonProperty("allowUpdating")]
        public bool? AllowUpdating { get; set; }

        [JsonProperty("allowDeleting")]
        public bool? AllowDeleting { get; set; }

        [JsonProperty("selectTextOnEditStart")]
        public bool? SelectTextOnEditStart { get; set; }

        [JsonProperty("useIcons")]
        public bool? UseIcons { get; set; }
    }
}
