using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Class1
    {
        //Metodo per verificare se l'equazione di primo grado è DETERMINATA
        static bool IsDetermined(double a, double b)
        {
            bool analisi = true; //Variabile di tipo 'bool' che stabilisce se l'equazione analizzata è DETERMINATA

            if (a!=0 && b!=0) //Un'equazione di primo grade è DETERMINATA se i coefficienti 'a' e 'b' sono diversi da 0
            {
                analisi = true;
            }
            else
            {
                analisi = false;
            }

            return analisi;
        }

        //Metodo per verificare se l'equazione di primo grado è IMPOSSIBILE
        static bool IsInconsisted(double a, double b)
        {
            bool analisi = true; //Variabile di tipo 'bool' che stabilisce se l'equazione analizzata è IMPOSSIBILE

            if (a != 0 && b != 0) //Un'equazione di primo grade è IMPOSSIBILE se il coefficiente 'a' è uguale a 0 e il coefficiente 'b' è diverso da 0
            {
                analisi = true;
            }
            else
            {
                analisi = false;
            }

            return analisi;
        }
    }
}
