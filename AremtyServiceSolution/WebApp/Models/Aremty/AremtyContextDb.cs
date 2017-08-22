using System.Data.Entity;
using WebApp.Models.Identity;

namespace WebApp.Models.Aremty
{
    public class AremtyContextDb : AppIdenityDbContext
    {
        #region Init

        public AremtyContextDb()
        { }

        public DbSet<GuiDashboard> GuiDashboards { get; set; }
        public DbSet<GuiPanel> GuiPanels { get; set; }
        public DbSet<Widget> Widgets { get; set; }

        #endregion

    }
}