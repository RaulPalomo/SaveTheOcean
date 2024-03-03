using LLibreria;
using System;
using System.ComponentModel.DataAnnotations;
namespace SaveTheOcean
{
    public class Program
    {
        public static void Main()
        {
            const string MsgWelcome = "Save the Ocean!", MsgPlay="Què vols fer?\n1.Jugar\n2.Sortir", MsgRole="Perfecte! Qué vols ser?\n1.Tècnic (45 xp)\n2.Veterinari (80 xp)", MsgName="Genial! I el teu nom?", MsgFitxa="Aquí tens la seva fitxa, per més informació:";
            int option;
            string name, role;
            
            const int Max = 2, Min=1;
            Rescue rescue = new Rescue();

            Console.WriteLine(MsgWelcome);
            Console.WriteLine(MsgPlay);
            do
            {
                option=Convert.ToInt32(Console.ReadLine());
            } while (!Class1.InRange(Max, Min, option));

            if(option== 1)
            {
                Console.WriteLine(MsgRole);
                do
                {
                    option = Convert.ToInt32(Console.ReadLine());
                } while (!Class1.InRange(Max, Min, option));
                role = option == 1 ? "Tècnic" : "Veterinari";
                Console.WriteLine(MsgName);
                name= Console.ReadLine();
                Persona jugador= new Persona(name, role);

                Console.WriteLine($"Hola, {jugador.Name}! El 112 ha rebut una trucada d’avís d’un exemplar a rescatar. \r\nLes dades que ens han donat són les següents:");
                rescue.GetRescat();
                Console.WriteLine(MsgFitxa);
                rescue.GetFitxa();
                Console.WriteLine($"Té un grau d’afectació (GA) del {rescue.GA}%. Vols curar-la aquí (1) o traslladar-la al centre (2)?");

                do
                {
                    option = Convert.ToInt32(Console.ReadLine());
                } while (!Class1.InRange(Max, Min, option));
                Console.WriteLine(rescue.Cura(option));

                Console.WriteLine(rescue.GA < 5 ? $"Experiència: {jugador.Xp + 50}" : $"Experiència: {jugador.Xp - 20}");
                
            }


        }
    }
}