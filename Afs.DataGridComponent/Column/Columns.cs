using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.Column
{
    public class Columns
    {
        public Columns()
        {
            this.GridColumns = new List<ColumnDefinition>();
        }
        public List<ColumnDefinition> GridColumns { get; set; }
    }
}
