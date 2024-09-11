using CrossCutting.Contract.DataClasses;
using DavidTielke.PMA.Logic.PersonManagement;
using Microsoft.AspNetCore.Mvc;

namespace ServiceClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonManager _manager;

        public PersonsController(IPersonManager manager)
        {
            _manager = manager;
        }

        [Route("Adults")]
        [HttpGet()]
        public IEnumerable<Person> GetAllAdults()
        {
            return _manager.GetAllAdults();
        }


        [Route("Children")]
        [HttpGet()]
        public IEnumerable<Person> GetAllChildren()
        {
            return _manager.GetAllChildren();
        }
    }
}
