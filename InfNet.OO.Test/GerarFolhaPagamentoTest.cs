using InfNet.OO.Application;
using InfNet.OO.Domain;
using InfNet.OO.Domain.Factory;
using InfNet.OO.Domain.Repository;
using InfNet.OO.Repository;

namespace InfNet.OO.Test;

[TestClass]
public class GerarFolhaPagamentoTest
{
    [TestMethod]
    public void GerarFolhaDePagamento_DeveRetornar_12250()
    {
        // Arrange
        IEquipeRepository repository = new EquipeRepository();

        var equipe = new Equipe()
        {
            Nome = "Mercedes",
            IdEquipe = 1
        };
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Lewis Hamilton"), 1000, "Piloto", 15));
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("George Russell"), 1000));
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Valtteri Bottas"), 1000));
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Mick Schumacher"), 1000));
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Kimi Antonelli"), 1000));
        equipe.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Nico Rosberg"), 1000, "Piloto", 10));
        equipe.Gerente = (Gerente)FuncionarioFactory.Create(new Pessoa("Toto Wolf"), 5000, equipe);
        repository.Add(equipe);
        // Act
        GerarFolhaDePagamento folhaPagamento = new GerarFolhaDePagamento(repository);
        var result = folhaPagamento.Gerar(1);
        // Assert
        Assert.AreEqual(12250, result.ValorTotal);
    }
}
