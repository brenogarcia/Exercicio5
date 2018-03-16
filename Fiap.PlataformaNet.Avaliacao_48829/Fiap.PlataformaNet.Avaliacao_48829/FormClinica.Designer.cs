namespace Fiap.PlataformaNet.Avaliacao_48829
{
    partial class FrmClinica
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
            this.groupBoxPacientes = new System.Windows.Forms.GroupBox();
            this.incluirPacienteButton = new System.Windows.Forms.Button();
            this.labelTelefonePaciente = new System.Windows.Forms.Label();
            this.labelNomePaciente = new System.Windows.Forms.Label();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxTratamentos = new System.Windows.Forms.GroupBox();
            this.precoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.incluirTratamentoButton = new System.Windows.Forms.Button();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.pacienteComboBox = new System.Windows.Forms.ComboBox();
            this.labelPreco = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelDescricaoPaciente = new System.Windows.Forms.Label();
            this.consultasGroupBox = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.listarTratamentosButton = new System.Windows.Forms.Button();
            this.listarTratamentoPorPacienteButton = new System.Windows.Forms.Button();
            this.gerenicListBox = new System.Windows.Forms.ListBox();
            this.groupBoxPacientes.SuspendLayout();
            this.groupBoxTratamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.precoNumericUpDown)).BeginInit();
            this.consultasGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPacientes
            // 
            this.groupBoxPacientes.Controls.Add(this.incluirPacienteButton);
            this.groupBoxPacientes.Controls.Add(this.labelTelefonePaciente);
            this.groupBoxPacientes.Controls.Add(this.labelNomePaciente);
            this.groupBoxPacientes.Controls.Add(this.telefoneTextBox);
            this.groupBoxPacientes.Controls.Add(this.nomeTextBox);
            this.groupBoxPacientes.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPacientes.Name = "groupBoxPacientes";
            this.groupBoxPacientes.Size = new System.Drawing.Size(294, 171);
            this.groupBoxPacientes.TabIndex = 0;
            this.groupBoxPacientes.TabStop = false;
            this.groupBoxPacientes.Text = "Cadastro de Pacientes";
            // 
            // incluirPacienteButton
            // 
            this.incluirPacienteButton.Location = new System.Drawing.Point(159, 142);
            this.incluirPacienteButton.Name = "incluirPacienteButton";
            this.incluirPacienteButton.Size = new System.Drawing.Size(129, 23);
            this.incluirPacienteButton.TabIndex = 4;
            this.incluirPacienteButton.Text = "Incluir Paciente";
            this.incluirPacienteButton.UseVisualStyleBackColor = true;
            this.incluirPacienteButton.Click += new System.EventHandler(this.IncluirPacienteButton_Click);
            // 
            // labelTelefonePaciente
            // 
            this.labelTelefonePaciente.AutoSize = true;
            this.labelTelefonePaciente.Location = new System.Drawing.Point(7, 51);
            this.labelTelefonePaciente.Name = "labelTelefonePaciente";
            this.labelTelefonePaciente.Size = new System.Drawing.Size(52, 13);
            this.labelTelefonePaciente.TabIndex = 3;
            this.labelTelefonePaciente.Text = "Telefone:";
            // 
            // labelNomePaciente
            // 
            this.labelNomePaciente.AutoSize = true;
            this.labelNomePaciente.Location = new System.Drawing.Point(7, 25);
            this.labelNomePaciente.Name = "labelNomePaciente";
            this.labelNomePaciente.Size = new System.Drawing.Size(38, 13);
            this.labelNomePaciente.TabIndex = 2;
            this.labelNomePaciente.Text = "Nome:";
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(65, 48);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(223, 20);
            this.telefoneTextBox.TabIndex = 1;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(65, 22);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(223, 20);
            this.nomeTextBox.TabIndex = 0;
            // 
            // groupBoxTratamentos
            // 
            this.groupBoxTratamentos.Controls.Add(this.precoNumericUpDown);
            this.groupBoxTratamentos.Controls.Add(this.incluirTratamentoButton);
            this.groupBoxTratamentos.Controls.Add(this.descricaoTextBox);
            this.groupBoxTratamentos.Controls.Add(this.pacienteComboBox);
            this.groupBoxTratamentos.Controls.Add(this.labelPreco);
            this.groupBoxTratamentos.Controls.Add(this.labelDescricao);
            this.groupBoxTratamentos.Controls.Add(this.labelDescricaoPaciente);
            this.groupBoxTratamentos.Location = new System.Drawing.Point(12, 189);
            this.groupBoxTratamentos.Name = "groupBoxTratamentos";
            this.groupBoxTratamentos.Size = new System.Drawing.Size(294, 191);
            this.groupBoxTratamentos.TabIndex = 1;
            this.groupBoxTratamentos.TabStop = false;
            this.groupBoxTratamentos.Text = "Cadastro de Tratamentos";
            // 
            // precoNumericUpDown
            // 
            this.precoNumericUpDown.DecimalPlaces = 2;
            this.precoNumericUpDown.Location = new System.Drawing.Point(65, 86);
            this.precoNumericUpDown.Name = "precoNumericUpDown";
            this.precoNumericUpDown.Size = new System.Drawing.Size(223, 20);
            this.precoNumericUpDown.TabIndex = 11;
            // 
            // incluirTratamentoButton
            // 
            this.incluirTratamentoButton.Location = new System.Drawing.Point(159, 162);
            this.incluirTratamentoButton.Name = "incluirTratamentoButton";
            this.incluirTratamentoButton.Size = new System.Drawing.Size(129, 23);
            this.incluirTratamentoButton.TabIndex = 10;
            this.incluirTratamentoButton.Text = "Incluir Tratamento";
            this.incluirTratamentoButton.UseVisualStyleBackColor = true;
            this.incluirTratamentoButton.Click += new System.EventHandler(this.IncluirTratamentoButton_Click);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(65, 57);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(223, 20);
            this.descricaoTextBox.TabIndex = 8;
            // 
            // pacienteComboBox
            // 
            this.pacienteComboBox.FormattingEnabled = true;
            this.pacienteComboBox.Location = new System.Drawing.Point(65, 30);
            this.pacienteComboBox.Name = "pacienteComboBox";
            this.pacienteComboBox.Size = new System.Drawing.Size(223, 21);
            this.pacienteComboBox.TabIndex = 7;
            this.pacienteComboBox.Click += new System.EventHandler(this.PacienteComboBox_Click);
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(6, 86);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(38, 13);
            this.labelPreco.TabIndex = 6;
            this.labelPreco.Text = "Preço:";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(6, 60);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(58, 13);
            this.labelDescricao.TabIndex = 5;
            this.labelDescricao.Text = "Descrição:";
            // 
            // labelDescricaoPaciente
            // 
            this.labelDescricaoPaciente.AutoSize = true;
            this.labelDescricaoPaciente.Location = new System.Drawing.Point(6, 33);
            this.labelDescricaoPaciente.Name = "labelDescricaoPaciente";
            this.labelDescricaoPaciente.Size = new System.Drawing.Size(52, 13);
            this.labelDescricaoPaciente.TabIndex = 4;
            this.labelDescricaoPaciente.Text = "Paciente:";
            // 
            // consultasGroupBox
            // 
            this.consultasGroupBox.Controls.Add(this.gerenicListBox);
            this.consultasGroupBox.Controls.Add(this.progressBar);
            this.consultasGroupBox.Controls.Add(this.listarTratamentosButton);
            this.consultasGroupBox.Controls.Add(this.listarTratamentoPorPacienteButton);
            this.consultasGroupBox.Location = new System.Drawing.Point(312, 12);
            this.consultasGroupBox.Name = "consultasGroupBox";
            this.consultasGroupBox.Size = new System.Drawing.Size(363, 368);
            this.consultasGroupBox.TabIndex = 2;
            this.consultasGroupBox.TabStop = false;
            this.consultasGroupBox.Text = "Consultas";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 336);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(347, 23);
            this.progressBar.TabIndex = 7;
            // 
            // listarTratamentosButton
            // 
            this.listarTratamentosButton.Location = new System.Drawing.Point(184, 20);
            this.listarTratamentosButton.Name = "listarTratamentosButton";
            this.listarTratamentosButton.Size = new System.Drawing.Size(169, 48);
            this.listarTratamentosButton.TabIndex = 5;
            this.listarTratamentosButton.Text = "Listar Todos os Tratamentos";
            this.listarTratamentosButton.UseVisualStyleBackColor = true;
            this.listarTratamentosButton.Click += new System.EventHandler(this.ListarTratamentosButton_Click);
            // 
            // listarTratamentoPorPacienteButton
            // 
            this.listarTratamentoPorPacienteButton.Location = new System.Drawing.Point(6, 20);
            this.listarTratamentoPorPacienteButton.Name = "listarTratamentoPorPacienteButton";
            this.listarTratamentoPorPacienteButton.Size = new System.Drawing.Size(172, 48);
            this.listarTratamentoPorPacienteButton.TabIndex = 4;
            this.listarTratamentoPorPacienteButton.Text = "Listar Tratamento por Paciente";
            this.listarTratamentoPorPacienteButton.UseVisualStyleBackColor = true;
            this.listarTratamentoPorPacienteButton.Click += new System.EventHandler(this.ListarTratamentoPorPacienteButton_Click);
            // 
            // gerenicListBox
            // 
            this.gerenicListBox.FormattingEnabled = true;
            this.gerenicListBox.Location = new System.Drawing.Point(6, 74);
            this.gerenicListBox.Name = "gerenicListBox";
            this.gerenicListBox.Size = new System.Drawing.Size(347, 264);
            this.gerenicListBox.TabIndex = 8;
            // 
            // FrmClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(692, 396);
            this.Controls.Add(this.consultasGroupBox);
            this.Controls.Add(this.groupBoxTratamentos);
            this.Controls.Add(this.groupBoxPacientes);
            this.MaximumSize = new System.Drawing.Size(708, 435);
            this.MinimumSize = new System.Drawing.Size(708, 435);
            this.Name = "FrmClinica";
            this.Text = "Clínica Médica";
            this.groupBoxPacientes.ResumeLayout(false);
            this.groupBoxPacientes.PerformLayout();
            this.groupBoxTratamentos.ResumeLayout(false);
            this.groupBoxTratamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.precoNumericUpDown)).EndInit();
            this.consultasGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPacientes;
        private System.Windows.Forms.Button incluirPacienteButton;
        private System.Windows.Forms.Label labelTelefonePaciente;
        private System.Windows.Forms.Label labelNomePaciente;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.GroupBox groupBoxTratamentos;
        private System.Windows.Forms.Button incluirTratamentoButton;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.ComboBox pacienteComboBox;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelDescricaoPaciente;
        private System.Windows.Forms.GroupBox consultasGroupBox;
        private System.Windows.Forms.Button listarTratamentoPorPacienteButton;
        private System.Windows.Forms.Button listarTratamentosButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.NumericUpDown precoNumericUpDown;
        private System.Windows.Forms.ListBox gerenicListBox;
    }
}

