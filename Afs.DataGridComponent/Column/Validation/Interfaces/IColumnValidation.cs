using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.Column.Validation
{
    public interface IColumnValidation
    {
        void Validate(ColumnDefinition column);
    }
}
