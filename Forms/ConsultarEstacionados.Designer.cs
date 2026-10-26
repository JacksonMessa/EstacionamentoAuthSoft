namespace EstacionamentoAuthSoft.Forms
{
    partial class ConsultarEstacionados
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnRecarregar = new System.Windows.Forms.Button();
            this.dataGridVeiculos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permanencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botoesSaida = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.btnVoltar, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.btnRecarregar, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.dataGridVeiculos, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(1184, 358);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // btnVoltar
            // 
            this.btnVoltar.AutoSize = true;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(11, 13);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(11, 13, 0, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 41);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecarregar.AutoSize = true;
            this.btnRecarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecarregar.Location = new System.Drawing.Point(1013, 13);
            this.btnRecarregar.Margin = new System.Windows.Forms.Padding(0, 13, 11, 4);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(160, 41);
            this.btnRecarregar.TabIndex = 10;
            this.btnRecarregar.Text = "Recarregar";
            this.btnRecarregar.UseVisualStyleBackColor = true;
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
            this.entrada,
            this.permanencia,
            this.valorAtual,
            this.botoesSaida});
            this.tableLayoutPanel.SetColumnSpan(this.dataGridVeiculos, 2);
            this.dataGridVeiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridVeiculos.Location = new System.Drawing.Point(1, 59);
            this.dataGridVeiculos.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dataGridVeiculos.Name = "dataGridVeiculos";
            this.dataGridVeiculos.ReadOnly = true;
            this.dataGridVeiculos.RowHeadersVisible = false;
            this.dataGridVeiculos.RowHeadersWidth = 51;
            this.dataGridVeiculos.RowTemplate.Height = 40;
            this.dataGridVeiculos.Size = new System.Drawing.Size(1182, 298);
            this.dataGridVeiculos.TabIndex = 0;
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
            // entrada
            // 
            this.entrada.HeaderText = "Entrada";
            this.entrada.MinimumWidth = 6;
            this.entrada.Name = "entrada";
            this.entrada.ReadOnly = true;
            // 
            // permanencia
            // 
            this.permanencia.HeaderText = "Permanência";
            this.permanencia.MinimumWidth = 6;
            this.permanencia.Name = "permanencia";
            this.permanencia.ReadOnly = true;
            // 
            // valorAtual
            // 
            this.valorAtual.HeaderText = "Valor Atual";
            this.valorAtual.MinimumWidth = 6;
            this.valorAtual.Name = "valorAtual";
            this.valorAtual.ReadOnly = true;
            // 
            // botoesSaida
            // 
            this.botoesSaida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.botoesSaida.HeaderText = " ";
            this.botoesSaida.MinimumWidth = 6;
            this.botoesSaida.Name = "botoesSaida";
            this.botoesSaida.ReadOnly = true;
            this.botoesSaida.Text = "Saida";
            this.botoesSaida.UseColumnTextForButtonValue = true;
            this.botoesSaida.Width = 29;
            // 
            // ConsultarEstacionados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 358);
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "ConsultarEstacionados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Veículos Estacionados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dataGridVeiculos;
        private System.Windows.Forms.Button btnRecarregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn permanencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorAtual;
        private System.Windows.Forms.DataGridViewButtonColumn botoesSaida;
    }
}