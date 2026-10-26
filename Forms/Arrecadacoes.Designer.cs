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
            this.dataGridVeiculos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permanencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePickerFiltro = new System.Windows.Forms.DateTimePicker();
            this.lblTotal = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel.Controls.Add(this.dataGridVeiculos, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.datePickerFiltro, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lblTotal, 1, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(925, 596);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // btnVoltar
            // 
            this.btnVoltar.AutoSize = true;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(11, 13);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(11, 13, 0, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(112, 41);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
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
            this.saida,
            this.permanencia,
            this.valorAtual});
            this.tableLayoutPanel.SetColumnSpan(this.dataGridVeiculos, 2);
            this.dataGridVeiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridVeiculos.Location = new System.Drawing.Point(1, 60);
            this.dataGridVeiculos.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dataGridVeiculos.Name = "dataGridVeiculos";
            this.dataGridVeiculos.ReadOnly = true;
            this.dataGridVeiculos.RowHeadersVisible = false;
            this.dataGridVeiculos.RowHeadersWidth = 51;
            this.dataGridVeiculos.RowTemplate.Height = 40;
            this.dataGridVeiculos.Size = new System.Drawing.Size(923, 474);
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
            this.entrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.entrada.DataPropertyName = "entrada";
            this.entrada.HeaderText = "Entrada";
            this.entrada.MinimumWidth = 6;
            this.entrada.Name = "entrada";
            this.entrada.ReadOnly = true;
            this.entrada.Width = 144;
            // 
            // saida
            // 
            this.saida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.saida.DataPropertyName = "saida";
            this.saida.HeaderText = "Saida";
            this.saida.MinimumWidth = 6;
            this.saida.Name = "saida";
            this.saida.ReadOnly = true;
            this.saida.Width = 116;
            // 
            // permanencia
            // 
            this.permanencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.permanencia.DataPropertyName = "permanencia";
            this.permanencia.HeaderText = "Permanência";
            this.permanencia.MinimumWidth = 6;
            this.permanencia.Name = "permanencia";
            this.permanencia.ReadOnly = true;
            this.permanencia.Width = 213;
            // 
            // valorAtual
            // 
            this.valorAtual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.valorAtual.DataPropertyName = "valorAtual";
            this.valorAtual.HeaderText = "Valor Atual (R$)";
            this.valorAtual.MinimumWidth = 6;
            this.valorAtual.Name = "valorAtual";
            this.valorAtual.ReadOnly = true;
            this.valorAtual.Width = 160;
            // 
            // datePickerFiltro
            // 
            this.datePickerFiltro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.datePickerFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerFiltro.Location = new System.Drawing.Point(686, 4);
            this.datePickerFiltro.Margin = new System.Windows.Forms.Padding(1, 1, 11, 1);
            this.datePickerFiltro.Name = "datePickerFiltro";
            this.datePickerFiltro.Size = new System.Drawing.Size(228, 50);
            this.datePickerFiltro.TabIndex = 10;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(713, 543);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(204, 44);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total: R$0";
            // 
            // Arrecadacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 596);
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Arrecadacoes";
            this.Text = "Arrecadações";
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
        private System.Windows.Forms.DateTimePicker datePickerFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn permanencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorAtual;
        private System.Windows.Forms.Label lblTotal;
    }
}