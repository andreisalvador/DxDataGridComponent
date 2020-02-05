using Afs.DataGridComponent.Column;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.Configuration.Column
{
    public interface IColumnConfiguration
    {
        void ApplyConfigurations(KeyValuePair<string, object> column, ColumnDefinition columnDefinition);
    }
}
