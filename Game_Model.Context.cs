﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Game_Web_App
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GameDBEntities2 : DbContext
    {
        public GameDBEntities2()
            : base("name=GameDBEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Heat> Heats { get; set; }
        public virtual DbSet<Table_1> Table_1 { get; set; }
        public virtual DbSet<Table_2> Table_2 { get; set; }
        public virtual DbSet<Table_3> Table_3 { get; set; }
        public virtual DbSet<Table_5> Table_5 { get; set; }
        public virtual DbSet<Table_Housing> Table_Housing { get; set; }
        public virtual DbSet<Table_7> Table_7 { get; set; }
        public virtual DbSet<Table_Cold> Table_Cold { get; set; }
        public virtual DbSet<Table_wisdom> Table_wisdom { get; set; }
        public virtual DbSet<Table_9> Table_9 { get; set; }
    }
}
