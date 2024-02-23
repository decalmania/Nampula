namespace NampulaUI
{
    partial class Tabela
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
            this.components = new System.ComponentModel.Container();
            this.dashboardBarAndDockingController1 = new DevExpress.DashboardWin.Native.DashboardBarAndDockingController(this.components);
            this.dataGridViewTabela = new System.Windows.Forms.DataGridView();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.labelNomeGato = new System.Windows.Forms.Label();
            this.textBoxNomeGato = new System.Windows.Forms.TextBox();
            this.labelIdadeGato = new System.Windows.Forms.Label();
            this.textBoxIdadeGato = new System.Windows.Forms.TextBox();
            this.botaoRemover = new System.Windows.Forms.Button();
            this.botaoEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardBarAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTabela
            // 
            this.dataGridViewTabela.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabela.Location = new System.Drawing.Point(62, 31);
            this.dataGridViewTabela.Name = "dataGridViewTabela";
            this.dataGridViewTabela.Size = new System.Drawing.Size(356, 301);
            this.dataGridViewTabela.TabIndex = 1;
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Location = new System.Drawing.Point(620, 250);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(75, 21);
            this.botaoSalvar.TabIndex = 7;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.aoClicarSalvar);
            // 
            // labelNomeGato
            // 
            this.labelNomeGato.AutoSize = true;
            this.labelNomeGato.Location = new System.Drawing.Point(500, 93);
            this.labelNomeGato.Name = "labelNomeGato";
            this.labelNomeGato.Size = new System.Drawing.Size(74, 13);
            this.labelNomeGato.TabIndex = 9;
            this.labelNomeGato.Text = "Nome do gato";
            // 
            // textBoxNomeGato
            // 
            this.textBoxNomeGato.Location = new System.Drawing.Point(503, 119);
            this.textBoxNomeGato.Name = "textBoxNomeGato";
            this.textBoxNomeGato.Size = new System.Drawing.Size(273, 20);
            this.textBoxNomeGato.TabIndex = 10;
            // 
            // labelIdadeGato
            // 
            this.labelIdadeGato.AutoSize = true;
            this.labelIdadeGato.Location = new System.Drawing.Point(500, 174);
            this.labelIdadeGato.Name = "labelIdadeGato";
            this.labelIdadeGato.Size = new System.Drawing.Size(75, 13);
            this.labelIdadeGato.TabIndex = 11;
            this.labelIdadeGato.Text = "Idade do gato";
            // 
            // textBoxIdadeGato
            // 
            this.textBoxIdadeGato.Location = new System.Drawing.Point(503, 198);
            this.textBoxIdadeGato.Name = "textBoxIdadeGato";
            this.textBoxIdadeGato.Size = new System.Drawing.Size(273, 20);
            this.textBoxIdadeGato.TabIndex = 12;
            // 
            // botaoRemover
            // 
            this.botaoRemover.Location = new System.Drawing.Point(701, 250);
            this.botaoRemover.Name = "botaoRemover";
            this.botaoRemover.Size = new System.Drawing.Size(75, 21);
            this.botaoRemover.TabIndex = 13;
            this.botaoRemover.Text = "Remover";
            this.botaoRemover.UseVisualStyleBackColor = true;
            this.botaoRemover.Click += new System.EventHandler(this.aoClicarRemover);
            // 
            // botaoEditar
            // 
            this.botaoEditar.Location = new System.Drawing.Point(295, 338);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(123, 21);
            this.botaoEditar.TabIndex = 15;
            this.botaoEditar.Text = "Editar";
            this.botaoEditar.UseVisualStyleBackColor = true;
            this.botaoEditar.Click += new System.EventHandler(this.aoClicarEditar);
            // 
            // Tabela
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 385);
            this.Controls.Add(this.botaoEditar);
            this.Controls.Add(this.botaoRemover);
            this.Controls.Add(this.textBoxIdadeGato);
            this.Controls.Add(this.labelIdadeGato);
            this.Controls.Add(this.textBoxNomeGato);
            this.Controls.Add(this.labelNomeGato);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.dataGridViewTabela);
            this.IconOptions.ShowIcon = false;
            this.Name = "Tabela";
            this.Text = "Gatos";
            ((System.ComponentModel.ISupportInitialize)(this.dashboardBarAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.DashboardWin.Native.DashboardBarAndDockingController dashboardBarAndDockingController1;
        private System.Windows.Forms.DataGridView dataGridViewTabela;
        private System.Windows.Forms.Button botaoSalvar;
        private System.Windows.Forms.Label labelNomeGato;
        private System.Windows.Forms.TextBox textBoxNomeGato;
        private System.Windows.Forms.Label labelIdadeGato;
        private System.Windows.Forms.TextBox textBoxIdadeGato;
        private System.Windows.Forms.Button botaoRemover;
        private System.Windows.Forms.Button botaoEditar;
    }
}