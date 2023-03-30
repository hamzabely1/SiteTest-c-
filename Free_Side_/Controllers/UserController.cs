using Api.FreeSide.Business.Model.Item;
using Api.FreeSide.Business.Service.Contact;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Free_Side_.Controllers
   
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private IServiceUser _serviceUser;

        public UserController(IServiceUser serviceEtudiant)
        {
            _serviceUser = serviceEtudiant;
        }

        
        
    }
}
