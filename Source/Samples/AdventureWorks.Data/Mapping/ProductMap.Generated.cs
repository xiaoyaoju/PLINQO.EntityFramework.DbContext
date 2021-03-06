﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureWorks.Data.Mapping
{
    public partial class ProductMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AdventureWorks.Data.Entities.Product>
    {
        public ProductMap()
        {
            // table
            ToTable("Product", "Production");

            // keys
            HasKey(t => t.ProductID);

            // Properties
            Property(t => t.ProductID)
                .HasColumnName("ProductID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.ProductNumber)
                .HasColumnName("ProductNumber")
                .HasMaxLength(25)
                .IsRequired();
            Property(t => t.MakeFlag)
                .HasColumnName("MakeFlag")
                .IsRequired();
            Property(t => t.FinishedGoodsFlag)
                .HasColumnName("FinishedGoodsFlag")
                .IsRequired();
            Property(t => t.Color)
                .HasColumnName("Color")
                .HasMaxLength(15)
                .IsOptional();
            Property(t => t.SafetyStockLevel)
                .HasColumnName("SafetyStockLevel")
                .IsRequired();
            Property(t => t.ReorderPoint)
                .HasColumnName("ReorderPoint")
                .IsRequired();
            Property(t => t.StandardCost)
                .HasColumnName("StandardCost")
                .HasPrecision(19, 4)
                .IsRequired();
            Property(t => t.ListPrice)
                .HasColumnName("ListPrice")
                .HasPrecision(19, 4)
                .IsRequired();
            Property(t => t.Size)
                .HasColumnName("Size")
                .HasMaxLength(5)
                .IsOptional();
            Property(t => t.SizeUnitMeasureCode)
                .HasColumnName("SizeUnitMeasureCode")
                .HasMaxLength(3)
                .IsOptional();
            Property(t => t.WeightUnitMeasureCode)
                .HasColumnName("WeightUnitMeasureCode")
                .HasMaxLength(3)
                .IsOptional();
            Property(t => t.Weight)
                .HasColumnName("Weight")
                .HasPrecision(8, 2)
                .IsOptional();
            Property(t => t.DaysToManufacture)
                .HasColumnName("DaysToManufacture")
                .IsRequired();
            Property(t => t.ProductLine)
                .HasColumnName("ProductLine")
                .HasMaxLength(2)
                .IsOptional();
            Property(t => t.Class)
                .HasColumnName("Class")
                .HasMaxLength(2)
                .IsOptional();
            Property(t => t.Style)
                .HasColumnName("Style")
                .HasMaxLength(2)
                .IsOptional();
            Property(t => t.ProductSubcategoryID)
                .HasColumnName("ProductSubcategoryID")
                .IsOptional();
            Property(t => t.ProductModelID)
                .HasColumnName("ProductModelID")
                .IsOptional();
            Property(t => t.SellStartDate)
                .HasColumnName("SellStartDate")
                .IsRequired();
            Property(t => t.SellEndDate)
                .HasColumnName("SellEndDate")
                .IsOptional();
            Property(t => t.DiscontinuedDate)
                .HasColumnName("DiscontinuedDate")
                .IsOptional();
            Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            HasOptional(t => t.ProductModel)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.ProductModelID)
                .WillCascadeOnDelete(false);
            HasOptional(t => t.ProductSubcategory)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.ProductSubcategoryID)
                .WillCascadeOnDelete(false);
            HasOptional(t => t.SizeUnitMeasure)
                .WithMany(t => t.SizeProducts)
                .HasForeignKey(d => d.SizeUnitMeasureCode)
                .WillCascadeOnDelete(false);
            HasOptional(t => t.WeightUnitMeasure)
                .WithMany(t => t.WeightProducts)
                .HasForeignKey(d => d.WeightUnitMeasureCode)
                .WillCascadeOnDelete(false);
            HasMany(t => t.ProductPhotos)
                .WithMany(t => t.Products)
                .Map(m =>
                {
                    m.ToTable("ProductProductPhoto", "Production");
                    m.MapLeftKey("ProductID");
                    m.MapRightKey("ProductPhotoID");
                });
            HasMany(t => t.SpecialOffers)
                .WithMany(t => t.Products)
                .Map(m =>
                {
                    m.ToTable("SpecialOfferProduct", "Sales");
                    m.MapLeftKey("ProductID");
                    m.MapRightKey("SpecialOfferID");
                });

            InitializeMapping();
        }
    }
}
