using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MiddleWare.Models;
using System.Web.Http;

namespace MiddleWare.Controllers
{
    public class ApplicationController : ApiController
    {
        List<Application> applications = new List<Application>
        {
            new Application
            {
                Id = 1,
                Name = "Application (A)",
                CreationDateTime = new DateTime(2024, 12, 3, 12, 34, 23), // Ano, Mês, Dia, Hora, Minuto, Segundo
                Containers = new List<Container>
                {
                    new Container { Id = 1, Name = "Container 1" },
                    new Container { Id = 2, Name = "Container 2" }
                }
            },
            new Application
            {
                Id = 2,
                Name = "Application (B)",
                CreationDateTime = new DateTime(2024, 12, 3, 12, 34, 23),
                Containers = new List<Container>
                {
                    new Container { Id = 3, Name = "Container 3" },
                    new Container { Id = 4, Name = "Container 4" }
                }
            }
        };

        public ICollection<Container> Containers { get; set; } = new List<Container>();

        public IEnumerable<Application> GetAllApplications() { return applications; }

        public IHttpActionResult GetProduct(int id)
        {
            var application = applications.FirstOrDefault((a) => a.Id == id);
            if (application == null)
            {
                return NotFound();
            }
            return Ok(application);

        List<Container> containers = new List<Container> {
            new Container { }
        };

       
    }
}