using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.Group
{
    public class GroupPanel
    {
        [JsonProperty("visible")]
        public bool? Visible { get; set; }
    }
}
