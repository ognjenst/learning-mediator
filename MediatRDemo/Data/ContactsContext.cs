using Microsoft.EntityFrameworkCore;

namespace MediatRDemo.Data;

public class ContactsContext : DbContext
{
    public ContactsContext(DbContextOptions<ContactsContext> options) : base(options)
    {
    }

    public DbSet<Contact> Contacts { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contact>().HasData(
            new Contact{ Id = 1, FirstName = "John", LastName = " Doe"},
            new Contact{ Id = 2, FirstName = "Jane", LastName = "Doe"},
            new Contact{ Id = 3, FirstName = "Joe", LastName = "Doe"});
    }
}

public class Contact
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}