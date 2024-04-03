using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_Migrations
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }

        public DateTime DataInsercao{ get; set;   }

    }
}