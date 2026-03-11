using GestionUsuarios.Data;
using GestionUsuarios.Interfaces;
using GestionUsuarios.Models;
using Microsoft.EntityFrameworkCore;

public class UserService : IUserService
{
    private readonly AppDbContext _context;

    public UserService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Usuario>> GetAll()
    {
        return await _context.Usuarios
            .Where(u => !u.Eliminado)
            .ToListAsync();
    }

    public async Task<Usuario?> GetById(int id)
    {
        return await _context.Usuarios.FindAsync(id);
    }

    public async Task<Usuario> Create(Usuario user)
    {
        _context.Usuarios.Add(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task<bool> Delete(int id)
    {
        var user = await _context.Usuarios.FindAsync(id);
        if (user == null) return false;

        user.Eliminado = true;
        await _context.SaveChangesAsync();
        return true;
    }
}