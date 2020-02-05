using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.Pagination
{
    public class Paging
    {
        public Paging()
        {
            this.PageSize = 10;
        }

        [JsonProperty("pageSize")]
        public int? PageSize { get; set; }
    }
}
