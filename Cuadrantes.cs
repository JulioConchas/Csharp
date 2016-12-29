using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
* Author: Julio Conchas
* Email: conchasjimenez@gmail.com
* Tittle: Cuadrantes
* Copyright: JC. of CP.
*/

/*
Desarrollar una clase que represente un punto en el plano y
tenga los siguientes métodos: cargar los valores de x e y,
imprimir en que cuadrante se encuentra dicho punto
(concepto matemático, primer cuadrante si x e y son positivas,
si x<0 e y>0 segundo cuadrante, etc.)
Cuadrantes:
1.- x > 0 && y > 0
2.- x < 0 && y > 0
3.- x < 0 && y < 0
4.- x > 0 && y < 0
*/

namespace Cuadrantes{
  class Cuadrantes{
    private float x,y;

    public void Inicializar(){
      string linea;
      Console.Write("Ingresa x: ");
      linea = Console.ReadLine();
      x = float.Parse(linea);
      Console.Write("Ingres y:");
      linea = Console.ReadLine();
      y = float.Parse(linea);
    }
    public void Print_Cuadrante(){
      if(x > 0 && y > 0) Console.Write("Primer Cuadrante! ");
      else if(x < 0 && y > 0) Console.Write("Segundo Cuadrante! ");
      else if(x < 0 && y < 0) Console.Write("Tercer Cuadrante! ");
      else if(x > 0 && y < 0) Console.Write("Cuarto Cuadrante! ");
    }
    static void Main(string[] args){
      Cuadrantes ct = new Cuadrantes();
      ct.Inicializar();
      ct.Print_Cuadrante();
      Console.ReadKey();
    }
  }
}
