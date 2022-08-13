using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoFuncionario.Comuns.Modelos
{
    class Funcionario
    {
        public int id { get; protected set; }
        private string _nomeCompleto;

        public string NomeCompleto { get; protected set; }

        public int CargoId { get; protected set; }

        public bool EBebedorCafe { get; protected set; }

        public String PrimeiroNome { get; protected set; }

        public string UltimoNome { get; protected set; }

        public DateTimeOffset DataEntrada { get; protected set; }




    }
}
