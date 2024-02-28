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
                MostrarMensagemExcecao(ex);
            }
        }

        public int ObterIdLinhaSelecionada()
        {
            const int minimoDeLinhasSelecionadas = 1;
            bool possuiLinhaSelecionada = dataGridViewTabela.SelectedRows.Count == minimoDeLinhasSelecionadas;
            int idSelecionado = 0;

            if (possuiLinhaSelecionada)
            {
                idSelecionado = Convert.ToInt32(dataGridViewTabela.CurrentRow.Cells["Id"].Value);
            }

            return idSelecionado;
        }

        public Gatos ObterObjetoPeloId()
        {
            try
            {
                var id = ObterIdLinhaSelecionada();
                var objeto = repositorio.ObterPorId(id);
                return objeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AoClicarAdicionar(object sender, EventArgs e)
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
                MostrarMensagemExcecao(ex);
            }

        }

        private void AoClicarEditar(object sender, EventArgs e)
        {
            try
            {
                var gatoEditar = ObterObjetoPeloId();
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
                MostrarMensagemExcecao(ex);
            }
        }

        private void AoClicarRemover(object sender, EventArgs e)
        {
            try
            {
                var confirmarCancelamento = MessageBox(Mensagens.perguntaRemoverGato, MessageBoxButtons.YesNo);

                if (confirmarCancelamento == DialogResult.Yes)
                {
                    var idGatoRemover = ObterIdLinhaSelecionada();
                    repositorio.Remover(idGatoRemover);
                    AtualizarTabela();

                    MessageBox(Mensagens.confirmacaoGatoRemovido);
                }
            }
            catch (Exception ex)
            {
                MostrarMensagemExcecao(ex);
            }
        }

        public void MostrarMensagemExcecao(Exception ex)
        {
            MessageBox(ex.Message + "\n\n" + ex.InnerException.ToString());
        }
    }
}
