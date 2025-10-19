using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Tkachev_WPFapp.Models;

namespace Tkachev_WPFapp.Data;

public partial class Context : DbContext
{
    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Manager> Managers { get; set; }

    public virtual DbSet<Master> Masters { get; set; }

    public virtual DbSet<Operator> Operators { get; set; }

    public virtual DbSet<Part> Parts { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<RequestStatus> RequestStatuses { get; set; }

    public virtual DbSet<RequestsPart> RequestsParts { get; set; }

    public virtual DbSet<TechModel> TechModels { get; set; }

    public virtual DbSet<TechType> TechTypes { get; set; }

    public Context()
    {
        Requests.Load();
        Comments.Load();
    }

    public Context(DbContextOptions<Context> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=ARTHUR\\SQLEXPRESS;Database=Tkachev_DB;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__client__3214EC070FA49E25");

            entity.ToTable("client");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Login).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(255);
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__comments__3214EC07C40211BF");

            entity.ToTable("comments");

            entity.Property(e => e.MasterId).HasColumnName("masterId");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .HasColumnName("message");
            entity.Property(e => e.RequestId).HasColumnName("requestId");

            entity.HasOne(d => d.Master).WithMany(p => p.Comments)
                .HasForeignKey(d => d.MasterId)
                .HasConstraintName("FK__comments__master__787EE5A0");

            entity.HasOne(d => d.Request).WithMany(p => p.Comments)
                .HasForeignKey(d => d.RequestId)
                .HasConstraintName("FK__comments__reques__797309D9");
        });

        modelBuilder.Entity<Manager>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__manager__3214EC07273024A0");

            entity.ToTable("manager");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Login).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(255);
        });

        modelBuilder.Entity<Master>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__master__3214EC0787AA028D");

            entity.ToTable("master");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Login).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(255);
        });

        modelBuilder.Entity<Operator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__operator__3214EC0718AA910D");

            entity.ToTable("operator");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Login).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(255);
        });

        modelBuilder.Entity<Part>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__parts__3214EC07C5A71D8D");

            entity.ToTable("parts");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Value).HasMaxLength(255);
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__requests__3214EC076EAFE210");

            entity.ToTable("requests");

            entity.Property(e => e.ClientId).HasColumnName("clientId");
            entity.Property(e => e.CompletionDate).HasColumnName("completionDate");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.StartDate).HasColumnName("startDate");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TechModel).HasColumnName("techModel");

            entity.HasOne(d => d.Client).WithMany(p => p.Requests)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK__requests__client__71D1E811");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.Requests)
                .HasForeignKey(d => d.Status)
                .HasConstraintName("FK__requests__status__70DDC3D8");

            entity.HasOne(d => d.TechModelNavigation).WithMany(p => p.Requests)
                .HasForeignKey(d => d.TechModel)
                .HasConstraintName("FK__requests__techMo__6FE99F9F");
        });

        modelBuilder.Entity<RequestStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__requestP__3214EC078A6A6171");

            entity.ToTable("requestStatus");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Value).HasMaxLength(255);
        });

        modelBuilder.Entity<RequestsPart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__requests__3214EC07E1D0A98B");

            entity.ToTable("requestsParts");

            entity.Property(e => e.PartId).HasColumnName("partId");
            entity.Property(e => e.RequestId).HasColumnName("requestId");

            entity.HasOne(d => d.Part).WithMany(p => p.RequestsParts)
                .HasForeignKey(d => d.PartId)
                .HasConstraintName("FK__requestsP__partI__75A278F5");

            entity.HasOne(d => d.Request).WithMany(p => p.RequestsParts)
                .HasForeignKey(d => d.RequestId)
                .HasConstraintName("FK__requestsP__reque__74AE54BC");
        });

        modelBuilder.Entity<TechModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__techMode__3214EC071CF8227B");

            entity.ToTable("techModel");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TechTypeId).HasColumnName("techTypeId");
            entity.Property(e => e.Value).HasMaxLength(255);

            entity.HasOne(d => d.TechType).WithMany(p => p.TechModels)
                .HasForeignKey(d => d.TechTypeId)
                .HasConstraintName("FK__techModel__techT__3D5E1FD2");
        });

        modelBuilder.Entity<TechType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__techType__3214EC0791D464FF");

            entity.ToTable("techType");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Value).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
