using DemoSimpleBlazorUserAndRoleManager.Data;
using DemoSimpleBlazorUserAndRoleManager.Models;

namespace DemoSimpleBlazorUserAndRoleManager.Services
{
    public class PortalService : IPortalService
    {
        private readonly ApplicationDbContext _ctx;
        public PortalService(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public bool AddUpdate(Portal portal)
        {
            try
            {
                if (portal.Id == 0)
                    _ctx.Portal.Add(portal);
                else
                    _ctx.Portal.Update(portal);
                _ctx.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var portal = FindById(id);
                if (portal == null)
                    return false;
                _ctx.Portal.Remove(portal);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public Portal FindById(int id)
        {
            return _ctx.Portal.Find(id);
        }

        public List<Portal> GetAll()
        {
            return _ctx.Portal.ToList();
        }
    }
}