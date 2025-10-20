using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Tkachev_WPFapp.Models;

namespace Tkachev_WPFapp.Data;

public partial class Context : DbContext
{
    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Manager> Managers { get; set; }

    public virtual DbSet<Master> Masters { get; set; }

    public virtual DbSet<Operator> Operators { get; set; }

    public virtual DbSet<Part> Parts { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<RequestPart> RequestParts { get; set; }

    public virtual DbSet<RequestStatus> RequestStatuses { get; set; }

    public virtual DbSet<TechModel> TechModels { get; set; }

    public virtual DbSet<TechType> TechTypes { get; set; }
    public Context()
    {
        Requests.Load();
    }

    public Context(DbContextOptions<Context> options)
        : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DBSRV\\vip2024;Database=ReAA_BD2;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__client__3214EC078F6C0DA9");

            entity.ToTable("client");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Login).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(255);
        });

        modelBuilder.Entity<Manager>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__manager__3214EC078BE4A250");

            entity.ToTable("manager");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Login).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(255);
        });

        modelBuilder.Entity<Master>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__master__3214EC072F99F75B");

            entity.ToTable("master");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Login).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(255);
        });

        modelBuilder.Entity<Operator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__operator__3214EC075AD06AE6");

            entity.ToTable("operator");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Login).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(255);
        });

        modelBuilder.Entity<Part>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__parts__3214EC0713941764");

            entity.ToTable("parts");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Value).HasMaxLength(255);
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__request__3214EC07FFF10B30");

            entity.ToTable("request");

            entity.Property(e => e.ClientId).HasColumnName("clientId");
            entity.Property(e => e.CompletionDate).HasColumnName("completionDate");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.StartDate).HasColumnName("startDate");
            entity.Property(e => e.StatusId).HasColumnName("statusId");
            entity.Property(e => e.TechModelId).HasColumnName("techModelId");

            entity.HasOne(d => d.Client).WithMany(p => p.Requests)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK__request__clientI__60A75C0F");

            entity.HasOne(d => d.Status).WithMany(p => p.Requests)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK__request__statusI__5FB337D6");

            entity.HasOne(d => d.TechModel).WithMany(p => p.Requests)
                .HasForeignKey(d => d.TechModelId)
                .HasConstraintName("FK__request__techMod__5EBF139D");
        });

        modelBuilder.Entity<RequestPart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__requestP__3214EC07C4916103");

            entity.ToTable("requestParts");

            entity.Property(e => e.PartId).HasColumnName("partId");
            entity.Property(e => e.RequestId).HasColumnName("requestId");

            entity.HasOne(d => d.Part).WithMany(p => p.RequestParts)
                .HasForeignKey(d => d.PartId)
                .HasConstraintName("FK__requestPa__partI__6477ECF3");

            entity.HasOne(d => d.Request).WithMany(p => p.RequestParts)
                .HasForeignKey(d => d.RequestId)
                .HasConstraintName("FK__requestPa__reque__6383C8BA");
        });

        modelBuilder.Entity<RequestStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__requestS__3214EC07499304E6");

            entity.ToTable("requestStatus");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Value).HasMaxLength(255);
        });

        modelBuilder.Entity<TechModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__techMode__3214EC07D3BD5F9A");

            entity.ToTable("techModel");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TechTypeId).HasColumnName("techTypeId");
            entity.Property(e => e.Value).HasMaxLength(255);

            entity.HasOne(d => d.TechType).WithMany(p => p.TechModels)
                .HasForeignKey(d => d.TechTypeId)
                .HasConstraintName("FK__techModel__techT__5165187F");
        });

        modelBuilder.Entity<TechType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__techType__3214EC075906CB1E");

            entity.ToTable("techType");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Value).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
