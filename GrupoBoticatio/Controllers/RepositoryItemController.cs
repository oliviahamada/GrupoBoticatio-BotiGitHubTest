using GrupoBoticatio;
using GrupoBoticatio.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace GrupoBoticario.Controllers
{
    [Route("RepositoryItem")]
    public class RepositoryItemController : Controller
    {

        private IRepositoryItemService _repositoryItemService;
        public RepositoryItemController(IRepositoryItemService repositoryItemService)
        {
            _repositoryItemService = repositoryItemService;
        }

        [HttpGet]
        public ActionResult Index(string language, int id)
        {
            List<RepositoriesItemsDetails> repositoriesLanguages = new List<RepositoriesItemsDetails>();
            repositoriesLanguages = _repositoryItemService.GetEntityList()
                .Where(x => x.Language == language && x.Id == id).ToList();
            
            ViewBag.Data = repositoriesLanguages;
            ViewBag.Title = "Detalhe";
            return View();
        }
    }
}
