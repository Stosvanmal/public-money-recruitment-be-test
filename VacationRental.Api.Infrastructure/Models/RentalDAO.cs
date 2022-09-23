using System;
using System.Collections.Generic;
using System.Text;

namespace VacationRental.Api.Infrastructure.Models
{
    internal class RentalDAO
    {
        public int Id { get; set; }
        public int Units { get; set; }
        public int PreparationTimeInDays { get; set; }
    }
}
