using AutoMapper;

namespace GrupoBoticatio.MapperConfiguration
{
    public class MapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<ViewModelMapping>();
                x.AddProfile<ViewModelMapping>();
            });
        }
    }
}