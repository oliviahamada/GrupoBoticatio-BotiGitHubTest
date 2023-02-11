using AutoMapper;
using GrupoBoticario.Models;

namespace GrupoBoticatio.MapperConfiguration
{
    public class ViewModelMapping : Profile
    {
        public ViewModelMapping()
        {
            CreateMap<RepositoriesLanguages, RepositoryDetailModel>().PreserveReferences();
            //CreateMap<RepositoriesItemsDetails, RepositoriesItemsDetailsModel>().PreserveReferences();
        }
    }
}