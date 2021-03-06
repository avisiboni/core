﻿// <auto-generated />
using System;
using Codidact.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Codidact.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200126200313_IdentityTables")]
    partial class IdentityTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Codidact.Domain.Entities.Community", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<DateTime>("CreateDateAt")
                        .HasColumnName("create_date_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("CreatedByMemberId")
                        .HasColumnName("created_by_member_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnName("deleted_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long?>("DeletedByMemberId")
                        .HasColumnName("deleted_by_member_id")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("is_deleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnName("last_modified_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long?>("LastModifiedByMemberId")
                        .HasColumnName("last_modified_by_member_id")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("character varying(40)")
                        .HasMaxLength(40);

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("status")
                        .HasColumnType("integer")
                        .HasDefaultValue(1);

                    b.Property<string>("Tagline")
                        .IsRequired()
                        .HasColumnName("tagline")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnName("url")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id")
                        .HasName("pk_communities");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("ix_communities_name");

                    b.HasIndex("Url")
                        .IsUnique()
                        .HasName("ix_communities_url");

                    b.ToTable("communities");
                });

            modelBuilder.Entity("Codidact.Domain.Entities.Member", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("Bio")
                        .HasColumnName("bio")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateDateAt")
                        .HasColumnName("create_date_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("CreatedByMemberId")
                        .HasColumnName("created_by_member_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnName("deleted_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long?>("DeletedByMemberId")
                        .HasColumnName("deleted_by_member_id")
                        .HasColumnType("bigint");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnName("display_name")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("character varying(320)")
                        .HasMaxLength(320);

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("is_deleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsEmailVerified")
                        .HasColumnName("is_email_verified")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsFromStackExchange")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("is_from_stack_exchange")
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsSuspended")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("is_suspended")
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnName("last_modified_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long?>("LastModifiedByMemberId")
                        .HasColumnName("last_modified_by_member_id")
                        .HasColumnType("bigint");

                    b.Property<string>("Location")
                        .HasColumnName("location")
                        .HasColumnType("text");

                    b.Property<long?>("StackExchangeId")
                        .HasColumnName("stack_exchange_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("StackExchangeLastImportedAt")
                        .HasColumnName("stack_exchange_last_imported_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("StackExchangeValidatedAt")
                        .HasColumnName("stack_exchange_validated_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("SuspensionEndAt")
                        .HasColumnName("suspension_end_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id")
                        .HasName("pk_members");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasName("ix_members_email");

                    b.ToTable("members");
                });

            modelBuilder.Entity("Codidact.Domain.Entities.TrustLevel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<DateTime>("CreateDateAt")
                        .HasColumnName("create_date_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("CreatedByMemberId")
                        .HasColumnName("created_by_member_id")
                        .HasColumnType("bigint");

                    b.Property<string>("Explanation")
                        .HasColumnName("explanation")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnName("last_modified_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long?>("LastModifiedByMemberId")
                        .HasColumnName("last_modified_by_member_id")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id")
                        .HasName("pk_trust_levels");

                    b.HasIndex("Explanation")
                        .IsUnique()
                        .HasName("ix_trust_levels_explanation");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("ix_trust_levels_name");

                    b.ToTable("trust_levels");
                });

            modelBuilder.Entity("Codidact.Infrastructure.Identity.ApplicationUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnName("access_failed_count")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("concurrency_stamp")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("character varying(320)")
                        .HasMaxLength(320);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnName("email_confirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnName("lockout_enabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnName("lockout_end")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("MemberId")
                        .HasColumnName("member_id")
                        .HasColumnType("bigint");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnName("normalized_email")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnName("normalized_user_name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnName("password_hash")
                        .HasColumnType("text");

                    b.Property<string>("SecurityStamp")
                        .HasColumnName("security_stamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnName("two_factor_enabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnName("user_name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.HasIndex("MemberId")
                        .HasName("ix_users_member_id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<long>", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("concurrency_stamp")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnName("normalized_name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id")
                        .HasName("pk_roles");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnName("claim_type")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnName("claim_value")
                        .HasColumnType("text");

                    b.Property<long>("RoleId")
                        .HasColumnName("role_id")
                        .HasColumnType("bigint");

                    b.HasKey("Id")
                        .HasName("pk_role_claims");

                    b.HasIndex("RoleId");

                    b.ToTable("role_claims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnName("claim_type")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnName("claim_value")
                        .HasColumnType("text");

                    b.Property<long>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("bigint");

                    b.HasKey("Id")
                        .HasName("pk_user_claims");

                    b.HasIndex("UserId");

                    b.ToTable("user_claims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnName("login_provider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnName("provider_key")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnName("provider_display_name")
                        .HasColumnType("text");

                    b.Property<long>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("bigint");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("user_logins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("bigint");

                    b.Property<long>("RoleId")
                        .HasColumnName("role_id")
                        .HasColumnType("bigint");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("user_roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("bigint");

                    b.Property<string>("LoginProvider")
                        .HasColumnName("login_provider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnName("value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("user_tokens");
                });

            modelBuilder.Entity("Codidact.Infrastructure.Identity.ApplicationUser", b =>
                {
                    b.HasOne("Codidact.Domain.Entities.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .HasConstraintName("fk_users_members_member_id");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<long>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.HasOne("Codidact.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.HasOne("Codidact.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<long>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Codidact.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.HasOne("Codidact.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
