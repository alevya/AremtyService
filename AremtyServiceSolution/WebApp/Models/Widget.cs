using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Widget
    {
        public Guid WidgetId { get; set; }
        public Guid GuiPanelId { get; set; }
        public string DisplayName { get; set; }
        public string Alias { get; set; }
        public int OrderSort { get; set; }
    }
}