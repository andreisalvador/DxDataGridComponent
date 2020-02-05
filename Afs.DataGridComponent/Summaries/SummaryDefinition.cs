using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.Summaries
{
    public class SummaryDefinition
    {
        [JsonProperty("column")]
        public string Column { get; set; }

        [JsonProperty("summaryType")]
        public string SummaryType { get; set; }

        [JsonProperty("displayFormat")]
        public string DisplayFormat { get; set; }

        [JsonProperty("valueFormat")]
        public string ValueFormat { get; set; }

        [JsonProperty("alignByColumn")]
        public bool? AlignByColumn { get; set; }

        [JsonProperty("showInGroupFooter")]
        public bool? ShowInGroupFooter { get; set; }

        public class SummaryTypes
        {
            public static readonly SummaryTypes Count = new SummaryTypes() { Value = "count" };
            public static readonly SummaryTypes Max = new SummaryTypes() { Value = "max" };
            public static readonly SummaryTypes Min = new SummaryTypes() { Value = "min" };
            public static readonly SummaryTypes Sum = new SummaryTypes() { Value = "sum" };

            public string Value { get; set; }
        }

        public class SummaryValueFormats
        {
            public static readonly SummaryTypes Currency = new SummaryTypes() { Value = "currency" };

            public string Value { get; set; }
        }
    }
}
