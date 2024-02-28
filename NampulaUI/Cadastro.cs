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
                PreencherCamposComValores(gato);
                novoGato = gato;
            }
        }

        public void PreencherCamposComValores(Gatos gato)
        {
            textBoxNomeGato.Text = gato.Name;
            textBoxIdadeGato.Text = gato.Idade.ToString();
        }

        public void ObterValoresDosCampos()
        {
            novoGato.Name = textBoxNomeGato.Text;
            novoGato.Idade = Convert.ToInt32(textBoxIdadeGato.Text);
        }

        public int GerarId()
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

        public void VerificarSeEditaOuCria(Gatos gato)
        {
            try
            {
                Validacoes.Validar(textBoxNomeGato.Text, textBoxIdadeGato.Text);

                ObterValoresDosCampos();

                if (gato.Id == 0)
                {
                    novoGato.Id = GerarId();
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox(ex.Message);
            }
        }

        private void AoClicarSalvar(object sender, EventArgs e)
        {
            VerificarSeEditaOuCria(novoGato);
        }

        public void AoClicarCancelar(object sender, EventArgs e)
        {
            var confirmarCancelamento = MessageBox(Mensagens.perguntaFecharAba, MessageBoxButtons.YesNo);

            if (confirmarCancelamento == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void AoInserirNomeGato(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AoInserirIdadeGato(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }
    }
}
