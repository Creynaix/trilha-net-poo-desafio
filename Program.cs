using System.Data;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "1", modelo: "CXX-2020", imei: "123123", memoria: 256);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Waze");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "2", modelo: "VXZ-1010", imei: "300020", memoria: 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Candy Crush");
