using Nampula;
using Nampula.Framework;
using NampulaDI.Repository;
using NampulaDI;
using System;
using System.Runtime.InteropServices;
using Nampula.UI;

namespace NampulaUI
{
    public partial class Tabela : Form
    {
        //public Repositorio repositorio = new Repositorio();
        public Gatos novoGato = new Gatos();
        IRepositorio repositorio;
        public Tabela(IRepositorio repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
            AtualizarTabela();
        }

        public void AtualizarTabela()
        {

            try
            {
                dataGridViewTabela.DataSource = null;
                dataGridViewTabela.DataSource = repositorio.ObterTodos();
            }
            catch (Exception ex)
            {
                mostrarMensagemExcecao(ex);
            }
        }

        private void aoClicarEditar(object sender, EventArgs e)
        {
            try
            {
                preencherCamposComValores(novoGato);
                AtualizarTabela();
            }
            catch (Exception ex)
            {
                mostrarMensagemExcecao(ex);
            }
        }

        private void aoClicarSalvar(object sender, EventArgs e)
        {
            try
            {
                verificarSeEditaOuCria(novoGato);
                AtualizarTabela();
            }
            catch (Exception ex)
            {
                mostrarMensagemExcecao(ex);
            }
        }

        private void aoClicarRemover(object sender, EventArgs e)
        {
            try
            {
                var idgatoRemover = pegarIdObjetoSelecionado();
                repositorio.Remover(idgatoRemover);
                AtualizarTabela();
            }
            catch (Exception ex)
            {
                mostrarMensagemExcecao(ex);
            }
        }

        public int gerarId()
        {
            int id = 1;

            try
            {
                return id++;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void verificarSeEditaOuCria(Gatos gato)
        {
            try
            {
                Validacoes.Validar(textBoxNomeGato.Text, textBoxIdadeGato.Text);

                obterValoresDosCampos();

                if (gato.Id == 0)
                {

                    gato.Id = gerarId();
                    adicionarDadosGato();

                }
                else
                {
                    AtualizarDadosGato();
                }
            }
            catch (Exception ex)
            {
                mostrarMensagemExcecao(ex);
            }
        }

        public void preencherCamposComValores(Gatos gato)
        {
            textBoxNomeGato.Text = gato.Name;
            textBoxIdadeGato.Text = gato.Idade.ToString();
        }

        public void obterValoresDosCampos()
        {
            novoGato.Name = textBoxNomeGato.Text;
            novoGato.Idade = Convert.ToInt32(textBoxIdadeGato.Text);
        }

        public bool VerificarSelecaoDeLinhas()
        {

            if (dataGridViewTabela.SelectedRows.Count == 1)
            {

                return true;

            }
            else
            {

                return false;

            }

        }

        public int pegarIdObjetoSelecionado()
        {
            int idSelecionado = 0;

            if (VerificarSelecaoDeLinhas() == true)
            {

                idSelecionado = Convert.ToInt32(dataGridViewTabela.CurrentRow.Cells["Id"].Value);

            }

            return idSelecionado;
        }

        public Gatos obterObjetoPeloId()
        {
            try
            {
                var id = pegarIdObjetoSelecionado();
                var objeto = repositorio.ObterPorId(id);
                return objeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void adicionarDadosGato()
        {
            try
            {
                repositorio.Adicionar();
            }
            catch (Exception ex)
            {
                mostrarMensagemExcecao(ex);
            }
        }

        public void AtualizarDadosGato()
        {
            try
            {
                var gatoAtualizar = obterObjetoPeloId();
                repositorio.Editar(gatoAtualizar);
            }
            catch (Exception ex)
            {
                mostrarMensagemExcecao(ex);
            }
        }
        public void mostrarMensagemExcecao(Exception ex)
        {

            MessageBox(ex.Message + "\n\n" + ex.InnerException.ToString());

        }
    }
}
