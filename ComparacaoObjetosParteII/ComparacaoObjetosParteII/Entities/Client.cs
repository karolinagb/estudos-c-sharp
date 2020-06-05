using System;
using System.Collections.Generic;
using System.Text;

namespace ComparacaoObjetosParteII.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        //Para customizar o método Equals, temos que sobrescrevê-lo
        public override bool Equals(object obj)
        {
            if (!(obj is Client))
            {
                return false;
            }

            Client other = obj as Client;

            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
