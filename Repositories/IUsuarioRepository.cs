using eCommerce.api.Models;

namespace eCommerce.api.Repositories
{
    public interface IUsuarioRepository
    {
        public List<Usuario> Get();
        public Usuario GetUsuarioById(int id);
        public void insert(Usuario usuario);
        public void update(Usuario usuario);
        public void delete(int id);
    }
}
