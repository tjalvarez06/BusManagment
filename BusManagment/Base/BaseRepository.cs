

namespace BusManagment.Base
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        List<TEntity> entities;

        protected BaseRepository() 
        {
            entities = new List<TEntity>();
        }
        public virtual void Actualizar(TEntity entity)
        {
            //this.entities.Remove(entity);
            this.entities.Add(entity);
        }

        public virtual void Agregar(TEntity entity)
        {
            this.entities.Add(entity);
        }

        public virtual TEntity ObtenerPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public virtual void Remover(TEntity entity)
        {
            this.entities.Remove(entity);
        }

        public virtual List<TEntity> TraerTodos()
        {
            return this.entities;
        }
    }
}
