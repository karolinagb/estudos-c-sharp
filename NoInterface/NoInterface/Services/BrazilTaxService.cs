namespace NoInterface.Services
{
    //NÃO É HERANÇA MAS REALIZAÇÃO DE INTERFACE
    //BrazilTaxService é um subtipo de ITaxService
    class BrazilTaxService : ITaxService
    {
        //Implementando serviço de impsoto no Brazil com suas regras:
        //Implementação do BrazilTaxService já está igual a do ITaxService
        public double Tax (double amount)
        {
            if(amount <= 100.0)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
