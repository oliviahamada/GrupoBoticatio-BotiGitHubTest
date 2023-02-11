using System.Collections.Generic;

namespace GrupoBoticario.Interfaces
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        List<TEntity> GetEntityList();
    }
}