using Dapper;
using Fiap.PlataformaNet.Avaliacao_48829.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.PlataformaNet.Avaliacao_48829.Repositorio
{
    public class TratamentoRepositorio
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["DBCLINICA"].ConnectionString;

        private static readonly Lazy<TratamentoRepositorio> lazy = new Lazy<TratamentoRepositorio>(() => new TratamentoRepositorio());

        public static TratamentoRepositorio Instance { get { return lazy.Value; } }

        internal void SalvarTratamento(TratamentoDominio tratamento)
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Execute("Insert into TBTratamentos values(@idpaciente, @descricao, @preco)", tratamento);
            }
        }

        internal List<TratamentoDominio> BuscarTratamentoPorPaciente(int idPaciente)
        {
            var query = string.Format(@"Select * from TBTratamentos where idpaciente = {0}", idPaciente);

            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var listaTratamentos = sqlConnection.Query<TratamentoDominio>(query);

                return listaTratamentos.ToList();
            }
        }

        internal List<TratamentoDominio> BuscarTodosTratamentos()
        {
            var query = @"Select * from TBTratamentos";

            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var listaTratamentos = sqlConnection.Query<TratamentoDominio>(query);

                return listaTratamentos.ToList();
            }
        }
    }
}
