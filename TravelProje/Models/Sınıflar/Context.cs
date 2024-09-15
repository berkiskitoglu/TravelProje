﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelProje.Models.Sınıflar
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> hakkimizdas { get; set; }
        public DbSet<Iletisim> ıletisims { get; set; }
        public DbSet<Yorumlar> yorumlars { get; set; }
        

        
    }
}