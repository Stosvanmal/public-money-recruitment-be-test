namespace VacationRental.Api.Business.Interfaces.Entities
{
    public interface IRental
    {
        int Id { get; set; }
        int Units { get; }
        int PreparationTimeInDays { get; }
        void SetPreparationTimeInDays(int preparationTimeInDays);
    }
}
