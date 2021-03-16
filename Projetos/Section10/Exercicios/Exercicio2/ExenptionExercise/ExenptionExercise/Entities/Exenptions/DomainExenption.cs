using System;

namespace ExenptionExercise.Entities.Exenptions
{
    class DomainExenption: ApplicationException
    {
        public DomainExenption(string message) : base(message) 
        {
        }
    }
}
