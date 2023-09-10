using LandonPierce.Api.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LandonPierce.Api.DAL.DBContext
{
    public class LandonPierceDB : DbContext
    {
        public LandonPierceDB()
            : base("name=LandonPierceDB")
        {

        }

        //Tables
        public virtual DbSet<Test> Test { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}