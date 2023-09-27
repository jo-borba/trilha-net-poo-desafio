using DesafioPOO.Models;

Nokia nokia = new Nokia("333322222332", "Nokia 3570", "15417087a8781a57mxx33", 2048);
Iphone iphone = new Iphone("1111118455", "Iphone 15 PRO MAX", "7777487434d848f", 5120);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Linkedin");

Console.WriteLine();

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");