using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.Column
{
    public class ColumnFormat
    {
        public class FormatType
        {
            public static readonly FormatType FixedPoint = new FormatType() { Value = "fixedPoint" };
            public static readonly FormatType Percent = new FormatType() { Value = "percent" };
            public static readonly FormatType Currency = new FormatType() { Value = "currency" };
            public string Value { get; set; }
        }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("precision")]
        public byte? Precision { get; set; }
    }
}
