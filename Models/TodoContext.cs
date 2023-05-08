using Microsoft.EntityFrameworkCore;
using todolistapi.Models;

public class TodoContext : DbContext{

    public TodoContext(DbContextOptions<TodoContext> options):base(options)
    {}

    public DbSet<TodoItem> Todoitems{get;set;}=null!;
    
}