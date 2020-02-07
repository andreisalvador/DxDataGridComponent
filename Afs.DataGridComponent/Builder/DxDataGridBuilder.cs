using Afs.DataGridComponent.Column;
using Afs.DataGridComponent.Column.Validation;
using Afs.DataGridComponent.Configuration;
using Afs.DataGridComponent.Configuration.Column;
using Afs.DataGridComponent.Data;
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
        private List<IColumnValidation> columnValidations;
        private List<IColumnConfiguration> columnConfigurations;
        public DxDataGridBuilder()
        {
            this.dataGrid = new DxDataGrid();
            this.columnValidations = new List<IColumnValidation>() { new DefaultColumnValidation() };
            this.columnConfigurations = new List<IColumnConfiguration>() { new ColumnDataTypeConfiguration(), new ColumnFormatConfiguration() };
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
            foreach (var column in columns)
            {
                ColumnDefinition columnDefinition = new ColumnDefinition();

                ConfigureColumn(columnsConfiguration, column, columnDefinition);

                columnDefinitionMutationAction(column, columnDefinition);

                ValidateColumn(columnDefinition);

                this.dataGrid.Columns.Add(columnDefinition);
            }

            return this;
        }

        private void ConfigureColumn(IColumnConfiguration[] columnsConfiguration, KeyValuePair<string, object> column, ColumnDefinition columnDefinition)
        {
            foreach (IColumnConfiguration configuration in columnsConfiguration)
                configuration.ApplyConfigurations(column, columnDefinition);
        }

        private void ValidateColumn(ColumnDefinition columnDefinition)
        {
            foreach (IColumnValidation columnValidation in columnValidations)
                columnValidation.Validate(columnDefinition);
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

        public DxDataGridBuilder WithInvisibleColumns(string[] dataFields)
        {
            dataFields.ToList().ForEach(field => this.dataGrid.Columns.SingleOrDefault(column => column.DataField.Equals(field)).Visible = false);
            return this;
        }

        public DxDataGridBuilder WithDataSource(DataSource dataSource)
        {
            this.dataGrid.DataSource = dataSource.Data;
            return this;
        }

        public DxDataGridBuilder WithColumnValidations(params IColumnValidation[] columnValidation)
        {
            this.columnValidations.AddRange(columnValidation);
            return this;
        }

        public DxDataGridBuilder WithColumnConfigurations(params IColumnConfiguration[] columnValidation)
        {
            this.columnConfigurations.AddRange(columnValidation);
            return this;
        }

        public DxDataGrid Build()
        {
            ApplyAjusts();
            return this.dataGrid;
        }


        private void ApplyAjusts()
        {
            this.dataGrid.Export.AllowExportSelectedData = this.dataGrid.Selection != null && this.dataGrid.Selection.Mode.Equals(Selections.Selection.SelectionTypes.Multiple.Value);
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
