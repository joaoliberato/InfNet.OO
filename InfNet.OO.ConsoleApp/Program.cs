// See https://aka.ms/new-console-template for more information
using InfNet.OO.Application;
using InfNet.OO.ConsoleApp;
using InfNet.OO.Domain;
using InfNet.OO.Domain.Factory;
using InfNet.OO.Domain.Repository;
using InfNet.OO.Domain.Service;
using InfNet.OO.Repository;

Console.WriteLine("Hello, World!");


IEquipeRepository repository = new EquipeRepository();

var mercedes = new Equipe()
{
    Nome = "Mercedes",
    IdEquipe = 1
};
Tecnico lewis = (Tecnico)FuncionarioFactory.Create(new Pessoa("Lewis Hamilton", new DateTime(1985,1,7)), 1000, "Piloto", 15);
lewis.IdFuncionario = 1;
mercedes.AddFuncionario(lewis);
mercedes.AddFuncionario(FuncionarioFactory.Create(new Pessoa("George Russell"), 1000));
mercedes.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Valtteri Bottas"), 1000));
mercedes.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Mick Schumacher"), 1000));
mercedes.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Kimi Antonelli"), 1000));
mercedes.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Nico Rosberg"), 1000, "Piloto", 10));
mercedes.Gerente = (Gerente)FuncionarioFactory.Create(new Pessoa("Toto Wolf"), 5000, mercedes);
repository.Add(mercedes);

var ferrari = new Equipe()
{
    Nome = "Ferrari",
    IdEquipe = 2
};
ferrari.AddFuncionario(FuncionarioFactory.Create(new Pessoa("Charles Leclerc"), 1000));
ferrari.Gerente = (Gerente)FuncionarioFactory.Create(new Pessoa("Fred Vasseur"), 5000, ferrari);
repository.Add(ferrari);

GerarFolhaDePagamento gerarFolha = new GerarFolhaDePagamento(repository);

ImprimirFolha.ImprimirFolhaDePagamento(gerarFolha.Gerar(mercedes.IdEquipe));
Console.WriteLine();
Console.WriteLine();

ImprimirFolha.ImprimirFolhaDePagamento(gerarFolha.Gerar(ferrari.IdEquipe));

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("========= TRANSFERÊNCIA ==========");


lewis.DarAumentoProporcional(20);

TransferenciaService transferenciaService = new TransferenciaService();
TransferenciaEntreEquipes transferencia = new TransferenciaEntreEquipes(repository, transferenciaService);
transferencia.Transferir(1, 1, 2);

ImprimirFolha.ImprimirFolhaDePagamento(gerarFolha.Gerar(mercedes.IdEquipe));
Console.WriteLine();
Console.WriteLine();

ImprimirFolha.ImprimirFolhaDePagamento(gerarFolha.Gerar(ferrari.IdEquipe));

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadLine();