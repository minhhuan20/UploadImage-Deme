﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using LoadImage.Models;

namespace LoadImage.Data
{
    public partial class ImagetestContext : DbContext
    {
        public ImagetestContext()
        {
        }

        public ImagetestContext(DbContextOptions<ImagetestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Img> Img { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Img>(entity =>
            {
                entity.Property(e => e.ImgId).ValueGeneratedNever();

                entity.Property(e => e.Imgname).HasMaxLength(60);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}