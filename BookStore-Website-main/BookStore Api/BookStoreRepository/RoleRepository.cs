/*sing BookStoreModels.Models;
using BookStoreModels.ViewModels;
using BookStoreRepository;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repository
{
    public class RoleRepository : BaseRepository
    {

        public ListResponse<Role> GetRoles(int pageIndex = 1, int pageSize = 10, string? keyword="")
        {
            keyword = keyword?.ToLower()?.Trim();
            var query = _context.Roles.Where(c => keyword == null || c.Name.ToLower().Contains(keyword) ).AsQueryable();
            int totalReocrds = query.Count();
            List<Role> rol = query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            return new ListResponse<Role>()
            {
                Records = rol,
                TotalRecords = totalReocrds,
            };

        }
    }
}*/
