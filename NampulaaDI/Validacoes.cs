using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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
            else
            {
                var regex = "/^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]+$/";

                if (!Regex.IsMatch(Nome, regex)) {
                    mensagensDeErro.Add(Mensagens.mensagemErroNomeInvalido);
                }
            }

            if (string.IsNullOrEmpty(Idade))
            {
                mensagensDeErro.Add(Mensagens.mensagemErroIdadeVazia);
            }
            else
            {
                var regex = "^[0-9]+$";

                if(!Regex.IsMatch(Idade, regex))
                {
                    mensagensDeErro.Add(Mensagens.mensagemErroIdadeInvalida);
                }
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
