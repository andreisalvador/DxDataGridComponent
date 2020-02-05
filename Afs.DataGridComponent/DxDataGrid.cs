using Afs.DataGridComponent.Column;
using Afs.DataGridComponent.Data;
using Afs.DataGridComponent.Edition;
using Afs.DataGridComponent.Exports;
using Afs.DataGridComponent.Filters;
using Afs.DataGridComponent.Group;
using Afs.DataGridComponent.Pagination;
using Afs.DataGridComponent.Search;
using Afs.DataGridComponent.Selections;
using Afs.DataGridComponent.Sorts;
using Afs.DataGridComponent.State;
using Afs.DataGridComponent.Summaries;
using Newtonsoft.Json;

namespace Afs.DataGridComponent
{
    public class DxDataGrid
    {
        [JsonProperty("showBorders")]
        public bool? ShowBorders { get; set; }

        [JsonProperty("remoteOperations")]
        public bool? RemoteOperations { get; set; }

        [JsonProperty("allowColumnReordering")]
        public bool? AllowColumnReordering { get; set; }

        [JsonProperty("allowColumnResizing")]
        public bool? AllowColumnResizing { get; set; }

        [JsonProperty("rowAlternationEnabled")]
        public bool? RowAlternationEnabled { get; set; }

        [JsonProperty("columnAutoWidth")]
        public bool? ColumnAutoWidth { get; set; }

        [JsonProperty("focusedRowEnabled")]
        public bool? FocusedRowEnabled { get; set; }

        [JsonProperty("hoverStateEnabled")]
        public bool? HoverStateEnabled { get; set; }

        [JsonProperty("headerFilter")]
        public HeaderFilter HeaderFilter { get; set; }

        [JsonProperty("filterPanel")]
        public FilterPanel FilterPanel { get; set; }

        [JsonProperty("filterRow")]
        public FilterRow FilterRow { get; set; }

        [JsonProperty("editing")]
        public Editing Editing { get; set; }

        [JsonProperty("keyExpr")]
        public string KeyExpression { get; set; }

        [JsonProperty("columnChooser")]
        public ColumnChooser ColumnChooser { get; set; }

        [JsonProperty("columnFixing")]
        public ColumnFixing ColumnFixing { get; set; }

        [JsonProperty("columns")]
        public Columns Columns { get; set; }

        [JsonProperty("groupPanel")]
        public GroupPanel GroupPanel { get; set; }

        [JsonProperty("grouping")]
        public Grouping Grouping { get; set; }

        [JsonProperty("searchPanel")]
        public SearchPanel SearchPanel { get; set; }

        [JsonProperty("pager")]
        public Pager Pager { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }

        [JsonProperty("export")]
        public Export Export { get; set; }

        [JsonProperty("selection")]
        public Selection Selection { get; set; }

        [JsonProperty("stateStoring")]
        public StateStoring StateStoring { get; set; }

        [JsonProperty("selectionFilter")]
        public string[] SelectionFilter { get; set; }

        [JsonProperty("summary")]
        public Summary Summary { get; set; }

        [JsonProperty("dataSource")]
        public DataSource DataSource { get; set; }

        [JsonProperty("sorting")]
        public Sorting Sorting { get; set; }
    }
}
