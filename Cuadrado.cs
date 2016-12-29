using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
* Author: Julio Conchas
* Email: conchasjimenez@gmail.com
* Tittle: Cuadrado
* Copyright: JC. of CP.
*/

/*
Desarrollar una clase que represente un Cuadrado y tenga
los siguientes métodos: cargar el valor de su lado, imprimir
su perímetro y su superficie.
*/

namespace Cuadrado{
  class Cuadrado{
    private float lado, perimetro, superficie;

    public void Inicializar(){
      string linea;
      Console.Write("Ingresa el lado: ");
      linea = Console.ReadLine();
      lado = float.Parse(linea);
    }
    public float Perimetro(){ return perimetro = lado * 4; }
    public float Superficie(){ return superficie = lado * lado; }
    static void Main(string[] args){
      Cuadrado cd = new Cuadrado();
      cd.Inicializar();
      Console.Write("Perimetro: ");
      Console.WriteLine(cd.Perimetro());
      Console.Write("Superficie; ");
      Console.WriteLine(cd.Superficie());
      Console.ReadKey();
    }
  }
}
