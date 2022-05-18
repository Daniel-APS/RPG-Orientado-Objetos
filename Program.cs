using System;
using RPG_Orientado_Objetos.src.Entities;

namespace RPG_Orientado_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight", 300, 40);
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard", 150, 300);
            Ninja ninja = new Ninja("wedge", 27, "Ninja", 240, 80);
            BlackWizard blackWizard = new BlackWizard("Topapa", 30, "BlackWizard", 150, 300);

            Console.WriteLine(arus.Attack(8));
            Console.WriteLine(wizard.Attack(7));



        }
    }
}
