using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Globalization;

namespace ParabensMamae
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // var data = new DateTime(); cria uma instância, valor padrão, 01/001/01.

            // var data = DateTime.Now; //Mostra a data atual.

            /*---------------------------------------------------/
             if (data.Date == DateTime.Now.Date) compara a data
             Console.WriteLine("É igual");

             Console.WriteLine(data);
            /-------------------------------------------------*/

            /*------------------------------------------------------------------------------------/
             var data = new DateTime(2025, 11, 05, 15, 16, 8); // Mostra data e hora, que tem entre ().
            /-------------------------------------------------------------------------------------*/

            /*-----------------------------------------------------------------/
             Console.WriteLine(data); //Data
             Console.WriteLine(data.Year); // //Data do mes.
             Console.WriteLine(data.Day); /Data do ano.
             Console.WriteLine(data.Month);/Data do dia.
             Console.WriteLine(data.Hour); //Hora.
             Console.WriteLine(data.Minute); //Minuto.
             Console.WriteLine(data.Second); //Segundos.

             Console.WriteLine(data.DayOfWeek); //Dia da semana.
             Console.WriteLine(data.DayOfYear); //Qnts dias ja passou do ano.
           /------------------------------------------------------------------*/

            /*-------------------------------------------------------------------/
             var formatada  = string.Format("{0:yyyy/MM/dd hh:mm:ss ff z}", data);
             Console.WriteLine(formatada);
            /-------------------------------------------------------------------*/

            /*---------------------------------------------------/
             Use esse metodo sempre que quiser somar data e hora.
             Console.WriteLine(data);
             Console.WriteLine(data.AddDays(12));
             Console.WriteLine(data.AddMonths(1));
             Console.WriteLine(data.AddYears(1));
           /----------------------------------------------------*/

            /*--------------------------------------------------/
             CultureInfo
             var br = new CultureInfo("pr-BR");
             var pt = new CultureInfo("pt-PT");
             var en = new CultureInfo("en-US");
             var de = new CultureInfo("de-DE");
             var ja = new CultureInfo("ja-JP");

             Console.WriteLine(DateTime.Now);
             Console.WriteLine(DateTime.Now.ToString("D", ja));
            /----------------------------------------------------*/


            /*--------------------------------------------------------------------------------/
             TimeZOne
             var utcDate = DateTime.UtcNow;

             Console.WriteLine(DateTime.Now);
             Console.WriteLine(utcDate);

             Console.WriteLine(utcDate.ToLocalTime());

             var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
             Console.WriteLine(timezoneAustralia);

             var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
             Console.WriteLine(horaAustralia);

              //Mostra todas a timeszones do sistema.
             var timezones = TimeZoneInfo.GetSystemTimeZones();
             foreach (var timezone in timezones)
             {
             Console.WriteLine(timezone.Id);
             Console.WriteLine(timezone);
             Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
             Console.WriteLine("______________");
             }
            /-----------------------------------------------------------------------------------*/

            /*TimeSpan
             var timeSpan = new TimeSpan();
             Console.WriteLine(timeSpan);

             var timeSpanNanosegundos = new TimeSpan(1);
             Console.WriteLine(timeSpanNanosegundos);

             var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
             Console.WriteLine(timeSpanHoraMinutoSegundo);

             var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
             Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

             var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 100);
             Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

             Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
             Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
             Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(13, 31,0)));
            */

            /* três métodos usados, saber qnts dias tem 1 mês,Saber que dia da semana estamos e horario de verão.

             Console.WriteLine(DateTime.DaysInMonth(2025, 5));
             Console.WriteLine(Isweend(DateTime.Now.DayOfWeek));
             Console.WriteLine(DateTime.Now.IsDaylightSavingTime());

             static bool Isweend(DayOfWeek today)
             {
                return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
             }
            */

        }
    }
}
