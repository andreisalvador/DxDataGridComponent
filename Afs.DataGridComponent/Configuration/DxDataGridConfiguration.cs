using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.Configuration
{
    public class DxDataGridConfiguration
    {
        public bool ShowBorders { get; set; }
        public bool RemoteOperations { get; set; }
        public bool AllowColumnReordering { get; set; }
        public bool AllowColumnResizing { get; set; }
        public bool RowAlternationEnabled { get; set; }
        public bool ColumnAutoWidth { get; set; }
        public bool FocusedRowEnabled { get; set; }
    }
}
