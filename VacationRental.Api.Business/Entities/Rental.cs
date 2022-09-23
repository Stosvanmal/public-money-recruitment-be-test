using VacationRental.Api.Business.Interfaces.Entities;

namespace VacationRental.Api.Business.Entities
{
    public class Rental: IEntities, IRental
    {
        public int Id { get; set; }
        public int Units { get; set; }
        public int PreparationTimeInDays { get; set; }
        public Rental(int id, int units, int preparationTimeInDays)
        {
            Id = id;
            Units = units;
            SetPreparationTimeInDays(preparationTimeInDays);
        }

        public void SetPreparationTimeInDays(int preparationTimeInDays)
        {
            this.PreparationTimeInDays = preparationTimeInDays;
        }
    }
}
