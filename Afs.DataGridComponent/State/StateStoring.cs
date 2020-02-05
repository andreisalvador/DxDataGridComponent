using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.State
{
    public class StateStoring
    {
        public StateStoring()
        {
            this.Enabled = true;
        }

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("storageKey")]
        public string StorageKey { get; set; }
    }
}
