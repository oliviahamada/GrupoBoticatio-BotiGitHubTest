using GrupoBoticario.Interfaces;
using GrupoBoticario.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GrupoBoticatio.Controllers
{
    public class RepositoryController : Controller
    {

        private IRepositoryService _repositoryService;

        public RepositoryController(IRepositoryService repositoryService)
        {
            _repositoryService = repositoryService;
        }

        public ActionResult Index()
        {
            List<RepositoriesLanguages> repositoriesLanguages = _repositoryService.GetEntityList();
            ViewBag.Data = repositoriesLanguages;
            ViewBag.Title = "Home";
            return View();
        }

        [HttpGet]
        public ActionResult Edit(string id, int page = 1)
        {
            RepositoryDetailModel repositoryDetailModel = new RepositoryDetailModel();
            repositoryDetailModel.language = id;
            repositoryDetailModel.page = page;
            repositoryDetailModel.repositoryItem = _repositoryService.RequestRepositoriesDetail(id, page);

            ViewBag.Data = repositoryDetailModel;
            ViewBag.Title = id;

            return View();
        }

        public ActionResult Privacy()
        {
            return View();
        }

        /*public ActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}