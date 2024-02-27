using Nampula.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NampulaDI.Factory
{
    public class DBNampula : DataBaseAdapter
    {
        public static readonly DBNampula Instance = new DBNampula();

        public DBNampula()
        {
            DataBaseName = Properties.Resources.DataBaseName;
            Assembly = Assembly.GetExecutingAssembly();
        }

        public new static TT CreateObject<TT>() where TT : DataObject, new()
        {
            var newObject = new TT
            {
                DBName = Instance.DataBaseName
            };

            return newObject;
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
