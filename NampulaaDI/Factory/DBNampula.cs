using Nampula.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NampulaDI.Factory
{
    public class DBNampula : DataBaseAdapter
    {
        public DBNampula() : base()
        {
            this.DataBaseName = Properties.Resources.DataBaseName;
            this.Assembly = Assembly.GetExecutingAssembly();
        }

        public new static T CreateObject<T>()
        {
            return CreateObject<T>(null);
        }

        public static T CreateObject<T>(Connection pConnection)
        {
            return new DBNampula().CreateBaseObject<T>(pConnection);
        }

        private T CreateBaseObject<T>(Connection pConnection)
        {
            return CreateObject<T>(pConnection);
        }

        public static List<t> GetAll<t>() where t : TableAdapter, new()
        {
            t myTable = CreateObject<t>();
            return myTable.FillCollection<t>(myTable.GetData().Rows);
        }

        public static t GetByKey<t>(int id) where t : TableAdapter, new()
        {
            t entity = CreateObject<t>();

            if (entity.KeyFields.Count > 1)
                throw new ArgumentOutOfRangeException("Quantidade de chaves primárias inválida");
            entity.KeyFields.First().Value = id;
            entity.GetByKey();
            return entity;
        }
    }

}
