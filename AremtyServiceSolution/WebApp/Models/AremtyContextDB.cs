﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class AremtyContextDb : DbContext
    {
        #region Init

        public AremtyContextDb() : base("AremtyConnection")
        {
            
        }

        public DbSet<GuiDashboard> GuiDashboards { get; set; }
        public DbSet<GuiPanel> GuiPanel { get; set; }
        public DbSet<Widget> Widgets { get; set; }

        #endregion

    }
}