using MediatR;
using System.Threading;
using System.Threading.Tasks;
using VacationRental.Api.Aplication.Dtos;
using VacationRental.Api.Business.Interfaces;
using VacationRental.Api.Business.Models;
using VacationRental.Api.Infrastructure.Interfaces;

namespace VacationRental.Api.Aplication.Commands
{
    public class CreateRentalCommandHandler : IRequestHandler<CreateRentalCommand, ResourceIdDto>
    {
        private readonly IRentalRepository rentalRepository;
        private readonly IUnitOfWork unitOfWork;

        public CreateRentalCommandHandler(IRentalRepository rentalRepository, IUnitOfWork unitOfWork)
        {
            this.rentalRepository = rentalRepository;
            this.unitOfWork = unitOfWork;
        }
        public async Task<ResourceIdDto> Handle(CreateRentalCommand request, CancellationToken cancellationToken)
        {
            IRentalModel rental = new RentalModel(0, request.Units, request.PreparationTimeInDays);
            var res = await rentalRepository.CreateRental(rental);
            await unitOfWork.SaveChanges();
            return new ResourceIdDto { Id = res };

        }
    }
}
