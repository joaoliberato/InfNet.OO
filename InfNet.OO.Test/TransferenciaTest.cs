using InfNet.OO.Application;
using InfNet.OO.Domain;
using InfNet.OO.Domain.Factory;
using InfNet.OO.Domain.Repository;
using InfNet.OO.Domain.Service;
using InfNet.OO.Repository;

namespace InfNet.OO.Test
{
    [TestClass]
    public sealed class TransferenciaTest
    {

        [TestMethod]
        public void TransferenciaEntreEquipes_DeveRetornar_EquipeOrigemComMenosUmaPessoa()
        {

            // Arrange
            IEquipeRepository repository = new EquipeRepository();

            var equipeOrigem = new Equipe()
            {
                Nome = "Mercedes",
                IdEquipe = 1
            };
            var equipeDestino = new Equipe()
            {
                Nome = "Ferrari",
                IdEquipe = 2
            };
            var lewisHamilton = FuncionarioFactory.Create(new Pessoa("Lewis Hamilton"), 1000);
            lewisHamilton.IdFuncionario = 1;
            equipeOrigem.AddFuncionario(lewisHamilton);
            equipeOrigem.Gerente = (Gerente)FuncionarioFactory.Create(new Pessoa("Toto Wolf"), 5000, equipeOrigem);

            equipeDestino.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Charles Leclerc"), 1000));
            equipeDestino.Gerente = (Gerente)FuncionarioFactory.Create(new Pessoa("Fred Vasseur"), 5000, equipeDestino);

            repository.Add(equipeOrigem);
            repository.Add(equipeDestino);

            // Act
            TransferenciaEntreEquipes transferenciaEntreEquipes = new TransferenciaEntreEquipes(repository, new TransferenciaService());
            transferenciaEntreEquipes.Transferir(lewisHamilton.IdFuncionario, equipeOrigem.IdEquipe, equipeDestino.IdEquipe);

            // Assert
            Assert.AreEqual(0, equipeOrigem.GetTime().Count());
            Assert.AreEqual(2, equipeDestino.GetTime().Count());

        }
    }
}
