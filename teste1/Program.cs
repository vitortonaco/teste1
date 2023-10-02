// See https://aka.ms/new-console-template for more information

using teste1;
using System.Numerics;
using System.ComponentModel;

var esteira1 = new Esteira(new Vector3(0.3f,-0.1f,-0.1f));

var conteiner = new Conteiner(300, new Vector3(0,10,5),300);

esteira1.Conteiners.Add(conteiner);
while (true)
{
    esteira1.Update(0.15f);
    Task.Delay(150).Wait();
    Console.WriteLine("X:{0} Y:{1} Z:{2} ",conteiner.Position.X,conteiner.Position.Y,conteiner.Position.Z);
    if (conteiner.Position.X > 3) 
    {
        break;
     }
}
var item = new Item(15, 600, "VasoPlanta");
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
var x = new Vector3(1,3,4);
var y = new Vector3(-5,4,-3);

var xy =Vector3.Dot(x,y);
Console.WriteLine(xy);

