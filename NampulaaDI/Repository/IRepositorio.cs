using System.Collections.Generic;
namespace NampulaDI.Repository
{
    public interface IRepositorio
    {
        List<Gatos> ObterTodos();

        Gatos ObterPorId(int id);

        void Adicionar(Gatos gatoAdicionar);

        void Editar(Gatos gatoAtualizar);

        void Remover(int id);
    }
}
