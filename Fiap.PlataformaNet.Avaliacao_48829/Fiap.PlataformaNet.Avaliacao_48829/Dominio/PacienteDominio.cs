using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.PlataformaNet.Avaliacao_48829.Dominio
{
    public class PacienteDominio
    {
        public int Id { get; private set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public PacienteDominio() { }

        public PacienteDominio(int id)
        {
            Id = id;
        }
    }
}
