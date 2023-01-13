using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterface.Domain
{
    internal class CarRental
    {
        public Vehicle Model { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Invoice? Invoice { get; set; }
        public CarRental(Vehicle model, DateTime start, DateTime finish)
        {
            Model = model;
            Start = start;
            Finish = finish;
        }
    }
}
