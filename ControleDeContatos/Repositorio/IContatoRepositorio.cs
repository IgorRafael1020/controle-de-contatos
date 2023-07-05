using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscaTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
