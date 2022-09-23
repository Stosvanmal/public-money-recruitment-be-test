using VacationRental.Api.Business.Interfaces;

namespace VacationRental.Api.Business.Entities
{
    public class Rental: IEntities
    {
        public int Id { get; set; }
        public int Units { get; set; }
        public int PreparationTimeInDays { get; set; }
    }
}
