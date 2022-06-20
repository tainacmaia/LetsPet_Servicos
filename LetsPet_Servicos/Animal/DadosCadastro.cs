using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet_Services.Animal
{
    public class DadosCadastro
    {
        public Guid Codigo { get; private set; } = Guid.NewGuid();
        public DateTime DataCadastro { get; private set; } = DateTime.Now;

    }
}
