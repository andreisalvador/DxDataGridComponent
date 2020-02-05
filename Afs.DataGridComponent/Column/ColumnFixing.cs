using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.Column
{
    public class ColumnFixing
    {
        public ColumnFixing()
        {
            this.Enabled = true;
        }

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}
