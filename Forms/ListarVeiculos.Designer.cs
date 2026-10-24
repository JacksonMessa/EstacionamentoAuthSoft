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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeiculos)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
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
            this.dataGridVeiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridVeiculos.Location = new System.Drawing.Point(3, 91);
            this.dataGridVeiculos.Name = "dataGridVeiculos";
            this.dataGridVeiculos.ReadOnly = true;
            this.dataGridVeiculos.RowHeadersVisible = false;
            this.dataGridVeiculos.RowHeadersWidth = 51;
            this.dataGridVeiculos.RowTemplate.Height = 40;
            this.dataGridVeiculos.Size = new System.Drawing.Size(794, 356);
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
            this.btnVoltar.Size = new System.Drawing.Size(150, 48);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.btnVoltar, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.dataGridVeiculos, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeiculos)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
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
    }
}