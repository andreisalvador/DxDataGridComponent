using Afs.DataGridComponent.Column;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.Configuration.Column
{
    public class ColumnFormatConfiguration : IColumnConfiguration
    {
        public virtual void ApplyConfigurations(KeyValuePair<string, object> column, ColumnDefinition columnDefinition)
        {
            if (columnDefinition.DataType.Equals(ColumnDefinition.ColumnDataTypes.Number.Value))
                columnDefinition.Format = new ColumnFormat() { Type = ColumnFormat.FormatType.Currency.Value, Precision = 2 };
        }
    }
}
