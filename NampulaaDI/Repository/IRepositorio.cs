using Nampula.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NampulaDI.Repository
{
    public interface IRepositorio
    {
        List<Gatos> ObterTodos();

        Gatos ObterPorId(int id);

        void Adicionar();

        void Editar(Gatos gatoAtualizado);

        void Remover(int id);
    }
}
