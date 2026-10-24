namespace EstacionamentoAuthSoft.Forms
{
    partial class CadastroVeiculos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tableLayoutForm = new System.Windows.Forms.TableLayoutPanel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tableLayoutForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.tableLayoutForm.SetColumnSpan(this.lblTitulo, 3);
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(185, 111);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(811, 91);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro de Veículos";
            // 
            // tableLayoutForm
            // 
            this.tableLayoutForm.ColumnCount = 3;
            this.tableLayoutForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutForm.Controls.Add(this.btnVoltar, 0, 0);
            this.tableLayoutForm.Controls.Add(this.lblTitulo, 0, 1);
            this.tableLayoutForm.Controls.Add(this.lblPlaca, 0, 2);
            this.tableLayoutForm.Controls.Add(this.txtPlaca, 0, 3);
            this.tableLayoutForm.Controls.Add(this.lblModelo, 1, 2);
            this.tableLayoutForm.Controls.Add(this.txtModelo, 1, 3);
            this.tableLayoutForm.Controls.Add(this.lblCor, 2, 2);
            this.tableLayoutForm.Controls.Add(this.txtCor, 2, 3);
            this.tableLayoutForm.Controls.Add(this.btnSalvar, 0, 4);
            this.tableLayoutForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutForm.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutForm.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutForm.Name = "tableLayoutForm";
            this.tableLayoutForm.Padding = new System.Windows.Forms.Padding(30);
            this.tableLayoutForm.RowCount = 5;
            this.tableLayoutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutForm.Size = new System.Drawing.Size(1182, 553);
            this.tableLayoutForm.TabIndex = 8;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(33, 33);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(150, 43);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // lblPlaca
            // 
            this.lblPlaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(147, 251);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(140, 49);
            this.lblPlaca.TabIndex = 1;
            this.lblPlaca.Text = "Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlaca.Location = new System.Drawing.Point(68, 300);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(0);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(298, 61);
            this.txtPlaca.TabIndex = 2;
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(503, 251);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(176, 49);
            this.lblModelo.TabIndex = 3;
            this.lblModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModelo.Location = new System.Drawing.Point(442, 300);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(0);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(298, 61);
            this.txtModelo.TabIndex = 4;
            // 
            // lblCor
            // 
            this.lblCor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.Location = new System.Drawing.Point(915, 251);
            this.lblCor.Margin = new System.Windows.Forms.Padding(0);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(99, 49);
            this.lblCor.TabIndex = 5;
            this.lblCor.Text = "Cor";
            // 
            // txtCor
            // 
            this.txtCor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCor.Location = new System.Drawing.Point(816, 300);
            this.txtCor.Margin = new System.Windows.Forms.Padding(0);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(298, 61);
            this.txtCor.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.AutoSize = true;
            this.tableLayoutForm.SetColumnSpan(this.btnSalvar, 3);
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(441, 404);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(300, 64);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Cadastrar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // CadastroVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(27F, 54F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.tableLayoutForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CadastroVeiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Veículos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastroVeiculos_Load);
            this.tableLayoutForm.ResumeLayout(false);
            this.tableLayoutForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutForm;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Button btnVoltar;
    }
}