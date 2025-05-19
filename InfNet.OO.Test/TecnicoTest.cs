using InfNet.OO.Domain;
using InfNet.OO.Domain.Exception;
using InfNet.OO.Domain.Factory;

namespace InfNet.OO.Test;

[TestClass]
public class TecnicoTest
{
    [TestMethod]
    public void TecnicoComSalario1000EComissao10PorCento_SalarioComBonus_DeveRetornar_1100()
    {
        Tecnico oscar = (Tecnico)FuncionarioFactory.Create(new Pessoa("Oscar Piastri"), 1000, "Engenharia", 10);

        Assert.AreEqual(1100, oscar.GetSalarioComBonus());
    }

    [TestMethod]
    public void TecnicoComSalario1000EComissaoMenos10PorCento_DeveRetornar_PercentualInvalidoException()
    {
        Assert.ThrowsException<PercentualInvalidoException>(() => FuncionarioFactory.Create(new Pessoa("Oscar Piastri"), 1000, "Engenharia", -10));
    }
}
