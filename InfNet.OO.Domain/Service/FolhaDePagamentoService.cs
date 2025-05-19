using InfNet.OO.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.OO.Domain.Service
{
    public static class FolhaDePagamentoService
    {
        public static FolhaDePagamentoDto GerarFolha(Equipe equipe)
        {
            var result = new FolhaDePagamentoDto()
            {
                Area = equipe.Nome,
                Gerente = equipe.Gerente.Pessoa.Nome,
                TamanhoDoTime = equipe.GetTime().Count(),
                ValorTotal = equipe.GetValorTotal(),
                Itens = [.. equipe.GetTime().Select(f => new FolhaDePagamentoItemDto()
                {
                    Nome = f.Pessoa.Nome,
                    SalarioBase = f.SalarioBase,
                    Bonus = f.Bonus(),
                    SalarioFinal = f.GetSalarioComBonus()
                })]
            };

            result.Itens.Insert(0, new()
            {
                Nome = equipe.Gerente.Pessoa.Nome,
                SalarioBase = equipe.Gerente.SalarioBase,
                Bonus = equipe.Gerente.Bonus(),
                SalarioFinal = equipe.Gerente.GetSalarioComBonus()
            });

            return result;
        }


    }
}
