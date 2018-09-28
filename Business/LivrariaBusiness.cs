using Business.DTO;
using Business;
using Model.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Business
{
    public class LivrariaBusiness
    {


        LivrariaRepository service = new LivrariaRepository();


        public List<LivroDTO> ObterLivros()
        {
            return service.ObterLivros().Select(p =>
            new DTO.LivroDTO
            {
                Id = p.Id,
                Autor = p.Autor,
                Titulo = p.Titulo,
                Valor = p.Valor,


            }).ToList();

        }

        public List<TemaLivroDTO> ObterTemas()
        {

            var listaTema = service.ObterLivros().Select(p => new TemaLivroDTO
            {
                Id = p.Tema.Id,
                Descricao = p.Tema.Descricao             

            }).ToList();

            return listaTema.Distinct().ToList();
        
        }
           

        public List<LivroDTO> PesquisarLivros(string consulta, int valor)
        {
            var pesquisaLivros = service.ObterLivros().Select(p => new DTO.LivroDTO
            {
                Autor = p.Autor,
                Titulo = p.Titulo,
                Valor = p.Valor,
                Tema = new TemaLivroDTO { Id = p.Tema.Id, Descricao = p.Tema.Descricao }

            }).ToList();

            if (valor == 5)
            {
                return pesquisaLivros.Where(p => consulta == p.Tema.Descricao).ToList();
            }
            else
            {
                return pesquisaLivros.Where(p => consulta == p.Autor).ToList();
            }

        }



    }




}



