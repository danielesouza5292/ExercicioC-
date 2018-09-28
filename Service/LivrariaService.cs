using Business;
using Business.DTO;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class LivrariaService
    {
        LivrariaBusiness business = new LivrariaBusiness();

        public List<LivroDTO> ObterLivros()
        {
            return business.ObterLivros();
        }

        public List<LivroDTO> ObterAutores()
        {
            return business.ObterLivros();
        }

        public List<TemaLivroDTO> ObterTemas()
        {
            return business.ObterTemas();
        }

        public List<LivroDTO> PesquisaLivros(string consulta, int valor)
        {

            return business.PesquisarLivros(consulta, valor);
           
        }
    }
}
