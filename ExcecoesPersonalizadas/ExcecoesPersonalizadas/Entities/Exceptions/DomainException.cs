using System;

namespace ExcecoesPersonalizadas.Entities.Exceptions
{
    //ApplicationException permite a criação de exceções personalizadas
    //A palavra domain é para identificar que a exceção faz parte do domínio do negócio
    class DomainException : ApplicationException
    {
        public DomainException (string message) : base (message)
        {

        }
    }
}
