using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiap.PlataformaNet.Avaliacao_48829.Dominio;
using Fiap.PlataformaNet.Avaliacao_48829.Repositorio;

namespace Fiap.PlataformaNet.Avaliacao_48829.Aplicacao
{
    public class PacienteGerenciador
    {
        internal static void SalvarPaciente(PacienteDominio paciente)
        {
            PacienteRepositorio.Instance.SalvarPaciente(paciente);
        }

        internal static List<PacienteDominio> BuscarPacientes()
        {
            var listaPacientes = new List<PacienteDominio>();

            listaPacientes = PacienteRepositorio.Instance.BuscarEvento();

            return listaPacientes;
        }
    }
}
