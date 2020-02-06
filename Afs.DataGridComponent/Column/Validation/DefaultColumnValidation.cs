using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.Column.Validation
{
    public class DefaultColumnValidation : IColumnValidation
    {
        public void Validate(ColumnDefinition column)
        {
            string[] camposObrigatorios = { "DataType", "Caption", "Visible", "DataField" };

            foreach (string campo in camposObrigatorios)
            {
                if (column.GetType().GetProperty(campo).GetValue(column) == null)
                    throw new Exception(string.Format("{0} não pode ser nulo na definição da coluna", campo));
            }
        }
    }
}
