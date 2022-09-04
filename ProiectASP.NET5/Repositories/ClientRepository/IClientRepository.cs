using ProiectASP.NET5.Entities;
using ProiectASP.NET5.Repositories.GenericRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProiectASP.NET5.Repositories.ClientRepository
{
    public interface IClientRepository : IGenericRepository<Client>
    {
        Task<Client> GetByName(string name);
        Task<List<Client>> GetAllClientsByAge(int id);
    }
}
