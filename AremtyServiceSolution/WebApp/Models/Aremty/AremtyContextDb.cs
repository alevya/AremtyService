using System.Data.Entity;

namespace WebApp.Models.Aremty
{
    public class AremtyContextDb : DbContext
    {
        #region Init

        public AremtyContextDb() : base("AremtyDb")
        { }

        public DbSet<GuiDashboard> GuiDashboards { get; set; }
        public DbSet<GuiPanel> GuiPanels { get; set; }
        public DbSet<Widget> Widgets { get; set; }

        #endregion

    }
}