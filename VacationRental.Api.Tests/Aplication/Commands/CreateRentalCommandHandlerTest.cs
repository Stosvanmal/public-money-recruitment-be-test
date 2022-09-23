using Moq;
using System.Threading;
using VacationRental.Api.Aplication.Commands;
using VacationRental.Api.Business.Interfaces;
using VacationRental.Api.Business.Models;
using VacationRental.Api.Infrastructure.Interfaces;
using Xunit;

namespace VacationRental.Api.Tests.Aplication.Commands
{
    public class CreateRentalCommandHandlerTest
    {
        private readonly Mock<IRentalRepository> rentalRepositoryMock;
        private readonly Mock<IUnitOfWork> unitOfWorkMock;
        private readonly CreateRentalCommandHandler command;
        public CreateRentalCommandHandlerTest()
        {
            this.rentalRepositoryMock = new Mock<IRentalRepository>();
            this.unitOfWorkMock = new Mock<IUnitOfWork>();
            this.command = new CreateRentalCommandHandler(rentalRepositoryMock.Object, unitOfWorkMock.Object);
        }
        [Fact]
        public async void CreateRental_OK()
        {
            int resultId = 35;
            int units = 5;
            int preparation = 8;
            CreateRentalCommand cmd = new CreateRentalCommand(units, preparation);
            IRentalModel rentalModel = new RentalModel(0, units, preparation);

            rentalRepositoryMock.Setup(x => x.CreateRental(It.IsAny<IRentalModel>())).ReturnsAsync(resultId);

            var res = await command.Handle(cmd, CancellationToken.None);

            rentalRepositoryMock.Verify(x => x.CreateRental(
                It.Is<IRentalModel>(m=> m.Id == rentalModel.Id 
                                    && m.Units == rentalModel.Units 
                                    && m.PreparationTimeInDays == rentalModel.PreparationTimeInDays)), Times.Once);
            unitOfWorkMock.Verify(x => x.SaveChanges(), Times.Once);
            Assert.NotNull(res);
            Assert.Equal(resultId, res.Id);

        }
    }
}
