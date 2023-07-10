using Microsoft.EntityFrameworkCore;
using NoteBox.Domain.Entities;

namespace NoteBox.Dal;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {

    }

    public readonly DbSet<Note> Notes = null!;
    public readonly DbSet<User> Users = null!;
}
