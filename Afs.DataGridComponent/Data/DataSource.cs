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
		public DataSource(IDictionary<string, object> data)
        {
            this.Data = new ReadOnlyDictionary<string, object>(data);            
        }

        public IReadOnlyDictionary<string, object> Data { get; set; }   
    }
}
