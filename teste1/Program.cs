// See https://aka.ms/new-console-template for more information




using teste1;
using System.Numerics;
using System.ComponentModel;

var esteira = new Esteira();

var conteiner = new Conteiner(300, new Vector3(0,10,5),300);

esteira.Conteiners.Add(conteiner);
while (true)
{
    esteira.Update(0.15f);
    Task.Delay(150).Wait();
    Console.WriteLine(conteiner.Position.X);
    if (conteiner.Position.X > 3) 
    {
        break;
     }
}

var item = new Item(15, 500, "VasoPlanta");


try 
{ 
    conteiner.AddItem(item); 
}
catch (Exception ex) 
{ 
    Console.WriteLine(ex.Message); 
}

Console.WriteLine($"O volume livre é {conteiner.FreeVolume}");

Console.WriteLine($"O peso livre é {conteiner.FreeWeight}");

