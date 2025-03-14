﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LSC.ResterauntTableBookingApp.Data.ModelTemp;

public partial class RestaurantTableBookingContext : DbContext
{
    public RestaurantTableBookingContext()
    {
    }

    public RestaurantTableBookingContext(DbContextOptions<RestaurantTableBookingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DiningTable> DiningTables { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<Restaurant> Restaurants { get; set; }

    public virtual DbSet<RestaurantBranch> RestaurantBranches { get; set; }

    public virtual DbSet<TimeSlot> TimeSlots { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:drewanother.database.windows.net,1433;Initial Catalog=RestaurantTableBooking;Persist Security Info=False;User ID=DrewisAdmin;Password=25Bluebird1$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.Property(e => e.ReminderSent).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
