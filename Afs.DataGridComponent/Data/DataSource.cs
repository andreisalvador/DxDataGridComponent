using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.Data
{
    public class DataSource
    {
        public DataSource(IList<IDictionary<string, object>> data)
        {
            this.Data = data;
        }

        public IList<IDictionary<string, object>> Data { get; private set; }
    }
}
