using System;

class Program {
  public static void Main (string[] args) {
    int  l1, l2, l3, tt12, tt23, tt13; 
    
    Console.Write("Digite o 1- lado:");
    l1 = int.Parse(Console.ReadLine()); 

Console.Write("Digite o 2- lado:");
    l2 = int.Parse(Console.ReadLine()); 

 

Console.Write("Digite o 3- lado:");
    l3 = int.Parse(Console.ReadLine()); 

tt12 = l1+l2; 

tt23 = l2+l3; 

tt13 = l1+l3; 

if(tt12>l3) 

{ 

if(tt23>l1) 

{ 

if(tt13>l2) 

{ 

if(l1==l2) 

{ 

if(l1==l3) 

 

{ 

Console.Write("Triangulo Equilatero"); 

} 

else 

{ 

if(l1!=l2) 

{ 

if(l1!=l3) 

{ 

if(l2!=l3) 

{ 

Console.Write("Triangulo Escaleno"); 

} 

 

else 

{ 

Console.Write("Triangulo Isoceles"); 

} 

} 

else 

{ 

Console.Write("Triangulo Isoceles"); 

} 

} 

else 

{ 

Console.Write("Triangulo Isoceles"); 

 

} 

} 

} 

else 

{ 

if(l1!=l2) 

{ 

if(l1!=l3) 

{ 

if(l2!=l3) 

{ 

Console.Write("Triangulo Escaleno"); 

 

} 

else 

{ 

Console.Write("Triangulo Isoceles"); 

} 

} 

else 

{ 

Console.Write("Triangulo Isoceles"); 

} 

} 

else 

{ 

 

Console.Write("Triangulo Isoceles"); 

} 

} 

} 

else 

{ 

Console.Write("Não forma Triangulo"); 

} 

} 

else 

{ 

Console.Write("Não forma Triangulo"); 

} 

 

} 

else 

{ 

Console.Write("Não forma Triangulo"); 

} 

} 
}
