using System.Globalization;
using System.Text;

namespace NoInterface.Entities
{
    //Implementando a nota de pagamento
    class Invoice
    {
        //Pagamento basico = total de horas/dias * valor por hora/dia
        public double BasicPayment { get; set; }

        //Imposto de acordo com regras do Brasil
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        //O TotalPayment é uma propriedade calculada e por isso precisa ser criado separado
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        //Imprimindo nota de pagamento:
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Basic Payment: " + BasicPayment.ToString("F2", CultureInfo.InvariantCulture));
            sb.AppendLine("Tax: " + Tax.ToString("F2", CultureInfo.InvariantCulture));
            sb.AppendLine("Total Payment: " + TotalPayment.ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
