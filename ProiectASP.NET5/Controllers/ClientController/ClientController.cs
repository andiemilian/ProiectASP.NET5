using ProiectASP.NET5.Entities;
using ProiectASP.NET5.Entities.DTOs;
using ProiectASP.NET5.Repositories.ClientRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAW_Lab2_Sgr15.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IClientRepository _repository;
        public AuthorController(IClientRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAuthors()
        {


            var clientsToReturn = new List<ClientDTO>();

            foreach (var client in clients)
            {
                clientsToReturn.Add(new ClientDTO(client));
            }

            return Ok(clientsToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthorById(int id)
        {
            var client = await _repository.GetByIdWithAddress(id);

            return Ok(new ClientDTO(client));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            var client = await _repository.GetByIdAsync(id);

            if (client == null)
            {
                return NotFound("Client does not exist!");
            }

            _repository.Delete(client);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuthor(CreateClientDTO dto)
        {
            Client newAuthor = new Client();

            newClient.Name = dto.Name;
            newClient.Id = dto.Address;

            _repository.Create(newAuthor);

            await _repository.SaveAsync();


            return Ok(new ClientDTO(newAuthor));
        }
    }
}
