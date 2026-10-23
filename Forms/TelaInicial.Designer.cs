namespace EstacionamentoAuthSoft
{
    partial class TelaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEstacionamento = new System.Windows.Forms.Label();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.BtnSaida = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.tableLayoutEstacionamento = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelVeiculos = new System.Windows.Forms.TableLayoutPanel();
            this.lblVeiculos = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutEstacionamento.SuspendLayout();
            this.tableLayoutPanelVeiculos.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEstacionamento
            // 
            this.tableLayoutEstacionamento.SetColumnSpan(this.lblEstacionamento, 3);
            this.lblEstacionamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstacionamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstacionamento.Location = new System.Drawing.Point(5, 0);
            this.lblEstacionamento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEstacionamento.Name = "lblEstacionamento";
            this.lblEstacionamento.Size = new System.Drawing.Size(1580, 213);
            this.lblEstacionamento.TabIndex = 0;
            this.lblEstacionamento.Text = "ESTACIONAMENTO";
            this.lblEstacionamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEntrada
            // 
            this.btnEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.Location = new System.Drawing.Point(105, 270);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(0);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(320, 98);
            this.btnEntrada.TabIndex = 0;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            // 
            // BtnSaida
            // 
            this.BtnSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaida.Location = new System.Drawing.Point(635, 270);
            this.BtnSaida.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSaida.Name = "BtnSaida";
            this.BtnSaida.Size = new System.Drawing.Size(320, 98);
            this.BtnSaida.TabIndex = 1;
            this.BtnSaida.Text = "Saida";
            this.BtnSaida.UseVisualStyleBackColor = true;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Location = new System.Drawing.Point(1165, 270);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(0);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(320, 98);
            this.btnConsulta.TabIndex = 2;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // tableLayoutEstacionamento
            // 
            this.tableLayoutEstacionamento.ColumnCount = 3;
            this.tableLayoutEstacionamento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutEstacionamento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutEstacionamento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutEstacionamento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutEstacionamento.Controls.Add(this.lblEstacionamento, 0, 0);
            this.tableLayoutEstacionamento.Controls.Add(this.btnEntrada, 0, 1);
            this.tableLayoutEstacionamento.Controls.Add(this.BtnSaida, 1, 1);
            this.tableLayoutEstacionamento.Controls.Add(this.btnConsulta, 2, 1);
            this.tableLayoutEstacionamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutEstacionamento.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutEstacionamento.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutEstacionamento.Name = "tableLayoutEstacionamento";
            this.tableLayoutEstacionamento.RowCount = 2;
            this.tableLayoutEstacionamento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutEstacionamento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutEstacionamento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutEstacionamento.Size = new System.Drawing.Size(1590, 426);
            this.tableLayoutEstacionamento.TabIndex = 2;
            // 
            // tableLayoutPanelVeiculos
            // 
            this.tableLayoutPanelVeiculos.ColumnCount = 2;
            this.tableLayoutPanelVeiculos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelVeiculos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelVeiculos.Controls.Add(this.lblVeiculos, 0, 0);
            this.tableLayoutPanelVeiculos.Controls.Add(this.btnCadastrar, 0, 1);
            this.tableLayoutPanelVeiculos.Controls.Add(this.btnListar, 1, 1);
            this.tableLayoutPanelVeiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelVeiculos.Location = new System.Drawing.Point(5, 441);
            this.tableLayoutPanelVeiculos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanelVeiculos.Name = "tableLayoutPanelVeiculos";
            this.tableLayoutPanelVeiculos.RowCount = 2;
            this.tableLayoutPanelVeiculos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelVeiculos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelVeiculos.Size = new System.Drawing.Size(1590, 427);
            this.tableLayoutPanelVeiculos.TabIndex = 3;
            // 
            // lblVeiculos
            // 
            this.tableLayoutPanelVeiculos.SetColumnSpan(this.lblVeiculos, 2);
            this.lblVeiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculos.Location = new System.Drawing.Point(5, 0);
            this.lblVeiculos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVeiculos.Name = "lblVeiculos";
            this.lblVeiculos.Size = new System.Drawing.Size(1580, 213);
            this.lblVeiculos.TabIndex = 0;
            this.lblVeiculos.Text = "VEÍCULOS";
            this.lblVeiculos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(158, 271);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(320, 98);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(779, 271);
            this.btnListar.Margin = new System.Windows.Forms.Padding(0);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(667, 98);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar/Editar/Excluir";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutEstacionamento, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelVeiculos, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1600, 873);
            this.tableLayoutPanelMain.TabIndex = 4;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 873);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "TelaInicial";
            this.Text = "Tela Inicial";
            this.tableLayoutEstacionamento.ResumeLayout(false);
            this.tableLayoutPanelVeiculos.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEstacionamento;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button BtnSaida;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutEstacionamento;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVeiculos;
        private System.Windows.Forms.Label lblVeiculos;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
    }
}

