using DevExpress.ClipboardSource.SpreadsheetML;
using Nampula.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nampula
{
    public class Gatos : TableAdapter
    {
        public struct Definition
        {
            public static readonly string TableName = "Gatos";
        }

        public struct FieldsName
        {
            public static readonly string Id = "Id";
            public static readonly string Name = "Name";
        }

        public struct FieldsDescription
        {
            public static readonly string Id = "Id";
            public static readonly string Name = "Nome da raça do gato";
        }

        TableAdapterField _Id = new TableAdapterField(FieldsName.Id, FieldsDescription.Id, System.Data.DbType.Int32, 11, 0, true, true);
        TableAdapterField _Name = new TableAdapterField(FieldsName.Name, FieldsDescription.Name, 200);

        public Gatos() : base(Definition.TableName)
        {

        }

        public int Id
        {
            get { return _Id.GetInt32(); }
            set { _Id.Value = value; }
        }

        public string Name
        {
            get { return _Name.GetString(); }
            set { _Name.Value = value; }
        }
    }
}
