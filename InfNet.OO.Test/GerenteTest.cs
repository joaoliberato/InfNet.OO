using InfNet.OO.Domain;
using InfNet.OO.Domain.Exception;
using InfNet.OO.Domain.Factory;

namespace InfNet.OO.Test;

[TestClass]
public class GerenteTest
{
    [TestMethod]
    public void Gerente_ComEquipeVazia_DeveRetornar_TimeVazioException()
    {
        // Assert
        Assert.ThrowsException<TimeVazioException>(() => FuncionarioFactory.Create(new Pessoa("Toto Wolf"), 5000, null));
    }

    [TestMethod]
    public void Gerente_ComEquipeUmaPessoa_DeveRetornar_Bonus1Ponto1ESalarioComBonus5500()
    {
        // Assert
        var equipe = new Equipe()
        {
            Nome = "Mercedes",
            IdEquipe = 1
        };
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Lewis Hamilton"), 1000));
        equipe.Gerente = (Gerente)FuncionarioFactory.Create(new Pessoa("Toto Wolf"), 5000, equipe);

        // Assert
        Assert.AreEqual(1.1m, equipe.Gerente.Bonus());
        Assert.AreEqual(5500, equipe.Gerente.GetSalarioComBonus());
    }

    [TestMethod]
    public void Gerente_ComEquipeSeisPessoas_DeveRetornar_Bonus1Ponto2ESalarioComBonus6000()
    {
        // Assert
        var equipe = new Equipe()
        {
            Nome = "Mercedes",
            IdEquipe = 1
        };
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Lewis Hamilton"), 1000));
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("George Russell"), 1000));
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Valtteri Bottas"), 1000));
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Mick Schumacher"), 1000));
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Kimi Antonelli"), 1000));
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Nico Rosberg"), 1000));

        equipe.Gerente = (Gerente)FuncionarioFactory.Create(new Pessoa("Toto Wolf"), 5000, equipe);

        // Assert
        Assert.AreEqual(1.2m, equipe.Gerente.Bonus());
        Assert.AreEqual(6000, equipe.Gerente.GetSalarioComBonus());

    }


    [TestMethod]
    public void Gerente_ComEquipeOnzePessoas_DeveRetornar_Bonus1Ponto5ESalarioComBonus7500()
    {
        // Assert
        var equipe = new Equipe()
        {
            Nome = "Mercedes",
            IdEquipe = 1
        };
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Lewis Hamilton"), 1000));
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("George Russell"), 1000));
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Valtteri Bottas"), 1000));
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Mick Schumacher"), 1000));
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Kimi Antonelli"), 1000));
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Nico Rosberg"), 1000));
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Michael Schumacher"), 1000));
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Ralf Schumacher"), 1000));
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Mika Hakkinen"), 1000));
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Kimi Raikkonen"), 1000));
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Fernando Alonso"), 1000));

        equipe.Gerente = (Gerente)FuncionarioFactory.Create(new Pessoa("Toto Wolf"), 5000, equipe);

        // Assert
        Assert.AreEqual(1.5m, equipe.Gerente.Bonus());
        Assert.AreEqual(7500, equipe.Gerente.GetSalarioComBonus());

    }
}
