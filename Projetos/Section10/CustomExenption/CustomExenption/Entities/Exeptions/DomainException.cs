using System;

namespace CustomExenption.Entities.Exeptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
