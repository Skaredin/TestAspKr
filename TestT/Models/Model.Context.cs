﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestT.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TestAspEntities1 : DbContext
    {
        public TestAspEntities1()
            : base("name=TestAspEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<Accounts_Roles> Accounts_Roles { get; set; }
        public virtual DbSet<Accounts_RolesHB> Accounts_RolesHB { get; set; }
        public virtual DbSet<Accounts_Users> Accounts_Users { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Dolgnost> Dolgnost { get; set; }
        public virtual DbSet<Menu_Category> Menu_Category { get; set; }
        public virtual DbSet<Menu_Items> Menu_Items { get; set; }
        public virtual DbSet<Menu_Items_in_category> Menu_Items_in_category { get; set; }
        public virtual DbSet<Menu_Roles> Menu_Roles { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<TestToUser> TestToUser { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Help_Roles> Help_Roles { get; set; }
    }
}