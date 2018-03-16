using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiap.PlataformaNet.Avaliacao_48829.Dominio;
using Fiap.PlataformaNet.Avaliacao_48829.Repositorio;

namespace Fiap.PlataformaNet.Avaliacao_48829.Aplicacao
{
    public class TratamentoGerenciador
    {
        internal static void SalvarTratamento(TratamentoDominio tratamento)
        {
            TratamentoRepositorio.Instance.SalvarTratamento(tratamento);
        }

        internal static List<TratamentoDominio> BuscarTratamentoPorPaciente(int idPaciente)
        {
            var listaTratamentos = new List<TratamentoDominio>();

            listaTratamentos = TratamentoRepositorio.Instance.BuscarTratamentoPorPaciente(idPaciente);

            return listaTratamentos;
        }

        internal static List<TratamentoDominio> BuscarTodosTratamentos()
        {
            var listaTratamentos = new List<TratamentoDominio>();

            listaTratamentos = TratamentoRepositorio.Instance.BuscarTodosTratamentos();

            return listaTratamentos;
        }
    }
}
