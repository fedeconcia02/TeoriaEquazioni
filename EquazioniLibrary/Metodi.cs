using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Metodi
    {
        //Metodo per verificare se l'equazione di primo grado è DETERMINATA
        public static bool IsDetermined(double a)
        {
            bool determinata = false; //Variabile di tipo 'bool' che stabilisce se l'equazione analizzata è DETERMINATA

            if (a!=0) //Un'equazione di primo grade è DETERMINATA se i coefficienti 'a' e 'b' sono diversi da 0
            {
                determinata = true;
            }

            return determinata;
        }

        //Metodo per verificare se l'equazione di primo grado è IMPOSSIBILE
        public static bool IsInconsisted(double a, double b)
        {
            bool impossibile = false; //Variabile di tipo 'bool' che stabilisce se l'equazione analizzata è IMPOSSIBILE

            if (a == 0 && b != 0) //Un'equazione di primo grade è IMPOSSIBILE se il coefficiente 'a' è uguale a 0 e il coefficiente 'b' è diverso da 0
            {
                impossibile = true;
            }

            return impossibile;
        }

        //Metodo per verificare se l'equazione è di SECONDO GRADO
        public static bool IsDegree2(double a)
        {
            bool secondogrado = true; //Variabile di tipo 'bool' che stabilisce se l'equazione analizzata è di SECONDO GRADO

            if (a == 0 || a < 0) //Un'equazione è di SECONDO GRADO se 
            {
                secondogrado = false;
            }

            return secondogrado;
        }

        //Metodo per calcolare il delta
        public static double Delta(double a, double b, double c)
        {
            double delta = 0;

            delta = (b * b) - (4 * a * c);

            return delta;
        }

        //Metodo Per calcolare un'equazione di primo grado
        public static string EquationDegree1(double a, double b)
        {
            string risulato = "";
            bool tipo = false;

            tipo = IsDetermined(a);
            if (tipo==true)
            {
                risulato = "Indeterminata ";
            }

            tipo = IsInconsisted(a, b);
            if (tipo==true)
            {
                if (risulato=="Indeterminata")
                {
                    risulato = "Indeterminata e impossibile ";
                }
                else
                {
                    risulato = "Impossibile ";
                }
            }

            if (risulato=="")
            {
                risulato = Convert.ToString(a / b);
            }

            return risulato;
        }
    }
}
