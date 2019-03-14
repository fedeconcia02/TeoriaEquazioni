using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod] per il primo metodo
        //Test con coefficente "a" positivo
        [TestMethod]
        public void TestMethod_IsDetermined1()
        {
            double a = 1;

            bool risultato = true;
            bool determinata = EquazioniLibrary.Metodi.IsDetermined(a);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con coefficente "a" uguale a 0
        [TestMethod]
        public void TestMethod_IsDetermined2()
        {
            double a = 0;

            bool risultato = false;
            bool determinata = EquazioniLibrary.Metodi.IsDetermined(a);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con coefficente "a" negativo
        [TestMethod]
        public void TestMethod_IsDetermined3()
        {
            double a = -1;

            bool risultato = true;
            bool determinata = EquazioniLibrary.Metodi.IsDetermined(a);

            Assert.AreEqual(risultato, determinata);
        }

        //------------------------------------------------------------------------------------

        //[TestMethod] per il secondo metodo
        //Test con tutti i coefficenti uguali a 0
        [TestMethod]
        public void TestMethod_IsInconsisted1()
        {
            double a = 0, b = 0;

            bool equazione = false;
            bool risultato = EquazioniLibrary.Metodi.IsInconsisted(a, b);

            Assert.AreEqual(equazione, risultato);
        }
        //Test con il coefficente "a" positivo e "b" uguale a 0
        [TestMethod]
        public void TestMethod_IsInconsisted2()
        {
            double a = 4, b = 0;

            bool equazione = false;
            bool risultato = EquazioniLibrary.Metodi.IsInconsisted(a, b);

            Assert.AreEqual(equazione, risultato);
        }
        //Test con il coefficente "a" uguale a 0 e "b" positivo
        [TestMethod]
        public void TestMethod_IsInconsisted3()
        {
            double a = 0, b = 5;

            bool equazione = true;
            bool risultato = EquazioniLibrary.Metodi.IsInconsisted(a, b);

            Assert.AreEqual(equazione, risultato);
        }
        //Test con il coefficente "a" negativo e "b" uguale a 0
        [TestMethod]
        public void TestMethod_IsInconsisted4()
        {
            double a = -4, b = 0;

            bool equazione = false;
            bool risultato = EquazioniLibrary.Metodi.IsInconsisted(a, b);

            Assert.AreEqual(equazione, risultato);
        }
        //Test con il coefficente "a" uguale a 0 e "b" negativo
        [TestMethod]
        public void TestMethod_IsInconsisted5()
        {
            double a = 0, b = -5;

            bool equazione = true;
            bool risultato = EquazioniLibrary.Metodi.IsInconsisted(a, b);

            Assert.AreEqual(equazione, risultato);
        }
        //Test con il coefficente "a" positivo e "b" negativo
        [TestMethod]
        public void TestMethod_IsInconsisted6()
        {
            double a = 4, b = -5;

            bool equazione = false;
            bool risultato = EquazioniLibrary.Metodi.IsInconsisted(a, b);

            Assert.AreEqual(equazione, risultato);
        }
        //Test con il coefficente "a" negativo e "b" positivo
        [TestMethod]
        public void TestMethod_IsInconsisted7()
        {
            double a = -4, b = 5;

            bool equazione = false;
            bool risultato = EquazioniLibrary.Metodi.IsInconsisted(a, b);

            Assert.AreEqual(equazione, risultato);
        }
        //Test con tutti i coefficenti positivi
        [TestMethod]
        public void TestMethod_IsInconsisted8()
        {
            double a = 4, b = 5;

            bool equazione = false;
            bool risultato = EquazioniLibrary.Metodi.IsInconsisted(a, b);

            Assert.AreEqual(equazione, risultato);
        }
        //Test con tutti i coefficenti negativi
        [TestMethod]
        public void TestMethod_IsInconsisted9()
        {
            double a = -4, b = -5;

            bool equazione = false;
            bool risultato = EquazioniLibrary.Metodi.IsInconsisted(a, b);

            Assert.AreEqual(equazione, risultato);
        }

        //------------------------------------------------------------------------------------

        //[TestMethod] per il terzo metodo
        //Test con coefficente "a" positivo
        [TestMethod]
        public void TestMethod_IsDegree1()
        {
            double a = 4;

            bool risultato = true;
            bool determinata = EquazioniLibrary.Metodi.IsDegree2(a);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con coefficente "a" uguale a 0
        [TestMethod]
        public void TestMethod_IsDegree2()
        {
            double a = 0;

            bool risultato = false;
            bool determinata = EquazioniLibrary.Metodi.IsDegree2(a);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con coefficente "a" negativo
        [TestMethod]
        public void TestMethod_IsDegree3()
        {
            double a = -34;

            bool risultato = false;
            bool determinata = EquazioniLibrary.Metodi.IsDegree2(a);

            Assert.AreEqual(risultato, determinata);
        }

        //------------------------------------------------------------------------------------

        //[TestMethod] per il quarto metodo
        //Test con tutti i coefficenti positivi
        [TestMethod]
        public void TestMethod_Delta1()
        {
            double a = 4, b = 5, c = 6;

            double risultato = -71;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con coefficente "a" uguale a 0 e i coefficenti "b" e "c" positivi
        [TestMethod]
        public void TestMethod_Delta2()
        {
            double a = 0, b = 5, c = 6;

            double risultato = 25;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con coefficente "a" e "c" positivi e il coefficente "b" uguale a 0
        [TestMethod]
        public void TestMethod_Delta3()
        {
            double a = 4, b = 0, c = 6;

            double risultato = -96;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con coefficenti "a" e "b" positivi e il coefficente "c" uguale a 0
        [TestMethod]
        public void TestMethod_Delta4()
        {
            double a = 4, b = 5, c = 0;

            double risultato = 25;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con coefficente "a" negativo e i coefficenti "b" e "c" positivi
        [TestMethod]
        public void TestMethod_Delta5()
        {
            double a = -4, b = 5, c = 6;

            double risultato = 121;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con  i coefficenti "a" e "c" positivi e il coefficente "b" negativo
        [TestMethod]
        public void TestMethod_Delta6()
        {
            double a = 4, b = -5, c = 6;

            double risultato = -71;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con i coefficenti "a" e "b" positivi e il coefficente "c" negativo
        [TestMethod]
        public void TestMethod_Delta7()
        {
            double a = 4, b = 5, c = -6;

            double risultato = 121;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }

        //Test con tutti i coefficenti uguali a 0
        [TestMethod]
        public void TestMethod_Delta8()
        {
            double a = 0, b = 0, c = 0;

            double risultato = 0;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con i coefficenti "a" e "b" uguali a 0 e il coefficente "c" positivo
        [TestMethod]
        public void TestMethod_Delta9()
        {
            double a = 0, b = 0, c = 6;

            double risultato = 0;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con i coefficenti "a" e "c" uguali a 0 e il coefficente "b" positivo
        [TestMethod]
        public void TestMethod_Delta10()
        {
            double a = 0, b = 5, c = 0;

            double risultato = 25;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con i coefficenti "b" e "c" uguali a 0 e il coefficente "a" positivo
        [TestMethod]
        public void TestMethod_Delta11()
        {
            double a = 4, b = 0, c = 0;

            double risultato = 0;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con i coefficenti "a" e "b" uguali a 0 e il coefficente "c" negativo
        [TestMethod]
        public void TestMethod_Delta12()
        {
            double a = 0, b = 0, c = -6;

            double risultato = 0;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con i coefficenti "a" e "c" uguali a 0 e il coefficente "b" negativo
        [TestMethod]
        public void TestMethod_Delta13()
        {
            double a = 0, b = -5, c = 0;

            double risultato = 25;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con i coefficenti "b" e "c" uguali a 0 e il coefficente "a" negativo
        [TestMethod]
        public void TestMethod_Delta14()
        {
            double a = -4, b = 0, c = 0;

            double risultato = 0;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }

        //Test con tutti i coefficenti negativi
        [TestMethod]
        public void TestMethod_Delta15()
        {
            double a = -4, b = -5, c = -6;

            double risultato = -71;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con i coefficenti "a" e "b" negativi e il coefficente "c" positivo
        [TestMethod]
        public void TestMethod_Delta16()
        {
            double a = -4, b = -5, c = 6;

            double risultato = 121;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con i coefficenti "a" e "c" negativi e il coefficente "b" positivo
        [TestMethod]
        public void TestMethod_Delta17()
        {
            double a = -4, b = 5, c = -6;

            double risultato = -71;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con i coefficenti "b" e "c" negativi e il coefficente "a" positivo
        [TestMethod]
        public void TestMethod_Delta18()
        {
            double a = 4, b = 5, c = -6;

            double risultato = 121;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con i coefficenti "a" e "b" negativi e il coefficente "c" uguale a 0
        [TestMethod]
        public void TestMethod_Delta19()
        {
            double a = -4, b = -5, c = 0;

            double risultato = 25;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con i coefficenti "a" e "c" negativi e il coefficente "b" uguale a 0
        [TestMethod]
        public void TestMethod_Delta20()
        {
            double a = -4, b = 0, c = -6;

            double risultato = -96;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con i coefficenti "b" e "c" negativi e il coefficente "a" uguale a 0
        [TestMethod]
        public void TestMethod_Delta21()
        {
            double a = 0, b = -5, c = -6;

            double risultato = 25;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }

        //Test con i coefficenti "a" uguale a 0, "b" negativo e "c" positivo
        [TestMethod]
        public void TestMethod_Delta22()
        {
            double a = 0, b = -5, c = 6;

            double risultato = 25;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con i coefficenti "a" uguale a 0, "b" positivo e "c" negativo
        [TestMethod]
        public void TestMethod_Delta23()
        {
            double a = 0, b = 5, c = -6;

            double risultato = 25;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con i coefficenti "a" uguale a 0, "b" negativo e "c" positivo
        [TestMethod]
        public void TestMethod_Delta24()
        {
            double a = -4, b = 0, c = 6;

            double risultato = 96;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con i coefficenti "a" uguale a 0, "b" negativo e "c" positivo
        [TestMethod]
        public void TestMethod_Delta25()
        {
            double a = 4, b = 0, c = -6;

            double risultato = 96;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con i coefficenti "a" negativo, "b" positivo e "c" uguale a 0
        [TestMethod]
        public void TestMethod_Delta26()
        {
            double a = -4, b = 5, c = 0;

            double risultato = 25;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }
        //Test con i coefficenti "a" positivo, "b" negativo e "c" uguale a 0
        [TestMethod]
        public void TestMethod_Delta27()
        {
            double a = 4, b = -5, c = 0;

            double risultato = 25;
            double determinata = EquazioniLibrary.Metodi.Delta(a, b, c);

            Assert.AreEqual(risultato, determinata);
        }

        //------------------------------------------------------------------------------------

        //[TestMethod] per il quinto metodo
        //Test con tutti i coefficenti uguali a 0
        [TestMethod]
        public void TestMethod_EquationDegree1()
        {
            double a = 0, b = 0;

            string x = "Indeterminata";
            string risultato = EquazioniLibrary.Metodi.EquationDegree1(a, b);

            Assert.AreEqual(Convert.ToDouble(x), Convert.ToDouble(risultato));
        }
        //Test con il coefficente "a" positivo e "b" uguale a 0
        [TestMethod]
        public void TestMethod_EquationDegree2()
        {
            double a = 4, b = 0;

            string x = "0";
            string risultato = EquazioniLibrary.Metodi.EquationDegree1(a, b);

            Assert.AreEqual(Convert.ToDouble(x), Convert.ToDouble(risultato));
        }
        //Test con il coefficente "a" uguale a 0 e "b" positivo
        [TestMethod]
        public void TestMethod_EquationDegree3()
        {
            double a = 0, b = 5;

            string x = "Impossibile";
            string risultato = EquazioniLibrary.Metodi.EquationDegree1(a, b);

            Assert.AreEqual(Convert.ToDouble(x), Convert.ToDouble(risultato));
        }
        //Test con il coefficente "a" negativo e "b" uguale a 0
        [TestMethod]
        public void TestMethod_EquationDegree4()
        {
            double a = -4, b = 0;

            string x = "0";
            string risultato = EquazioniLibrary.Metodi.EquationDegree1(a, b);

            Assert.AreEqual(Convert.ToDouble(x), Convert.ToDouble(risultato));
        }
        //Test con il coefficente "a" uguale a 0 e "b" negativo
        [TestMethod]
        public void TestMethod_EquationDegree5()
        {
            double a = 0, b = -5;

            string x = "Impossibile";
            string risultato = EquazioniLibrary.Metodi.EquationDegree1(a, b);

            Assert.AreEqual(Convert.ToDouble(x), Convert.ToDouble(risultato));
        }
        //Test con il coefficente "a" positivo e "b" negativo
        [TestMethod]
        public void TestMethod_EquationDegree6()
        {
            double a = 4, b = -5;

            string x = "-1,25";
            string risultato = EquazioniLibrary.Metodi.EquationDegree1(a, b);

            Assert.AreEqual(Convert.ToDouble(x), Convert.ToDouble(risultato));
        }
        //Test con il coefficente "a" negativo e "b" positivo
        [TestMethod]
        public void TestMethod_EquationDegree7()
        {
            double a = -4, b = 5;

            string x = "-1,25";
            string risultato = EquazioniLibrary.Metodi.EquationDegree1(a, b);

            Assert.AreEqual(Convert.ToDouble(x), Convert.ToDouble(risultato));
        }
        //Test con tutti i coefficenti positivi
        [TestMethod]
        public void TestMethod_EquationDegree8()
        {
            double a = 4, b = 5;

            string x = "1,25";
            string risultato = EquazioniLibrary.Metodi.EquationDegree1(a, b);

            Assert.AreEqual(Convert.ToDouble(x), Convert.ToDouble(risultato));
        }
        //Test con tutti i coefficenti negativi
        [TestMethod]
        public void TestMethod_EquationDegree9()
        {
            double a = -4, b = -5;

            string x = "1,25";
            string risultato = EquazioniLibrary.Metodi.EquationDegree1(a, b);

            Assert.AreEqual(Convert.ToDouble(x), Convert.ToDouble(risultato));
        }
    }
}