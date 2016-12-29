using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
* Author: Julio Conchas
* Email: conchasjimenez@gmail.com
* Tittle: Program
* Copyright: JC. of CP.
*/

namespace fistWindowsForm{
  static class Program{
     /// Punto de entrada principal para la aplicación.
     [STAThread]
     static void Main(){
       Application.EnableVisualStyles();
       Application.SetCompatibleTextRenderingDefault(false);
       Application.Run(new Form1());
     }
  }
}
