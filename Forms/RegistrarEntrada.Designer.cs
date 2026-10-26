namespace EstacionamentoAuthSoft.Forms
{
    partial class RegistrarEntrada
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
            this.lblData = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblHorario = new System.Windows.Forms.Label();
            this.datePickerEntrada = new System.Windows.Forms.DateTimePicker();
            this.cmbPlaca = new System.Windows.Forms.ComboBox();
            this.timePickerEntrada = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.tableLayoutForm.SetColumnSpan(this.lblTitulo, 3);
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(581, 166);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(762, 91);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de Entrada";
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
            this.tableLayoutForm.Controls.Add(this.lblData, 1, 2);
            this.tableLayoutForm.Controls.Add(this.btnRegistrar, 0, 4);
            this.tableLayoutForm.Controls.Add(this.lblHorario, 2, 2);
            this.tableLayoutForm.Controls.Add(this.datePickerEntrada, 1, 3);
            this.tableLayoutForm.Controls.Add(this.cmbPlaca, 0, 3);
            this.tableLayoutForm.Controls.Add(this.timePickerEntrada, 2, 3);
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
            this.tableLayoutForm.Size = new System.Drawing.Size(1924, 753);
            this.tableLayoutForm.TabIndex = 9;
            // 
            // btnVoltar
            // 
            this.btnVoltar.AutoSize = true;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(33, 33);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(150, 48);
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
            this.lblPlaca.Location = new System.Drawing.Point(270, 348);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(140, 54);
            this.lblPlaca.TabIndex = 1;
            this.lblPlaca.Text = "Placa";
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(900, 348);
            this.lblData.Margin = new System.Windows.Forms.Padding(0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(122, 54);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrar.AutoSize = true;
            this.tableLayoutForm.SetColumnSpan(this.btnRegistrar, 3);
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(812, 569);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(300, 64);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // lblHorario
            // 
            this.lblHorario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(1522, 348);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(122, 54);
            this.lblHorario.TabIndex = 11;
            this.lblHorario.Text = "Data";
            // 
            // datePickerEntrada
            // 
            this.datePickerEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePickerEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerEntrada.Location = new System.Drawing.Point(661, 414);
            this.datePickerEntrada.Name = "datePickerEntrada";
            this.datePickerEntrada.Size = new System.Drawing.Size(600, 61);
            this.datePickerEntrada.TabIndex = 9;
            // 
            // cmbPlaca
            // 
            this.cmbPlaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlaca.FormattingEnabled = true;
            this.cmbPlaca.IntegralHeight = false;
            this.cmbPlaca.Location = new System.Drawing.Point(40, 413);
            this.cmbPlaca.MaxDropDownItems = 6;
            this.cmbPlaca.Name = "cmbPlaca";
            this.cmbPlaca.Size = new System.Drawing.Size(600, 62);
            this.cmbPlaca.TabIndex = 10;
            // 
            // timePickerEntrada
            // 
            this.timePickerEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timePickerEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePickerEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerEntrada.Location = new System.Drawing.Point(1283, 414);
            this.timePickerEntrada.Name = "timePickerEntrada";
            this.timePickerEntrada.ShowUpDown = true;
            this.timePickerEntrada.Size = new System.Drawing.Size(600, 61);
            this.timePickerEntrada.TabIndex = 12;
            // 
            // RegistrarEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 753);
            this.Controls.Add(this.tableLayoutForm);
            this.Name = "RegistrarEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Entrada";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RegistrarEntrada_Load);
            this.tableLayoutForm.ResumeLayout(false);
            this.tableLayoutForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutForm;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DateTimePicker datePickerEntrada;
        private System.Windows.Forms.ComboBox cmbPlaca;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.DateTimePicker timePickerEntrada;
    }
}