using InfNet.OO.Domain.Dto;

namespace InfNet.OO.ConsoleApp
{
    internal static class ImprimirFolha
    {
        public static void ImprimirFolhaDePagamento(FolhaDePagamentoDto folha)
        {
            Console.WriteLine($"Folha de Pagamento da Equipe: {folha.Area}");
            Console.WriteLine($"Gerente: {folha.Gerente}");
            Console.WriteLine($"Tamanho do Time: {folha.TamanhoDoTime}");
            foreach (var item in folha.Itens)
            {
                Console.WriteLine($"Nome: {item.Nome}, Salario Base: {item.SalarioBase}, Bonus: {item.Bonus}, Salario Final: {item.SalarioFinal}");
            }
            Console.WriteLine($"Valor Total: {folha.ValorTotal}");
        }
    }
}
