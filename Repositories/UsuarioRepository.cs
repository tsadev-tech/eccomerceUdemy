using eCommerce.api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.api.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private List<Usuario> _db = new List<Usuario>()
        {
        new Usuario() {Id = 1, Nome="Jonathan Gaviao", email="gaviao@gmail.com"},
        new Usuario() {Id = 2, Nome="Jhonny Caroninha", email="caroninha@gmail.com"},
        new Usuario() {Id = 3, Nome="Tiago Andrade", email="andrade@gmail.com"}
        };
        public Usuario GetUsuarioById(int id)
        {
            return _db.FirstOrDefault(a => a.Id == id);
        }

        public List<Usuario> Get()
        {
            return _db;
        }

        public void insert(Usuario usuario)
        {
            var ultimoUsuario = _db.LastOrDefault();
            if(ultimoUsuario == null)
            {
                usuario.Id = 1;
            }
            else
            {
                usuario.Id = ultimoUsuario.Id;
                usuario.Id++;
            }
            _db.Add(usuario);
        }

        public void update(Usuario usuario)
        {
           _db.Remove(_db.FirstOrDefault(a => a.Id == usuario.Id));
           _db.Add(usuario);
        }
        public void delete(int id)
        {
            _db.Remove(_db.FirstOrDefault(a => a.Id == id));
        }
    }
}
