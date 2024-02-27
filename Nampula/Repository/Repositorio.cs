using DevExpress.Map.Native;
using NampulaDI.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nampula.DI;
using NampulaDI.Repository;

namespace NampulaDI
{
    public class Repositorio : IRepositorio
    {
        public List<Gatos> ObterTodos()
        {
            try
            {
                var listaGatos = DBNampula.GetAll<Gatos>();
                return listaGatos.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(message: Mensagens.erroObterTodos, ex);
            }
        }

        public Gatos ObterPorId(int id)
        {
            try
            {
                var gato = DBNampula.GetByKey<Gatos>(id);
                return gato;
            }
            catch (Exception ex)
            {
                throw new Exception(message: Mensagens.erroObterPorId, ex);
            }
        }

        public void Adicionar()
        {
            try
            {
                var gatoAdicionar = DBNampula.CreateObject<Gatos>();
                gatoAdicionar.Add();
            }
            catch (Exception ex)
            {
                throw new Exception(message: Mensagens.erroAdicionar, ex);
            }
        }

        public void Editar(Gatos gatoAtualizado)
        {
            try
            {
                //var gato = ObterPorId(gatoAtualizado.Id);
                gatoAtualizado.Update();
            }
            catch (Exception ex)
            {
                throw new Exception(message: Mensagens.erroEditar, ex);
            }
        }

        public void Remover(int id)
        {
            try
            {
                var gatoRemover = ObterPorId(id);
                gatoRemover.Remove();
            }
            catch (Exception ex)
            { 
                throw new Exception(message: Mensagens.erroRemover, ex);
            }
        }
    }
}
