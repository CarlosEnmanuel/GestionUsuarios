using GestionUsuarios.Models;
namespace GestionUsuarios.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<Usuario>> GetAll();
        Task<Usuario?> GetById(int id);
        Task<Usuario> Create(Usuario user);
        Task<bool> Delete(int id);
    }
}
