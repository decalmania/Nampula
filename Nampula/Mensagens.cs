using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NampulaDI
{
    public static class Mensagens
    {
        public static readonly string erroObterTodos = "Erro ao obter dados do banco de dados";

        public static readonly string erroObterPorId = "Erro ao obter dados pelo Id";

        public static readonly string erroAdicionar = "Erro ao adicionar novos dados";

        public static readonly string erroEditar = "Erro ao editar dados selecionados";

        public static readonly string erroRemover = "Erro ao remover dados selecionados";

        public static readonly string mensagemErroNomeVazio = "É necessário informar o nome do gato";

        public static readonly string mensagemErroIdadeVazia = "É necessário informar a idade do gato";

        public static readonly string mensagemErroNomeInvalido = "O nome do gato deve conter apenas letras";

        public static readonly string mensagemErroIdadeInvalida = "A idade do gato deve conter apenas números";
    }
}
