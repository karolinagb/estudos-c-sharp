using System;
using System.Globalization;

namespace MetodosExtendisos218.Extensions
{
    //Para extender um tipo sem alterar o código dele, a classe precisa ser estática
    static class DateTimeExtensions
    {
        /*O que determina que esse é o método de extensão do tipo DateTime é o primeiro parâmetro do método
         que vai ter que ter a palavra this e o tipo do método e uma referência ao obj que será trabalhado*/
        //Esses argumentos é só uma referência ao objeto e não precisa ser colocado na chamada do método
        static public string ElapsedTime(this DateTime thisObj)
        {
            /*Na implementação desse método eu vou ter que coloca uma lógica para transformar a data numa duração
             em horas ou em dias conforme for a duração da data do objeto em relação a data do sistema*/

            //Descobrindo a duração do datetime:
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if(duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours.";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
