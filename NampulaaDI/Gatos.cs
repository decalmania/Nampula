
using Nampula.DI;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NampulaDI
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
            public static readonly string Idade = "Idade";
        }

        public struct FieldsDescription
        {
            public static readonly string Id = "Id";
            public static readonly string Name = "Nome do gato";
            public static readonly string Idade = "Idade do Gato";
        }

        TableAdapterField _Id = new TableAdapterField(FieldsName.Id, FieldsDescription.Id, DbType.Int32, 11, 0, true, true);
        TableAdapterField _Name = new TableAdapterField(FieldsName.Name, FieldsDescription.Name, 200);
        TableAdapterField _Idade = new TableAdapterField(FieldsName.Idade, FieldsDescription.Idade, DbType.Int32);

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

        public int Idade
        {
            get { return _Idade.GetInt32(); }
            set { _Idade.Value = value; }
        }
    }
}
