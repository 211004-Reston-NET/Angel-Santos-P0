/*using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace StoreDL.Entities
{
    public partial class DBp0Context : DbContext
    {
        public DBp0Context()
        {
        }

        public DBp0Context(DbContextOptions<DBp0Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<LineItem> LineItems { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual DbSet<StoreFront> StoreFronts { get; set; }
        public virtual DbSet<StoreProduct> StoreProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer");

                entity.Property(e => e.Address)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<LineItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Line_Item");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("item_name");

                entity.Property(e => e.ItemQuantity).HasColumnName("item_quantity");
            });

            modelBuilder.Entity<PurchaseOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Purchase_Order");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("item_name");

                entity.Property(e => e.ItemQuantity).HasColumnName("item_quantity");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("date")
                    .HasColumnName("order_date");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.OrderLocation)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("order_location");

                entity.Property(e => e.TotalPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("total_price");
            });

            modelBuilder.Entity<StoreFront>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StoreFront");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Product)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product");

                entity.Property(e => e.StoreNumber).HasColumnName("store_number");
            });

            modelBuilder.Entity<StoreProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Store_Product");

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("item_category");

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("item_description");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("item_name");

                entity.Property(e => e.ItemQuantity).HasColumnName("item_quantity");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("price");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

*/