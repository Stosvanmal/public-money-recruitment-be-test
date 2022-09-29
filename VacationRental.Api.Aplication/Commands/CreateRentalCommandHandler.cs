using MediatR;
using System.Threading;
using System.Threading.Tasks;
using VacationRental.Api.Aplication.Dtos;
using VacationRental.Api.Business.Dtos;
using VacationRental.Api.Business.Interfaces;
using VacationRental.Api.Business.Interfaces.Entities;
using VacationRental.Api.Infrastructure.Interfaces;

namespace VacationRental.Api.Aplication.Commands
{
    public class CreateRentalCommandHandler : IRequestHandler<CreateRentalCommand, ResourceIdAppDto>
    {
        private readonly IRentalRepository rentalRepository;
        private readonly IRentalFactory rentalFactory;
        private readonly IUnitOfWork unitOfWork;

        public CreateRentalCommandHandler(IRentalRepository rentalRepository, IRentalFactory rentalFactory, IUnitOfWork unitOfWork)
        {
            this.rentalRepository = rentalRepository;
            this.rentalFactory = rentalFactory;
            this.unitOfWork = unitOfWork;
        }
        public async Task<ResourceIdAppDto> Handle(CreateRentalCommand request, CancellationToken cancellationToken)
        {
            RentalDto rentalDto = new RentalDto { Id = 0, Units = request.Units,PreparationTimeInDays = request.PreparationTimeInDays};
            IRental rental = rentalFactory.CreateRental(rentalDto);
            var res = await rentalRepository.AddRental(rental);
            await unitOfWork.SaveChanges();
            return new ResourceIdAppDto { Id = res };

        }
    }
}
