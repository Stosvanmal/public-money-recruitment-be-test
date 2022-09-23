namespace VacationRental.Api.Aplication.Interfaces.Dtos
{
    public interface IRentalDto
    {
        int Id { get; set; }
        int Units { get; set; }
        int PreparationTimeInDays { get; set; }
    }
}
