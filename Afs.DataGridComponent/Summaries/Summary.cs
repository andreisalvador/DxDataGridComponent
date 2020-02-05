using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.Summaries
{
    public class Summary
    {
        public Summary()
        {
            this.TotalItems = new List<SummaryDefinition>();
            this.GroupItems = new List<SummaryDefinition>();
        }

        [JsonProperty("totalItems")]
        public IList<SummaryDefinition> TotalItems { get; set; }

        [JsonProperty("groupItems")]
        public IList<SummaryDefinition> GroupItems { get; set; }
    }
}
