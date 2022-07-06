using System;

namespace Ejercicio2DeNahemiasZampelunghe
{
    class Program
    {
        static void Main(string[] args)
        {
            //	Definir lado1, lado2, lado3, area, perimetro, p Como Real; Definir rectangulo, acutangulo, obtusangulo, verificar, verificarT Como Logico;
            //	Escribir Sin Saltar"Ingrese el primer lado:";
            //	leer lado1;
            //	Escribir Sin Saltar"Ingrese el segundo lado:";
            //	leer lado2;
            //	Escribir Sin Saltar"Ingrese el tercer lado:";
            //	leer lado3;
            //	verificar = verificarTriangulo(lado1, lado2, lado3);
            //	verificarT = verificacionTriangulo(lado1, lado2, lado3);
            //	si verificar = Verdadero Entonces
            //		  si verificarT = Verdadero Entonces
            //				p = (lado1 + lado2 + lado3) / 2;
            //	area = raiz(p * (p - lado1) * (p - lado2) * (p - lado3));
            //	perimetro = lado1 + lado2 + lado3;
            //	rectangulo = trianguloRectangulo(lado1, lado2, lado3);
            //	acutangulo = trianguloAcutangulo(lado1, lado2, lado3);
            //	obtusangulo = trianguloObtusangulo(lado1, lado2, lado3);
            //	si rectangulo = Verdadero Entonces
            //		  Escribir "Su Triángulo es un Triángulo Rectángulo";
            //	SiNo
            //		si obtusangulo = Verdadero Entonces
            //			  Escribir "Su Triángulo es un Triángulo Obtusángulo";
            //	SiNo
            //		si acutangulo = Verdadero Entonces
            //			  Escribir "Su Triángulo es un Triángulo Acutángulo";
            //	FinSi
            //FinSi
            //	FinSi
            //	Escribir "Y su area es de ",area,". Con un perimetro de ",perimetro,".";
            //	FinSi
            //FinSi
            try
            {
                Console.Write("Ingrese el primer lado del triángulo:");
                var lado1 = float.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo lado del triángulo:");
                var lado2 = float.Parse(Console.ReadLine());
                Console.Write("Ingrese el tercer lado del triángulo:");
                var lado3 = float.Parse(Console.ReadLine());
                var p = (lado1 + lado2 + lado3) / 2;
                var area = Math.Sqrt(p * (p - lado1) * (p - lado2) * (p - lado3));
                var perimetro = lado1 + lado2 + lado3;

                if (verificar(lado1, lado2, lado3) && verificarTriangulo(lado1, lado2, lado3))
                {
                    Console.WriteLine(rectangulo(lado1, lado2, lado3));
                    Console.WriteLine($"El area es {area} Y su perimetro {perimetro}");


                }

            }
            catch (Exception)
            {

                Console.WriteLine("Parametros mal ingresados");
            }

			Console.ReadKey();
		}

        

        private static string rectangulo(float lado1, float lado2, float lado3)
        {
			if (lado1 * lado1 == lado2 * lado2 + lado3 * lado3)
			{
				string mensaje = "Es un Triángulo rectángulo";
				return mensaje;
			}
			else if (lado1 * lado1 > lado2 * lado2 + lado3 * lado3)
			{
				string mensaje = "Es un Triángulo obtusángulo";
				return mensaje;
            }
            else
            {
				string mensaje = "El triángulo es acutángulo";
				return mensaje;
            }
        }

        private static bool verificarTriangulo(float lado1, float lado2, float lado3)
        {
            if (lado1>0 && 0<lado2 && 0<lado3)
            {
				return true;
            }
            else
            {
				return false;
            }
        }

        private static bool verificar(float lado1, float lado2, float lado3)
        {
            if (lado1<lado2+lado3 && lado2<lado1+lado3 && lado3<lado1+lado2)
            {
				return true;
            } else
            {
				return false;
            }
        }
    }
}
