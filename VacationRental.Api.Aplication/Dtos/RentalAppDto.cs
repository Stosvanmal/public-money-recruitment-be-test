using VacationRental.Api.Aplication.Interfaces.Dtos;

namespace VacationRental.Api.Aplication.Dtos
{
    public class RentalAppDto:IRentalAppDto
    {
        public int Id { get; set; }
        public int Units { get; set; }
        public int PreparationTimeInDays { get; set; }
    }
}
