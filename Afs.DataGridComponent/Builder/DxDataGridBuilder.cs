using Afs.DataGridComponent.Column;
using Afs.DataGridComponent.Configuration;
using Afs.DataGridComponent.Configuration.Column;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.Builder
{
    public class DxDataGridBuilder
    {
        private DxDataGrid dataGrid;
        public DxDataGridBuilder()
        {
            this.dataGrid = new DxDataGrid();
        }

        public DxDataGridBuilder WithDxDataGridConfiguration(DxDataGridConfiguration gridConfiguration)
        {
            this.dataGrid.ShowBorders = gridConfiguration.ShowBorders;
            this.dataGrid.RemoteOperations = gridConfiguration.RemoteOperations;
            this.dataGrid.AllowColumnReordering = gridConfiguration.AllowColumnReordering;
            this.dataGrid.AllowColumnResizing = gridConfiguration.AllowColumnResizing;
            this.dataGrid.RowAlternationEnabled = gridConfiguration.RowAlternationEnabled;
            this.dataGrid.ColumnAutoWidth = gridConfiguration.ColumnAutoWidth;
            this.dataGrid.FocusedRowEnabled = gridConfiguration.FocusedRowEnabled;

            return this;
        }

        public DxDataGridBuilder WithEdition()
        {
            this.dataGrid.Editing = new Edition.Editing()
            {
                AllowDeleting = true,
                AllowUpdating = true,
                SelectTextOnEditStart = true,
                UseIcons = true
            };
            return this;
        }

        public DxDataGridBuilder WithColumns(IDictionary<string, object> columns, Action<KeyValuePair<string, object>, ColumnDefinition> columnDefinitionMutationAction = null, IColumnConfiguration[] columnsConfiguration = null)
        {
            Column.Columns internalColmuns = new Column.Columns();

            foreach (var column in columns)
            {
                ColumnDefinition columnDefinition = new ColumnDefinition();

                if (columnsConfiguration != null)
                    ApplyConfigurations(column, columnDefinition, columnsConfiguration);

                columnDefinitionMutationAction(column, columnDefinition);

                internalColmuns.GridColumns.Add(columnDefinition);
            }

            this.dataGrid.Columns = internalColmuns;

            return this;
        }

        private void ApplyConfigurations(KeyValuePair<string, object> column, ColumnDefinition columnDefinition, IColumnConfiguration[] columnsConfiguration)
        {
            foreach (IColumnConfiguration configuration in columnsConfiguration)
                configuration.ApplyConfigurations(column, columnDefinition);
        }

        public DxDataGridBuilder WithExportation(string fileName = "")
        {
            this.dataGrid.Export = new Exports.Export(fileName);
            return this;
        }

        public DxDataGridBuilder WithFilters(DataGridFilterTypes filterTypesFlags)
        {
            if ((filterTypesFlags & DataGridFilterTypes.FilterPanel) == DataGridFilterTypes.FilterPanel)
                this.dataGrid.FilterPanel = new Filters.FilterPanel();

            if ((filterTypesFlags & DataGridFilterTypes.FilterRow) == DataGridFilterTypes.FilterRow)
                this.dataGrid.FilterRow = new Filters.FilterRow();

            if ((filterTypesFlags & DataGridFilterTypes.HeaderFilter) == DataGridFilterTypes.HeaderFilter)
                this.dataGrid.HeaderFilter = new Filters.HeaderFilter();

            return this;
        }

        public DxDataGridBuilder WithSearch()
        {
            this.dataGrid.SearchPanel = new Search.SearchPanel();
            return this;
        }

        public DxDataGridBuilder WithPagination()
        {
            this.dataGrid.Pager = new Pagination.Pager() { ShowPageSizeSelector = true, ShowNavigationButtons = true };
            this.dataGrid.Paging = new Pagination.Paging();
            return this;
        }

        public DxDataGridBuilder WithSelection()
        {
            this.dataGrid.Selection = new Selections.Selection();
            return this;
        }

        public DxDataGridBuilder WithSorting()
        {
            this.dataGrid.Sorting = new Sorts.Sorting();
            return this;
        }

        public DxDataGridBuilder WithSummary(Summaries.Summary summary)
        {
            this.dataGrid.Summary = summary;
            return this;
        }

        public DxDataGridBuilder WithStateStore(string type, string storageKey)
        {
            this.dataGrid.StateStoring = new State.StateStoring() { Type = type, StorageKey = storageKey };
            return this;
        }
        public DxDataGridBuilder WithColumnChooser()
        {
            this.dataGrid.ColumnChooser = new Column.ColumnChooser();
            return this;
        }

        public DxDataGridBuilder WithColumnFixing()
        {
            this.dataGrid.ColumnFixing = new Column.ColumnFixing();
            return this;
        }

        public DxDataGridBuilder WithInvisibleColumns()
        {
            return this;
        }

        public DxDataGrid Build()
        {
            ApplyAjusts();
            return this.dataGrid;
        }


        private void ApplyAjusts()
        {
            this.dataGrid.Export.AllowExportSelectedData = this.dataGrid.Selection != null && this.dataGrid.Selection.Mode.Equals(Selections.Selection.SelectionTypes.Multiple.Value); ;
        }


        [Flags]
        public enum DataGridFilterTypes
        {
            FilterPanel = 1,
            FilterRow = 2,
            HeaderFilter = 4,
            All = FilterPanel | FilterRow | HeaderFilter
        }
    }
}
