using Nampula.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace NampulaDI.Factory
{
    public class DBNampula : DataBaseAdapter
    {
        public DBNampula() : base()
        {
            DataBaseName = "SBO_INVENT_HOM";
            Assembly = Assembly.GetExecutingAssembly();

        }

        public new static t CreatObject<t>()
        {
            return CreatObject<t>(null);
        }

        public new static t CreatObject<t>(Connection pConnection)
        {
            return new DBNampula().CreateBaseObject<t>(pConnection);
        }

        private t CreateBaseObject<t>(Connection pConnection)
        {
            return base.CreateObject<t>(pConnection);
        }

        public static List<t> GetAll<t>() where t : TableAdapter, new()
        {
            t myTable = CreatObject<t>();
            return myTable.FillCollection<t>(myTable.GetData().Rows);
        }

        public static t GetByKey<t>(int id) where t : TableAdapter, new()
        {
            t entity = CreatObject<t>();

            if (entity.KeyFields.Count > 1)
                throw new ArgumentOutOfRangeException("Quantidade de chaves primarias invalida");
            entity.KeyFields.First().Value = id;
            entity.GetByKey();
            return entity;
        }
    }

}
