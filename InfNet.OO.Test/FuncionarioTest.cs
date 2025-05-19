using InfNet.OO.Domain.Exception;
using InfNet.OO.Domain.Factory;

namespace InfNet.OO.Test;

[TestClass]
public class FuncionarioTest
{
    [TestMethod]
    public void FuncionarioComSalario1000_RecebeAumentoDezPorCento_NovoSalario_DeveRetornar_MilECem()
    {
        // Arrange
        var oscar = FuncionarioFactory.Create(new Domain.Pessoa("Oscar Piastri"), 1000);
        decimal percentualAumento = 10;
        // Act
        oscar.DarAumentoProporcional(percentualAumento);
        // Assert
        Assert.AreEqual(1100, oscar.SalarioBase);
    }
    [TestMethod]
    public void FuncionarioComSalario1000_RecebeAumentoMenosDezPorCento_NovoSalario_DeveRetornar_PercentualInvalidoESalarioMil()
    {
        // Arrange
        var oscar = FuncionarioFactory.Create(new Domain.Pessoa("Oscar Piastri"), 1000);
        decimal percentualAumento = -10;

        // Assert
        Assert.ThrowsException<PercentualInvalidoException>(() => oscar.DarAumentoProporcional(percentualAumento));
        Assert.AreEqual(1000, oscar.SalarioBase);
    }

    [TestMethod]
    public void FuncionarioComSalario1000_RecebeAumentoCem_NovoSalario_DeveRetornar_MilECem()
    {
        // Arrange
        var oscar = FuncionarioFactory.Create(new Domain.Pessoa("Oscar Piastri"), 1000);
        decimal valorAumento = 100;
        // Act
        oscar.DarAumentoAbsoluto(valorAumento);
        // Assert
        Assert.AreEqual(1100, oscar.SalarioBase);
    }

    [TestMethod]
    public void FuncionarioComSalario1000_RecebeAumentoMenosCem_NovoSalario_DeveRetornar_ValorInvalidoInvalidoESalarioMil()
    {
        // Arrange
        var oscar = FuncionarioFactory.Create(new Domain.Pessoa("Oscar Piastri"), 1000);
        decimal valorAumento = -100;

        // Assert
        Assert.ThrowsException<ValorInvalidoException>(() => oscar.DarAumentoAbsoluto(valorAumento));
        Assert.AreEqual(1000, oscar.SalarioBase);
    }


    [TestMethod]
    public void FuncionarioComSalario1000_SalarioComBonuos_DeveRetornar_Mil()
    {
        // Arrange
        var oscar = FuncionarioFactory.Create(new Domain.Pessoa("Oscar Piastri"), 1000);

        // Assert
        Assert.AreEqual(1000, oscar.GetSalarioComBonus());
    }
}
