using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NampulaDI
{
    public class Validacoes
    {
        public static List<string> Validar(string Nome, string Idade)
        {
            List<string> mensagensDeErro = new List<string>();

            if (string.IsNullOrEmpty(Nome))
            {
                mensagensDeErro.Add(Mensagens.mensagemErroNomeVazio);
            }

            if (string.IsNullOrEmpty(Idade))
            {
                mensagensDeErro.Add(Mensagens.mensagemErroIdadeVazia);
            }

            if (mensagensDeErro.Any())
            {
                var sb = new StringBuilder();
                foreach (var erro in mensagensDeErro)
                {
                    sb.Append(erro);
                }
                throw new Exception(sb.ToString());
            }
            return mensagensDeErro;
        }
    }
}
