using NampulaDI.Repository;
using NampulaDI;
using System;
using System.Windows.Forms;

namespace NampulaUI
{
    public partial class Tabela : Nampula.UI.Form
    {
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

        private void aoClicarAdicionar(object sender, EventArgs e)
        {
            try
            {
                var cadastro = new Cadastro(null);
                var resultadoCadastro = cadastro.ShowDialog();

                if (resultadoCadastro == DialogResult.OK)
                {
                    repositorio.Adicionar(cadastro.novoGato);
                    AtualizarTabela();

                    MessageBox(Mensagens.confirmacaoGatoAdicionado);
                }
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
                var gatoEditar = obterObjetoPeloId();
                Cadastro cadastro = new Cadastro(gatoEditar);
                var resultadoCadastro = cadastro.ShowDialog();

                if (resultadoCadastro == DialogResult.OK)
                {
                    repositorio.Editar(gatoEditar);
                    AtualizarTabela();

                    MessageBox(Mensagens.confirmacaoGatoAtualizado);
                }
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
                var confirmarCancelamento = MessageBox(Mensagens.perguntaRemoverGato, MessageBoxButtons.YesNo);

                if (confirmarCancelamento == DialogResult.Yes)
                {
                    var idgatoRemover = pegarIdObjetoSelecionado();
                    repositorio.Remover(idgatoRemover);
                    AtualizarTabela();

                    MessageBox(Mensagens.confirmacaoGatoRemovido);
                }
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
