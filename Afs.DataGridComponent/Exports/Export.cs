using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.Exports
{
    public class Export
    {
        public Export(string fileName = "")
        {
            this.FileName = string.IsNullOrWhiteSpace(fileName) ? "ExportedFileFromDataGrid" : fileName;
            this.Enabled = true;
        }

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("allowExportSelectedData")]
        public bool? AllowExportSelectedData { get; set; }
    }
}
