using Afs.DataGridComponent.Column;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afs.DataGridComponent.Configuration.Column
{
    public class ColumnDataTypeConfiguration : IColumnConfiguration
    {
        private IDictionary<Type, string> formats;

        public ColumnDataTypeConfiguration()
        {
            this.formats = new Dictionary<Type, string>();
        }

        public void AddTextType(Type type)
        {
            AddDataType(type, ColumnDefinition.ColumnDataTypes.Text.Value);
        }
        public void AddTextType(Type[] types)
        {
            types.ToList().ForEach(type => AddTextType(type));
        }

        public void AddDateType(Type type)
        {
            AddDataType(type, ColumnDefinition.ColumnDataTypes.Date.Value);
        }

        public void AddDateType(Type[] types)
        {
            types.ToList().ForEach(type => AddDateType(type));
        }

        public void AddNumberType(Type type)
        {
            AddDataType(type, ColumnDefinition.ColumnDataTypes.Number.Value);
        }

        public void AddNumberType(Type[] types)
        {
            types.ToList().ForEach(type => AddNumberType(type));
        }

        public string GetDataType(Type type)
        {
            return this.formats[type];
        }

        private void AddDataType(Type type, string typeValue)
        {
            if (!this.formats.ContainsKey(type))
                this.formats.Add(type, typeValue);
        }

        public void ApplyConfigurations(KeyValuePair<string, object> column, ColumnDefinition columnDefinition)
        {
            columnDefinition.DataType = GetDataType(column.Value.GetType());
        }
    }
}
