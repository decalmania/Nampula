using NampulaDI;
using System;
using System.Windows.Forms;

namespace NampulaUI
{
    public partial class Cadastro : Nampula.UI.Form
    {
        public Gatos novoGato = new Gatos();
        public Cadastro(Gatos gato = null)
        {
            InitializeComponent();

            if (gato != null)
            {
                preencherCamposComValores(gato);
                novoGato = gato;
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

                    novoGato.Id = gerarId();

                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox(ex.Message);
            }
        }

        private void aoClicarSalvar(object sender, EventArgs e)
        {
            verificarSeEditaOuCria(novoGato);
        }

        public void aoClicarCancelar(object sender, EventArgs e)
        {

            var confirmarCancelamento = MessageBox(Mensagens.perguntaFecharAba, MessageBoxButtons.YesNo);

            if (confirmarCancelamento == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void aoInserirNomeGato(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void aoInserirIdadeGato(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
                base.OnKeyPress(e);

            }
        }
    }
}
