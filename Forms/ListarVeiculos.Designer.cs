namespace EstacionamentoAuthSoft.Forms
{
    partial class ListarVeiculos
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
            this.dataGridVeiculos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botoesEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.botoesExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeiculos)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanelFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridVeiculos
            // 
            this.dataGridVeiculos.AllowUserToAddRows = false;
            this.dataGridVeiculos.AllowUserToDeleteRows = false;
            this.dataGridVeiculos.AllowUserToOrderColumns = true;
            this.dataGridVeiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.placa,
            this.modelo,
            this.cor,
            this.botoesEditar,
            this.botoesExcluir});
            this.tableLayoutPanel.SetColumnSpan(this.dataGridVeiculos, 2);
            this.dataGridVeiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridVeiculos.Location = new System.Drawing.Point(3, 115);
            this.dataGridVeiculos.Name = "dataGridVeiculos";
            this.dataGridVeiculos.ReadOnly = true;
            this.dataGridVeiculos.RowHeadersVisible = false;
            this.dataGridVeiculos.RowHeadersWidth = 51;
            this.dataGridVeiculos.RowTemplate.Height = 40;
            this.dataGridVeiculos.Size = new System.Drawing.Size(794, 332);
            this.dataGridVeiculos.TabIndex = 0;
            this.dataGridVeiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridVeiculos_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // placa
            // 
            this.placa.DataPropertyName = "placa";
            this.placa.HeaderText = "Placa";
            this.placa.MinimumWidth = 6;
            this.placa.Name = "placa";
            this.placa.ReadOnly = true;
            // 
            // modelo
            // 
            this.modelo.DataPropertyName = "modelo";
            this.modelo.HeaderText = "Modelo";
            this.modelo.MinimumWidth = 6;
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            // 
            // cor
            // 
            this.cor.DataPropertyName = "cor";
            this.cor.HeaderText = "Cor";
            this.cor.MinimumWidth = 6;
            this.cor.Name = "cor";
            this.cor.ReadOnly = true;
            // 
            // botoesEditar
            // 
            this.botoesEditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.botoesEditar.HeaderText = "";
            this.botoesEditar.MinimumWidth = 6;
            this.botoesEditar.Name = "botoesEditar";
            this.botoesEditar.ReadOnly = true;
            this.botoesEditar.Text = " Editar";
            this.botoesEditar.UseColumnTextForButtonValue = true;
            this.botoesEditar.Width = 6;
            // 
            // botoesExcluir
            // 
            this.botoesExcluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.botoesExcluir.HeaderText = " ";
            this.botoesExcluir.MinimumWidth = 6;
            this.botoesExcluir.Name = "botoesExcluir";
            this.botoesExcluir.ReadOnly = true;
            this.botoesExcluir.Text = "Excluir";
            this.botoesExcluir.UseColumnTextForButtonValue = true;
            this.botoesExcluir.Width = 34;
            // 
            // btnVoltar
            // 
            this.btnVoltar.AutoSize = true;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(30, 30);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(30, 30, 0, 10);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(112, 48);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33555F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66445F));
            this.tableLayoutPanel.Controls.Add(this.btnVoltar, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelFiltros, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.dataGridVeiculos, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // tableLayoutPanelFiltros
            // 
            this.tableLayoutPanelFiltros.ColumnCount = 2;
            this.tableLayoutPanelFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelFiltros.Controls.Add(this.lblPlaca, 0, 0);
            this.tableLayoutPanelFiltros.Controls.Add(this.txtPlaca, 1, 0);
            this.tableLayoutPanelFiltros.Controls.Add(this.lblModelo, 0, 1);
            this.tableLayoutPanelFiltros.Controls.Add(this.txtModelo, 1, 1);
            this.tableLayoutPanelFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFiltros.Location = new System.Drawing.Point(269, 3);
            this.tableLayoutPanelFiltros.Name = "tableLayoutPanelFiltros";
            this.tableLayoutPanelFiltros.RowCount = 2;
            this.tableLayoutPanelFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFiltros.Size = new System.Drawing.Size(528, 106);
            this.tableLayoutPanelFiltros.TabIndex = 12;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(3, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(112, 42);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(150, 3);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(500, 49);
            this.txtPlaca.TabIndex = 1;
            this.txtPlaca.TextChanged += new System.EventHandler(this.TxtPlaca_TextChanged);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(3, 53);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(141, 42);
            this.lblModelo.TabIndex = 0;
            this.lblModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(150, 56);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(500, 49);
            this.txtModelo.TabIndex = 1;
            this.txtModelo.TextChanged += new System.EventHandler(this.TxtModelo_TextChanged);
            // 
            // ListarVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "ListarVeiculos";
            this.Text = "Lista de Veículos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListarVeiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeiculos)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanelFiltros.ResumeLayout(false);
            this.tableLayoutPanelFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVeiculos;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cor;
        private System.Windows.Forms.DataGridViewButtonColumn botoesEditar;
        private System.Windows.Forms.DataGridViewButtonColumn botoesExcluir;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFiltros;
    }
}