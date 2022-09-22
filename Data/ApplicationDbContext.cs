using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SagarNote.Models;


namespace SagarNote.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Note>? SaagarNote{get; set;}

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}
