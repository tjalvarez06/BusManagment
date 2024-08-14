

using BusManagment.Base;

namespace BusManagment.Entities
{
    public class Asiento : BaseEntity<int>
    {
        
        public int BusId { get; set; }
        public int NumeroPiso { get; set; }
        public int NumeroAsiento { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
