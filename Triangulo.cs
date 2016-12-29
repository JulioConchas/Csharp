using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
* Author: Julio Conchas
* Email: conchasjimenez@gmail.com
* Tittle: Triangulo
* Copyright: JC. of CP.
*/

/*
Desarrollar un programa que cargue los lados de un triángulo e
implemente los siguientes métodos: inicializar los atributos,
imprimir el valor del lado mayor y otro método que muestre si
es equilátero o no.
*/

namespace Triangulo{
  class Triangulo{
    private float l1,l2,l3;

    public void Inicializar(){
      string linea;
      Console.Write("Ingrese el primer lado: ");
      linea = Console.ReadLine();
      l1 = float.Parse(linea);
      Console.Write("Ingrese el segundo lado: ");
      linea = Console.ReadLine();
      l2 = float.Parse(linea);
      Console.Write("Ingrese el tercer lado: ");
      linea = Console.ReadLine();
      l3 = float.Parse(linea);
    }
    public void LadoMayor(){
      Console.Write("El lado mayor es: ");
      if(l1 > l2 && l1 > l3){
        Console.Write("Primero! ");
      }
      else if(l2 > l1 && l2 > l3){
        Console.Write("Segundo! ");
      }
      else if(l3 > l1 && l3 > l2){
        Console.Write("Tercero! ");
      }
      else{
        Console.Write("Todos iguales! ");
      }
    }
    public void isEquilatero(){
      if(l1 == l2 && l1 == l3){
        Console.Write("\nTriangulo equilatero! ");
      }
      else{
        Console.Write("\nNo es equilatero! ");
      }
    }
    static void Main(string[] args){
      Triangulo tr = new Triangulo();
      tr.Inicializar();
      tr.LadoMayor();
      tr.isEquilatero();
      Console.ReadKey();
    }
  }
}
