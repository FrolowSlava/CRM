using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dal.DbModels;

public partial class DefaultDbContext : DbContext
{
    public DefaultDbContext()
    {
    }

    public DefaultDbContext(DbContextOptions<DefaultDbContext> options)
        : base(options)
    {
    }

	public virtual DbSet<User> Users { get; set; }

	public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<DescriptionServi> DescriptionServis { get; set; }

    public virtual DbSet<Detail> Details { get; set; }

    public virtual DbSet<DetailsOnOrder> DetailsOnOrders { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Servi> Servis { get; set; }

    public virtual DbSet<TypePay> TypePays { get; set; }

    public virtual DbSet<Worker> Workers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-MOVS0FA\\SQLEXPRESS;Initial Catalog=Cars;Integrated security=true;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.CarId).HasName("PK__car__4C9A0DB3D20321FB");

            entity.ToTable("car");

            entity.Property(e => e.CarId)
                .ValueGeneratedNever()
                .HasColumnName("car_id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.Mileage).HasColumnName("mileage");
            entity.Property(e => e.Model)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("model");
            entity.Property(e => e.Year)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("year");

            entity.HasOne(d => d.Client).WithMany(p => p.Cars)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK__car__client_id__656C112C");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.ClientId).HasName("PK__client__BF21A4246EED77AB");

            entity.ToTable("client");

            entity.Property(e => e.ClientId)
                .ValueGeneratedNever()
                .HasColumnName("client_id");
            entity.Property(e => e.BonusLevel).HasColumnName("bonusLevel");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Order)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("order");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.SpentSum).HasColumnName("spentSum");
        });

        modelBuilder.Entity<DescriptionServi>(entity =>
        {
            entity.HasKey(e => e.DescriptionServisId).HasName("PK__descript__718450A7CF104C06");

            entity.ToTable("descriptionServis");

            entity.Property(e => e.DescriptionServisId)
                .ValueGeneratedNever()
                .HasColumnName("descriptionServis_id");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.ServisId).HasColumnName("servis_id");
            entity.Property(e => e.WorkerId).HasColumnName("worker_id");

            entity.HasOne(d => d.Order).WithMany(p => p.DescriptionServis)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__descripti__order__6A30C649");

            entity.HasOne(d => d.Servis).WithMany(p => p.DescriptionServis)
                .HasForeignKey(d => d.ServisId)
                .HasConstraintName("FK__descripti__servi__693CA210");

            entity.HasOne(d => d.Worker).WithMany(p => p.DescriptionServis)
                .HasForeignKey(d => d.WorkerId)
                .HasConstraintName("FK__descripti__worke__6D0D32F4");
        });

        modelBuilder.Entity<Detail>(entity =>
        {
            entity.HasKey(e => e.DetailId).HasName("PK__details__38E9A22410C0F568");

            entity.ToTable("details");

            entity.Property(e => e.DetailId)
                .ValueGeneratedNever()
                .HasColumnName("detail_id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.DetailName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("detailName");
            entity.Property(e => e.Price).HasColumnName("price");
        });

        modelBuilder.Entity<DetailsOnOrder>(entity =>
        {
            entity.HasKey(e => new { e.DetailId, e.OrderId }).HasName("FK_DetailsOnOrder");

            entity.ToTable("detailsOnOrder");

            entity.Property(e => e.DetailId).HasColumnName("detail_id");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Count).HasColumnName("count");

            entity.HasOne(d => d.Detail).WithMany(p => p.DetailsOnOrders)
                .HasForeignKey(d => d.DetailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__detailsOn__detai__6C190EBB");

            entity.HasOne(d => d.Order).WithMany(p => p.DetailsOnOrders)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__detailsOn__order__6B24EA82");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__orders__46596229E3CDFDE9");

            entity.ToTable("orders");

            entity.Property(e => e.OrderId)
                .ValueGeneratedNever()
                .HasColumnName("order_id");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.TypePayId).HasColumnName("typePay_id");
            entity.Property(e => e.WorkStatus)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("workStatus");

            entity.HasOne(d => d.Car).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CarId)
                .HasConstraintName("FK__orders__car_id__6754599E");

            entity.HasOne(d => d.Client).WithMany(p => p.Orders)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK__orders__client_i__66603565");

            entity.HasOne(d => d.TypePay).WithMany(p => p.Orders)
                .HasForeignKey(d => d.TypePayId)
                .HasConstraintName("FK__orders__typePay___68487DD7");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RolesId).HasName("PK__roles__9413A4C0127C1C4C");

            entity.ToTable("roles");

            entity.Property(e => e.RolesId)
                .ValueGeneratedNever()
                .HasColumnName("roles_id");
            entity.Property(e => e.RoleName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("roleName");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<Servi>(entity =>
        {
            entity.HasKey(e => e.ServisId).HasName("PK__servis__DA76989152988B7C");

            entity.ToTable("servis");

            entity.Property(e => e.ServisId)
                .ValueGeneratedNever()
                .HasColumnName("servis_id");
            entity.Property(e => e.ExecutionTime).HasColumnName("executionTime");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
        });

        modelBuilder.Entity<TypePay>(entity =>
        {
            entity.HasKey(e => e.TypePayId).HasName("PK__typePay__0AF8E3DDCFCF7E20");

            entity.ToTable("typePay");

            entity.Property(e => e.TypePayId)
                .ValueGeneratedNever()
                .HasColumnName("typePay_id");
            entity.Property(e => e.ByCard).HasColumnName("byCard");
            entity.Property(e => e.ByCash).HasColumnName("byCash");
        });

        modelBuilder.Entity<Worker>(entity =>
        {
            entity.HasKey(e => e.WorkerId).HasName("PK__workers__569F80071F5B0B8A");

            entity.ToTable("workers");

            entity.Property(e => e.WorkerId)
                .ValueGeneratedNever()
                .HasColumnName("worker_id");
            entity.Property(e => e.IsBusy).HasColumnName("isBusy");
            entity.Property(e => e.RolesId).HasColumnName("roles_id");
            entity.Property(e => e.WorkerName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("workerName");

            entity.HasOne(d => d.Roles).WithMany(p => p.Workers)
                .HasForeignKey(d => d.RolesId)
                .HasConstraintName("FK__workers__roles_i__6E01572D");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
