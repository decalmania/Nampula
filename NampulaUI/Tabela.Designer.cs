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
            this.botaoRemover = new System.Windows.Forms.Button();
            this.botaoAdicionar = new System.Windows.Forms.Button();
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
            // botaoRemover
            // 
            this.botaoRemover.Location = new System.Drawing.Point(343, 338);
            this.botaoRemover.Name = "botaoRemover";
            this.botaoRemover.Size = new System.Drawing.Size(75, 21);
            this.botaoRemover.TabIndex = 13;
            this.botaoRemover.Text = "Remover";
            this.botaoRemover.UseVisualStyleBackColor = true;
            this.botaoRemover.Click += new System.EventHandler(this.aoClicarRemover);
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.Location = new System.Drawing.Point(181, 338);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(75, 21);
            this.botaoAdicionar.TabIndex = 16;
            this.botaoAdicionar.Text = "Adicionar";
            this.botaoAdicionar.UseVisualStyleBackColor = true;
            this.botaoAdicionar.Click += new System.EventHandler(this.aoClicarAdicionar);
            // 
            // botaoEditar
            // 
            this.botaoEditar.Location = new System.Drawing.Point(262, 338);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(75, 21);
            this.botaoEditar.TabIndex = 17;
            this.botaoEditar.Text = "Editar";
            this.botaoEditar.UseVisualStyleBackColor = true;
            this.botaoEditar.Click += new System.EventHandler(this.aoClicarEditar);
            // 
            // Tabela
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 385);
            this.Controls.Add(this.botaoEditar);
            this.Controls.Add(this.botaoAdicionar);
            this.Controls.Add(this.botaoRemover);
            this.Controls.Add(this.dataGridViewTabela);
            this.IconOptions.ShowIcon = false;
            this.Name = "Tabela";
            this.Text = "Gatos";
            ((System.ComponentModel.ISupportInitialize)(this.dashboardBarAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.DashboardWin.Native.DashboardBarAndDockingController dashboardBarAndDockingController1;
        private System.Windows.Forms.DataGridView dataGridViewTabela;
        private System.Windows.Forms.Button botaoRemover;
        private System.Windows.Forms.Button botaoAdicionar;
        private System.Windows.Forms.Button botaoEditar;
    }
}