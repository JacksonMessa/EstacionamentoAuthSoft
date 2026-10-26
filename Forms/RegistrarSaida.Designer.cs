namespace EstacionamentoAuthSoft.Forms
{
    partial class RegistrarSaida
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
            this.timePickerSaida = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutForm = new System.Windows.Forms.TableLayoutPanel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblHorario = new System.Windows.Forms.Label();
            this.datePickerSaida = new System.Windows.Forms.DateTimePicker();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.tableLayoutForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.tableLayoutForm.SetColumnSpan(this.lblTitulo, 3);
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(620, 166);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(684, 91);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de Saída";
            // 
            // timePickerSaida
            // 
            this.timePickerSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timePickerSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePickerSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerSaida.Location = new System.Drawing.Point(1283, 414);
            this.timePickerSaida.Name = "timePickerSaida";
            this.timePickerSaida.ShowUpDown = true;
            this.timePickerSaida.Size = new System.Drawing.Size(600, 61);
            this.timePickerSaida.TabIndex = 12;
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
            this.tableLayoutForm.Controls.Add(this.datePickerSaida, 1, 3);
            this.tableLayoutForm.Controls.Add(this.timePickerSaida, 2, 3);
            this.tableLayoutForm.Controls.Add(this.txtPlaca, 0, 3);
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
            this.tableLayoutForm.TabIndex = 10;
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
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // lblHorario
            // 
            this.lblHorario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(1494, 348);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(177, 54);
            this.lblHorario.TabIndex = 11;
            this.lblHorario.Text = "Horário";
            // 
            // datePickerSaida
            // 
            this.datePickerSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePickerSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerSaida.Location = new System.Drawing.Point(661, 414);
            this.datePickerSaida.Name = "datePickerSaida";
            this.datePickerSaida.Size = new System.Drawing.Size(600, 61);
            this.datePickerSaida.TabIndex = 9;
            this.datePickerSaida.ValueChanged += new System.EventHandler(this.DatePickerEntrada_ValueChanged);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlaca.Enabled = false;
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.HideSelection = false;
            this.txtPlaca.Location = new System.Drawing.Point(40, 414);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(600, 61);
            this.txtPlaca.TabIndex = 13;
            // 
            // RegistrarSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 753);
            this.Controls.Add(this.tableLayoutForm);
            this.Name = "RegistrarSaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de Saída";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.DateTimePicker datePickerSaida;
        private System.Windows.Forms.DateTimePicker timePickerSaida;
        private System.Windows.Forms.TextBox txtPlaca;
    }
}