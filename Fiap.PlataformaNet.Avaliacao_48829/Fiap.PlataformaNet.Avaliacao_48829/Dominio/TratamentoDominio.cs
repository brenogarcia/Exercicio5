using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.PlataformaNet.Avaliacao_48829.Dominio
{
    public class TratamentoDominio
    {
        public int Id { get; private set; }

        public int IdPaciente { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public TratamentoDominio() { }

        public TratamentoDominio(int id)
        {
            Id = id;
        }
    }
}
