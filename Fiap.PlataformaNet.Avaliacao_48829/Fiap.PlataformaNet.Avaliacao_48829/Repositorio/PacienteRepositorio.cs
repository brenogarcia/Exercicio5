using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Fiap.PlataformaNet.Avaliacao_48829.Dominio;

namespace Fiap.PlataformaNet.Avaliacao_48829.Repositorio
{
    public class PacienteRepositorio
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["DBCLINICA"].ConnectionString;

        private static readonly Lazy<PacienteRepositorio> lazy = new Lazy<PacienteRepositorio>(() => new PacienteRepositorio());

        public static PacienteRepositorio Instance { get { return lazy.Value; } }

        internal void SalvarPaciente(PacienteDominio paciente)
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Execute("Insert into TBPacientes values(@nome, @telefone)", paciente);
            }
        }

        internal List<PacienteDominio> BuscarEvento()
        {
            var query = @" Select id, nome from TBPacientes";

            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var listaPacientes = sqlConnection.Query<PacienteDominio>(query);

                return listaPacientes.ToList();
            }
        }
    }
}
