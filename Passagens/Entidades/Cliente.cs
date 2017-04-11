using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Passagens.Entidades
{
    [DataContractFormat]
    class Cliente
    {
        [DataMember]
        public string Cpf { get; set; }
        [DataMember]
        public string Nome { get; set; }
    }
}
