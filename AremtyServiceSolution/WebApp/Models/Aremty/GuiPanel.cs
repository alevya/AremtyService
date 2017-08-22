using System;

namespace WebApp.Models.Aremty
{
    public class GuiPanel
    {
        public Guid GuiPanelId { get; set; }
        public Guid GuiDashboardId { get; set; }
        public string Title { get; set; }
        public int OrderSort { get; set; }
    }
}