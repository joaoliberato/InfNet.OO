using InfNet.OO.Domain.Exception;

namespace InfNet.OO.Domain
{
    public class Funcionario
    {
        internal Funcionario(Pessoa pessoa, decimal salario)
        {
            Pessoa = pessoa;
            SalarioBase = salario;
        }

        public decimal SalarioBase { get; set; }
        public Pessoa Pessoa { get; set; }
        public int IdFuncionario { get; set; }

        public decimal GetSalarioComBonus()
        {
            return SalarioBase * Bonus();
        }

        public virtual decimal Bonus()
        {
            return 1;
        }

        public void DarAumentoProporcional(decimal percentual)
        {
            if (percentual <= 0)
            {
                throw new PercentualInvalidoException(percentual);
            }
            SalarioBase *= 1 + percentual / 100;
        }
        public void DarAumentoAbsoluto(decimal valor)
        {
            if (valor <= 0)
            {
                throw new ValorInvalidoException(valor);
            }
            SalarioBase += valor;
        }
    }
}
