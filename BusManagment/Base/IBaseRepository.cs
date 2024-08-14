using BusManagment.Entities;

namespace BusManagment.Base
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Agregar(TEntity entity);
        void Actualizar(TEntity entity);
        void Remover(TEntity entity);
        List<TEntity> TraerTodos();
        TEntity ObtenerPorId(int Id);
    }
}
