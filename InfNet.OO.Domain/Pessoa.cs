using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.OO.Domain
{
    public class Pessoa
    {
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        private List<Documento> documentos = [];

        public void AddDocumento(Documento documento)
        {
            documentos.Add(documento);
        }
        public void RemoveDocumento(Documento documento)
        {
            documentos.Remove(documento);
        }
        public List<Documento> GetDocumentos()
        {
            return documentos;
        }
    }
}
