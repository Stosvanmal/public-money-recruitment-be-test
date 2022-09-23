namespace VacationRental.Api.Aplication.Interfaces.Dtos
{
    public interface IRentalAppDto
    {
        int Id { get; set; }
        int Units { get; set; }
        int PreparationTimeInDays { get; set; }
    }
}
