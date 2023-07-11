using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel ListarPorId(int id);
        List<UsuarioModel> BuscaTodos();
        UsuarioModel Adicionar(UsuarioModel contato);
        UsuarioModel Atualizar(UsuarioModel contato);
        bool Apagar(int id);
    }
}
