using Fiap.PlataformaNet.Avaliacao_48829.Aplicacao;
using Fiap.PlataformaNet.Avaliacao_48829.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiap.PlataformaNet.Avaliacao_48829
{
    public partial class FrmClinica : Form
    {
        public FrmClinica()
        {
            InitializeComponent();
        }

        private void IncluirPacienteButton_Click(object sender, EventArgs e)
        {
            var paciente = new PacienteDominio()
            {
                Nome = nomeTextBox.Text,
                Telefone = telefoneTextBox.Text
            };

            PacienteGerenciador.SalvarPaciente(paciente);
            if (true)
            {
                MessageBox.Show("Paciente inserido com sucesso");
                LimpaController();
            }
        }

        private void LimpaController()
        {
            nomeTextBox.Clear();
            telefoneTextBox.Clear();
            descricaoTextBox.Clear();
            precoNumericUpDown.Value = 0.00M;
        }

        private void PreencheComboPacientes()
        {
            List<PacienteDominio> listaPacientes = PacienteGerenciador.BuscarPacientes();

            pacienteComboBox.DataSource = listaPacientes.Select(e => new { id = e.Id, nome = e.Nome })
                                                    .ToList();
            pacienteComboBox.ValueMember = "id";
            pacienteComboBox.DisplayMember = "nome";
        }

        private void IncluirTratamentoButton_Click(object sender, EventArgs e)
        {
            if (pacienteComboBox.SelectedValue != null)
            {

                var tratamento = new TratamentoDominio()
                {
                    IdPaciente = (int)pacienteComboBox.SelectedValue,
                    Descricao = descricaoTextBox.Text,
                    Preco = precoNumericUpDown.Value
                };
                TratamentoGerenciador.SalvarTratamento(tratamento);
                if (true)
                {
                    MessageBox.Show("Tratamento inserido com sucesso");
                    LimpaController();
                }
            }
            else
            {
                MessageBox.Show("Favor selecionar um paciente");
            }
        }

        private void PacienteComboBox_Click(object sender, EventArgs e)
        {
            PreencheComboPacientes();
        }

        private async void ListarTratamentoPorPacienteButton_Click(object sender, EventArgs e)
        {
            gerenicListBox.Items.Clear();
            await ListarTratamentoPorPaciente();
        }

        private async Task ListarTratamentoPorPaciente()
        {
            if (pacienteComboBox.SelectedValue != null)
            {
                var idPaciente = (int)pacienteComboBox.SelectedValue;

                List<TratamentoDominio> listaTratamentos = TratamentoGerenciador.BuscarTratamentoPorPaciente(idPaciente);

                gerenicListBox.Items.Add($"Listando tratamentos por paciente \r\n");
                gerenicListBox.Items.Add($"________________ \r\n");
                gerenicListBox.Items.Add($"                ");
                var quantidade = listaTratamentos.Count();
                var contador = 1;
                foreach (var tratamento in listaTratamentos)
                {
                    gerenicListBox.Items.Add(tratamento.Descricao);
                    var progresso = (contador * 100) / quantidade;
                    progressBar.Value = progresso;
                    contador++;
                    await Task.Delay(2000);
                }
                gerenicListBox.Items.Add($"________________  \r\n");
            }
            else
            {
                MessageBox.Show("Favor selecionar um paciente");
            }
        }

        private async void ListarTratamentosButton_Click(object sender, EventArgs e)
        {
            gerenicListBox.Items.Clear();
            await ListarTodosTratamentos();
        }

        private async Task ListarTodosTratamentos()
        {
            List<TratamentoDominio> listaTratamentos = TratamentoGerenciador.BuscarTodosTratamentos();

            gerenicListBox.Items.Add($"Listando todos tratamentos \r\n");
            gerenicListBox.Items.Add($"________________ \r\n");
            gerenicListBox.Items.Add($"                ");
            var quantidade = listaTratamentos.Count();
            var contador = 1;
            foreach (var tratamento in listaTratamentos)
            {
                gerenicListBox.Items.Add(tratamento.Descricao);
                var progresso = (contador * 100) / quantidade;
                progressBar.Value = progresso;
                contador++;
                await Task.Delay(2000);
            }
            gerenicListBox.Items.Add($"________________  \r\n");
        }
    }
}
