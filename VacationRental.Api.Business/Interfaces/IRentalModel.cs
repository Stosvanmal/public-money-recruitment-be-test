using System;
using System.Collections.Generic;
using System.Text;

namespace VacationRental.Api.Business.Interfaces
{
    public interface IRentalModel
    {
        int Id { get; set; }
        int Units { get; }
        int PreparationTimeInDays { get;  }
        void SetPreparationTimeInDays(int preparationTimeInDays);
    }
}
