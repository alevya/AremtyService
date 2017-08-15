﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class GuiPanel
    {
        public Guid GuiPanelId { get; set; }
        public Guid GuiDashboardId { get; set; }
        public string Title { get; set; }
        public int OrderSort { get; set; }
    }
}