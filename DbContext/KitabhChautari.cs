using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

public class KitabhChautariDbContext : DbContext
{
    public KitabhChautariDbContext(DbContextOptions<KitabhChautariDbContext> options)
        : base(options)
    {
    }

    public DbSet<Book> Books { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(b => b.BookId);

            entity.Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(b => b.Author)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(b => b.ISBN)
                .IsRequired()
                .HasMaxLength(13);

            entity.Property(b => b.Price)
                .HasColumnType("decimal(18,2)");

            entity.Property(b => b.PublishedDate)
                .HasConversion(
                    v => v.ToUniversalTime(),
                    v => DateTime.SpecifyKind(v, DateTimeKind.Utc));

            // Optional index example
            entity.HasIndex(b => b.ISBN);
        });
    }

public DbSet<Member> Member { get; set; } = default!;

public DbSet<Staff> Staff { get; set; } = default!;

public DbSet<User> User { get; set; } = default!;

public DbSet<Admin> Admin { get; set; } = default!;
}