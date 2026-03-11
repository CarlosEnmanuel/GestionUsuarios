namespace GestionUsuarios.Models
{
    public class Rol
    {
        public int RolId { get; set; }
        public string Nombre { get; set; } = null!;

        public ICollection<UsuarioRol>? UsuarioRoles { get; set; }
    }
}
