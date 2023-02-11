using GrupoBoticario.Models;
using GrupoBoticatio;
using System.Collections.Generic;

namespace GrupoBoticario.Interfaces
{
    public interface IRepositoryService : IServiceBase<RepositoriesLanguages>
    {
        List<RepositoryDetailModel> RequestRepositoriesDetail(string id, int page);
    }
}
