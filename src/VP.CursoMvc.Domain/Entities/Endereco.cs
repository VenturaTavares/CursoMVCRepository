using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP.CursoMvc.Domain.Entities
{
  public  class Endereco
    {
        public Endereco()
        {
            EnderecoID = Guid.NewGuid(); 
        }

        public Guid EnderecoID { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string CEP { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public Guid ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }
    }


}
