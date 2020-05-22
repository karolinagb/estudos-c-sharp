namespace NoInterface.Services
{
    class BrazilTaxService
    {
        //Implementando serviço de impsoto no Brazil com suas regras:
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
