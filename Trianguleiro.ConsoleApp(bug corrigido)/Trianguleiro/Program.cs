using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trianguleiro
{
    class Program
    {
        static void Main(string[] args)
        {
            ControladorTriangulo controladorTriangulo = new ControladorTriangulo();
            Triangulo[] arrTri = new Triangulo[10];
            arrTri[0] = new Triangulo(1, 1, 1);
            arrTri[1] = new Triangulo(1, 1, 2);
            arrTri[2] = new Triangulo(1, 2, 3);
            arrTri[3] = new Triangulo(1, 2, 4);

            // primeiro triangulo (Equilátero)
            int i = 0;
            do {
                Console.WriteLine($"\nTestando o {i+1}° triangulo");
                if (controladorTriangulo.Validador(arrTri[i])) {
                    Console.WriteLine($"É valido: Sim");
                    Console.WriteLine($"Tipo: {controladorTriangulo.Tipador(arrTri[i])}");
                }
                else
                    Console.WriteLine($"É valido: Não");
                i++;
                if (arrTri[i] == null)
                    break;
            } while (true);
            Console.ReadLine();
        }
    }
}
