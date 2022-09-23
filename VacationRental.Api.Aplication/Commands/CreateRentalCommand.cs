using MediatR;
using VacationRental.Api.Aplication.Dtos;

namespace VacationRental.Api.Aplication.Commands
{
    public class CreateRentalCommand:IRequest<ResourceIdAppDto>
    {
        public CreateRentalCommand(int units, int preparationTimeInDays)
        {
            Units = units;
            PreparationTimeInDays = preparationTimeInDays;
        }

        public int Units { get; }
        public int PreparationTimeInDays { get; }
    }
}
