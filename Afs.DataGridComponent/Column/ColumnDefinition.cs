using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.Column
{
    public class ColumnDefinition
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("fixed")]
        public bool? Fixed { get; set; }

        [JsonProperty("dataField")]
        public string DataField { get; set; }

        [JsonProperty("alignment")]
        public string Alignment { get; set; }

        [JsonProperty("format")]
        public ColumnFormat Format { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("groupIndex")]
        public int? GroupIndex { get; set; }

        [JsonProperty("allowGrouping")]
        public bool? AllowGrouping { get; set; }

        [JsonProperty("cssClass")]
        public string CssClass { get; set; }

        [JsonProperty("sortOrder")]
        public string SortOrder { get; set; }

        [JsonProperty("visible")]
        public bool? Visible { get; set; }

        public class ColumnDataTypes
        {
            public static readonly ColumnDataTypes Text = new ColumnDataTypes() { Value = "string" };
            public static readonly ColumnDataTypes Date = new ColumnDataTypes() { Value = "date" };
            public static readonly ColumnDataTypes Number = new ColumnDataTypes() { Value = "number" };
            public string Value { get; set; }
        }

        public class ColumnSortOrders
        {
            public static readonly ColumnSortOrders Descending = new ColumnSortOrders() { Value = "desc" };
            public static readonly ColumnSortOrders Ascending = new ColumnSortOrders() { Value = "asc" };            
            public string Value { get; set; }
        }

        public class ColumnAlignments
        {
            public static readonly ColumnAlignments Right = new ColumnAlignments() { Value = "right" };
            public static readonly ColumnAlignments Left = new ColumnAlignments() { Value = "left" };
            public static readonly ColumnAlignments Center = new ColumnAlignments() { Value = "center" };
            public string Value { get; set; }
        }
    }
}
