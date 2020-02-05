using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.Filters
{
    public abstract class FilterBase
    {
        public FilterBase()
        {
            this.Visible = true;
        }

        [JsonProperty("visible")]
        public bool? Visible { get; set; }
    }
}
