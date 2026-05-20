using e_declare.Models;
using Microsoft.EntityFrameworkCore;

namespace e_declare.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Usuario> Usuarios => Set<Usuario>();
    public DbSet<TipoUsuario> TiposUsuario => Set<TipoUsuario>();
    public DbSet<TipoIdentificacion> TiposIdentificacion => Set<TipoIdentificacion>();
    public DbSet<Role> Roles => Set<Role>();
    public DbSet<Menu> Menus => Set<Menu>();
    public DbSet<RolMenu> RolMenus => Set<RolMenu>();
    public DbSet<LogInicioSesion> LogsInicioSesion => Set<LogInicioSesion>();
    public DbSet<Auditoria> Auditorias => Set<Auditoria>();
    public DbSet<BlacklistIP> BlacklistIPs => Set<BlacklistIP>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Clave compuesta para ROL_MENU
        modelBuilder.Entity<RolMenu>()
            .HasKey(rm => new { rm.IDROL, rm.IDMENU });

        // Evitar ciclos de cascada en self-reference de Menu
        modelBuilder.Entity<Menu>()
            .HasOne(m => m.MenuPadre)
            .WithMany(m => m.SubMenus)
            .HasForeignKey(m => m.IDMENUPADRE)
            .OnDelete(DeleteBehavior.Restrict);

        base.OnModelCreating(modelBuilder);
    }
}