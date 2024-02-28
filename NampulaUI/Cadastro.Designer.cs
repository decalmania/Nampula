namespace NampulaUI
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNomeGato = new System.Windows.Forms.Label();
            this.labelIdadeGato = new System.Windows.Forms.Label();
            this.textBoxNomeGato = new System.Windows.Forms.TextBox();
            this.textBoxIdadeGato = new System.Windows.Forms.TextBox();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomeGato
            // 
            this.labelNomeGato.AutoSize = true;
            this.labelNomeGato.Location = new System.Drawing.Point(45, 82);
            this.labelNomeGato.Name = "labelNomeGato";
            this.labelNomeGato.Size = new System.Drawing.Size(74, 13);
            this.labelNomeGato.TabIndex = 0;
            this.labelNomeGato.Text = "Nome do gato";
            // 
            // labelIdadeGato
            // 
            this.labelIdadeGato.AutoSize = true;
            this.labelIdadeGato.Location = new System.Drawing.Point(44, 191);
            this.labelIdadeGato.Name = "labelIdadeGato";
            this.labelIdadeGato.Size = new System.Drawing.Size(75, 13);
            this.labelIdadeGato.TabIndex = 1;
            this.labelIdadeGato.Text = "Idade do gato";
            // 
            // textBoxNomeGato
            // 
            this.textBoxNomeGato.Location = new System.Drawing.Point(47, 111);
            this.textBoxNomeGato.Name = "textBoxNomeGato";
            this.textBoxNomeGato.Size = new System.Drawing.Size(263, 20);
            this.textBoxNomeGato.TabIndex = 2;
            this.textBoxNomeGato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AoInserirNomeGato);
            // 
            // textBoxIdadeGato
            // 
            this.textBoxIdadeGato.Location = new System.Drawing.Point(46, 216);
            this.textBoxIdadeGato.Name = "textBoxIdadeGato";
            this.textBoxIdadeGato.Size = new System.Drawing.Size(263, 20);
            this.textBoxIdadeGato.TabIndex = 3;
            this.textBoxIdadeGato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AoInserirIdadeGato);
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Location = new System.Drawing.Point(153, 324);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(75, 23);
            this.botaoSalvar.TabIndex = 4;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.AoClicarSalvar);
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Location = new System.Drawing.Point(234, 324);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.botaoCancelar.TabIndex = 5;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            this.botaoCancelar.Click += new System.EventHandler(this.AoClicarCancelar);
            // 
            // Cadastro
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.textBoxIdadeGato);
            this.Controls.Add(this.textBoxNomeGato);
            this.Controls.Add(this.labelIdadeGato);
            this.Controls.Add(this.labelNomeGato);
            this.IconOptions.ShowIcon = false;
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeGato;
        private System.Windows.Forms.Label labelIdadeGato;
        private System.Windows.Forms.TextBox textBoxNomeGato;
        private System.Windows.Forms.TextBox textBoxIdadeGato;
        private System.Windows.Forms.Button botaoSalvar;
        private System.Windows.Forms.Button botaoCancelar;
    }
}