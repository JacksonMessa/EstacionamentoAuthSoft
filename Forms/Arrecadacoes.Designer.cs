namespace EstacionamentoAuthSoft.Forms
{
    partial class Arrecadacoes
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
            this.dataGridArrecadacoes = new System.Windows.Forms.DataGridView();
            this.datePickerFiltro = new System.Windows.Forms.DateTimePicker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permanencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArrecadacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.btnVoltar, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.dataGridArrecadacoes, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.datePickerFiltro, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lblTotal, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.btnExportar, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1924, 1055);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // btnVoltar
            // 
            this.btnVoltar.AutoSize = true;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(29, 31);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(29, 31, 0, 10);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(299, 64);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // dataGridArrecadacoes
            // 
            this.dataGridArrecadacoes.AllowUserToAddRows = false;
            this.dataGridArrecadacoes.AllowUserToDeleteRows = false;
            this.dataGridArrecadacoes.AllowUserToOrderColumns = true;
            this.dataGridArrecadacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridArrecadacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArrecadacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placa,
            this.modelo,
            this.entrada,
            this.saida,
            this.permanencia,
            this.valor});
            this.tableLayoutPanel.SetColumnSpan(this.dataGridArrecadacoes, 2);
            this.dataGridArrecadacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridArrecadacoes.Location = new System.Drawing.Point(3, 107);
            this.dataGridArrecadacoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridArrecadacoes.Name = "dataGridArrecadacoes";
            this.dataGridArrecadacoes.ReadOnly = true;
            this.dataGridArrecadacoes.RowHeadersVisible = false;
            this.dataGridArrecadacoes.RowHeadersWidth = 51;
            this.dataGridArrecadacoes.RowTemplate.Height = 40;
            this.dataGridArrecadacoes.Size = new System.Drawing.Size(1918, 840);
            this.dataGridArrecadacoes.TabIndex = 0;
            // 
            // datePickerFiltro
            // 
            this.datePickerFiltro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.datePickerFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerFiltro.Location = new System.Drawing.Point(1294, 22);
            this.datePickerFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 29, 2);
            this.datePickerFiltro.Name = "datePickerFiltro";
            this.datePickerFiltro.Size = new System.Drawing.Size(601, 61);
            this.datePickerFiltro.TabIndex = 10;
            this.datePickerFiltro.ValueChanged += new System.EventHandler(this.DatePickerFiltro_ValueChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1655, 975);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(3, 0, 21, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(248, 54);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total: R$0";
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExportar.AutoSize = true;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(31, 970);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(31, 3, 3, 3);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(425, 64);
            this.btnExportar.TabIndex = 12;
            this.btnExportar.Text = "Exportar para CSV";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
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
            this.entrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.entrada.DataPropertyName = "entrada";
            this.entrada.HeaderText = "Entrada";
            this.entrada.MinimumWidth = 6;
            this.entrada.Name = "entrada";
            this.entrada.ReadOnly = true;
            this.entrada.Width = 178;
            // 
            // saida
            // 
            this.saida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.saida.DataPropertyName = "saida";
            this.saida.HeaderText = "Saida";
            this.saida.MinimumWidth = 6;
            this.saida.Name = "saida";
            this.saida.ReadOnly = true;
            this.saida.Width = 143;
            // 
            // permanencia
            // 
            this.permanencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.permanencia.DataPropertyName = "permanencia";
            this.permanencia.HeaderText = "Permanência";
            this.permanencia.MinimumWidth = 6;
            this.permanencia.Name = "permanencia";
            this.permanencia.ReadOnly = true;
            this.permanencia.Width = 267;
            // 
            // valor
            // 
            this.valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.valor.DataPropertyName = "valor";
            this.valor.HeaderText = "Valor (R$)";
            this.valor.MinimumWidth = 6;
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 216;
            // 
            // Arrecadacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Arrecadacoes";
            this.Text = "Arrecadações";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Arrecadacoes_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArrecadacoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dataGridArrecadacoes;
        private System.Windows.Forms.DateTimePicker datePickerFiltro;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn permanencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
    }
}