using DemoSimpleBlazorUserAndRoleManager.Models;

namespace DemoSimpleBlazorUserAndRoleManager.Services
{
    public interface IPortalService
    {
        bool AddUpdate(Portal portal);
        bool Delete(int id);
        Portal FindById(int id);
        List<Portal> GetAll(); 
    }
}