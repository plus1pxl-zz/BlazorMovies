using BlazorMovies.Client.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Repository
{
    public class PersonRepository: IPersonRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/people";

        public PersonRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task CreatePerson(Person person)
        {
            var response = await httpService.Post(url, person);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public Task DeletePerson(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Person>> GetPeople()
        {
            var response = await httpService.Get<List<Person>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task<List<Person>> GetPeopleByName(string name)
        {
            var response = await httpService.Get<List<Person>>($"{url}/search/{name}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public Task<Person> GetPersonById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
