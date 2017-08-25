using System;

namespace WebApp.Models.Aremty
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