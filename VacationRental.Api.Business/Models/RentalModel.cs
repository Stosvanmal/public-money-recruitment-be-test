using VacationRental.Api.Business.Interfaces;

namespace VacationRental.Api.Business.Models
{
    public class RentalModel: IRentalModel
    {
        public int Id { get; set; }
        public int Units { get; private set; }
        public int PreparationTimeInDays { get; private set; }
        public RentalModel(int id, int units, int preparationTimeInDays)
        {
            Id = id;
            Units = units;
            PreparationTimeInDays = preparationTimeInDays;  
        }
        public void SetPreparationTimeInDays(int preparationTimeInDays)
        {
          this.PreparationTimeInDays = preparationTimeInDays;
        }
    }
}
