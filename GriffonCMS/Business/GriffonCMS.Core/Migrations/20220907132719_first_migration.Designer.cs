﻿// <auto-generated />
using System;
using GriffonCMS.Core.Context.EFContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GriffonCMS.Core.Migrations
{
    [DbContext(typeof(GriffonEFContext))]
    [Migration("20220907132719_first_migration")]
    partial class first_migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GriffonCMS.Domain.Entities.About.AboutEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("About");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.Admin.AdminEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.Blog.BlogEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserEntityId");

                    b.ToTable("Blog");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.Category.CategoryEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ProjectEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SkillEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProjectEntityId");

                    b.HasIndex("SkillEntityId");

                    b.HasIndex("UserEntityId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.Comments.CommentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BlogEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BlogId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CommenterEMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommenterFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommenterMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BlogEntityId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.Contact.ContactEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ContactMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserEntityId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.Interest.InterestEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("InterestContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InterestName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserEntityId");

                    b.ToTable("Interest");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.Project.ProjectEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserEntityId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.Reference.ReferenceEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferenceFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferenceReview")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserEntityId");

                    b.ToTable("Reference");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.Skill.SkillEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SkillLevel")
                        .HasColumnType("int");

                    b.Property<string>("SkillName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserEntityId");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.Tag.TagEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TagValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.User.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("AdminId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("CVLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.WorkExperience.WorkExperienceEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserEntityId");

                    b.ToTable("WorkExperience");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.Blog.BlogEntity", b =>
                {
                    b.HasOne("GriffonCMS.Domain.Entities.User.UserEntity", null)
                        .WithMany("Blogs")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.Category.CategoryEntity", b =>
                {
                    b.HasOne("GriffonCMS.Domain.Entities.Project.ProjectEntity", null)
                        .WithMany("Categories")
                        .HasForeignKey("ProjectEntityId");

                    b.HasOne("GriffonCMS.Domain.Entities.Skill.SkillEntity", null)
                        .WithMany("Categories")
                        .HasForeignKey("SkillEntityId");

                    b.HasOne("GriffonCMS.Domain.Entities.User.UserEntity", null)
                        .WithMany("Categories")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.Comments.CommentEntity", b =>
                {
                    b.HasOne("GriffonCMS.Domain.Entities.Blog.BlogEntity", null)
                        .WithMany("Comments")
                        .HasForeignKey("BlogEntityId");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.Contact.ContactEntity", b =>
                {
                    b.HasOne("GriffonCMS.Domain.Entities.User.UserEntity", null)
                        .WithMany("Contacts")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.Interest.InterestEntity", b =>
                {
                    b.HasOne("GriffonCMS.Domain.Entities.User.UserEntity", null)
                        .WithMany("Interests")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.Project.ProjectEntity", b =>
                {
                    b.HasOne("GriffonCMS.Domain.Entities.User.UserEntity", null)
                        .WithMany("Projects")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.Reference.ReferenceEntity", b =>
                {
                    b.HasOne("GriffonCMS.Domain.Entities.User.UserEntity", null)
                        .WithMany("References")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.Skill.SkillEntity", b =>
                {
                    b.HasOne("GriffonCMS.Domain.Entities.User.UserEntity", null)
                        .WithMany("Skills")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.WorkExperience.WorkExperienceEntity", b =>
                {
                    b.HasOne("GriffonCMS.Domain.Entities.User.UserEntity", null)
                        .WithMany("WorkExperiences")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.Blog.BlogEntity", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.Project.ProjectEntity", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.Skill.SkillEntity", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("GriffonCMS.Domain.Entities.User.UserEntity", b =>
                {
                    b.Navigation("Blogs");

                    b.Navigation("Categories");

                    b.Navigation("Contacts");

                    b.Navigation("Interests");

                    b.Navigation("Projects");

                    b.Navigation("References");

                    b.Navigation("Skills");

                    b.Navigation("WorkExperiences");
                });
#pragma warning restore 612, 618
        }
    }
}