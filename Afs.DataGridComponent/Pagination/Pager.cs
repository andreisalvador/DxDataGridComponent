using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.Pagination
{
    public class Pager
    {
        public Pager()
        {
            this.AllowedPageSizes = new int?[] { 10, 25, 50, 100, 200 };
        }

        [JsonProperty("showPageSizeSelector")]
        public bool? ShowPageSizeSelector { get; set; }

        [JsonProperty("showNavigationButtons")]
        public bool? ShowNavigationButtons { get; set; }

        [JsonProperty("allowedPageSizes")]
        public int?[] AllowedPageSizes { get; set; }

        [JsonProperty("showInfo")]
        public bool? ShowInfo { get; set; }
    }
}
