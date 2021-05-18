using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            this._totalBonificacao += funcionario.GetBonificacao();
        }

        public void Registrar(Diretor diretor)
        {
            this._totalBonificacao += diretor.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return this._totalBonificacao;
        }
    }
}
