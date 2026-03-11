namespace GestionUsuarios.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool Eliminado { get; set; }
        public int EstadoUsuarioId { get; set; }
        public ICollection<UsuarioRol>? UsuarioRoles { get; set; }
    }
}
