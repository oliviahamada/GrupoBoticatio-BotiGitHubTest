using GrupoBoticatio.Context;
using GrupoBoticatio.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GrupoBoticatio.Services
{
    public class RepositoryItemService : IRepositoryItemService
    {
        protected ManagerContext Db = new ManagerContext();

        public List<RepositoriesItemsDetails> GetEntityList()
        {
            var result = Db
                .RepositoriesItemsDetails.AsQueryable().ToList();

            return result;
        }
    }
}