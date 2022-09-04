using Microsoft.EntityFrameworkCore;
using Proiect_asp.net.Repositories.GenericRepository;
using ProiectASP.NET5.Entities;
using ProiectASP.NET5.net.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectASP.NET5.Repositories.ClientRepository
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(Context context) : base(context)
        {
        }

        public async Task<List<Client>> GetAllClientsByAge(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Client> GetByName(string name)
        {
            return await _context.Clients.Where(c => c.Name.Equals(name)).FirstOrDefaultAsync();
        }
    }
}
