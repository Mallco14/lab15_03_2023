using APIText.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace APIText.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PeopleController : Controller
    {
        [Authorize]
        [HttpGet(Name = "Get")]

        public IEnumerable<PersonResponse> Get()
        {
            List<PersonResponse> personas = new List<PersonResponse>(); 

            for (int i = 0; i <= 100; i++) { 
                PersonResponse persona = new PersonResponse();
                    persona.FirstName = "Persona" + i;
                    persona.LastName = "Apellido" + i;

                    personas.Add(persona);
        
                }
            return personas;
        
        }

        
    }
}
