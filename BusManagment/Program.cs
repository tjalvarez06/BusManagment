

using BusManagment.Base;
using BusManagment.Entities;
using BusManagment.Interfaces;
using BusManagment.Repository;


Asiento asiento = new Asiento()
{
    Id = 1,
    BusId = 1,
    NumeroPiso = 1,
    NumeroAsiento = 1,
    FechaCreacion = DateTime.Now
};

IBaseRepository<Asiento> repository = new AsientoRepository();

repository.Agregar(asiento);
var asientos = repository.TraerTodos();

asientos.ForEach(asiento =>
{
    Console.WriteLine($"Id {asiento.Id}");
    Console.WriteLine($"BusId {asiento.BusId}");
    Console.WriteLine($"Numero Piso {asiento.NumeroPiso}");
    Console.WriteLine($"Numero Asiento {asiento.NumeroAsiento}");
    Console.WriteLine($"Fecha Creacion {asiento.FechaCreacion}");

});