using InfNet.OO.Domain.Repository;
using InfNet.OO.Domain.Service;

namespace InfNet.OO.Application
{
    public class TransferenciaEntreEquipes
    {
        private readonly IEquipeRepository _equipeRepository;
        private readonly TransferenciaService _transferenciaService;

        public TransferenciaEntreEquipes(IEquipeRepository equipeRepository, TransferenciaService transferenciaService)
        {
            _equipeRepository = equipeRepository;
            _transferenciaService = transferenciaService;
        }

        public bool Transferir(int idFuncionario, int idEquipeOrigem, int idEquipeDestino)
        {
            var equipeOrigem = _equipeRepository.ObterPorNumero(idEquipeOrigem);
            var equipeDestino = _equipeRepository.ObterPorNumero(idEquipeDestino);
            var funcionario = equipeOrigem.GetTime().FirstOrDefault(f => f.IdFuncionario == idFuncionario);

            _transferenciaService.Transferir(funcionario, equipeOrigem, equipeDestino);
            return true;
        }
    }
}
