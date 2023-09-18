using System.Diagnostics;
using EnviarEmailMensageria;
Processamento.Processar();
using var timer = new PeriodicTimer(TimeSpan.FromMinutes(30));
var sw = Stopwatch.StartNew();
while (await timer.WaitForNextTickAsync())
{
   
    Processamento.Processar();

}






