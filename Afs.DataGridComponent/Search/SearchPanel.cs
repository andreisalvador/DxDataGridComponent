using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.Search
{
    public class SearchPanel
    {
        public SearchPanel()
        {
            this.Visible = true;
        }

        [JsonProperty("visible")]
        public bool? Visible { get; set; }

        [JsonProperty("highlightCaseSensitive")]
        public bool? HighlightCaseSensitive { get; set; }
    }
}
