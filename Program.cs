using ComunicaçãoComScadaLts.Models.ScadaLtsClass;


using (var context = new scadaltsContext())
{
    var resultado = context.Pointvalues.OrderBy(x=>x.Id).Take(10).ToArray();
    foreach (var item in resultado)
    {
        Console.WriteLine($"ID: {item.Id}\t DataPoint: {item.DataPointId}\t DataType: {item.DataType}\t Pointalue: {item.PointValue1}      Ts:{item.Ts}");
    }
}  

Console.ReadKey();