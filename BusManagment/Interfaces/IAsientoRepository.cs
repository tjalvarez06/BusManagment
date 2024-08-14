using BusManagment.Base;
using BusManagment.Entities;


namespace BusManagment.Interfaces
{
    public interface IAsientoRepository: IBaseRepository<Asiento>
    {
        void Agregar(Asiento asiento);
        void Actualizar(Asiento asiento);
        void Remover(Asiento asiento);
        List<Asiento> TraerTodos();
        Asiento ObtenerPorId(int Id);
    }
}
